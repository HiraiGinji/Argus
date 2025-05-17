using AForge.Video;
using AForge.Video.DirectShow;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace Argus
{
    public partial class POS_SystemControl : UserControl
    {
        public POS_SystemControl()
        {
            InitializeComponent();
        }
        FilterInfoCollection FIC;
        VideoCaptureDevice VCD;

        DatabaseOperations connect = new DatabaseOperations();
        settersGetters sgValues = new settersGetters();

        private string lastScannedBarcode = string.Empty;
        private DateTime lastScanTime = DateTime.MinValue;
        private string lastProcessedBarcode = string.Empty;
        private bool isProcessingBarcode = false;
        int qty = 1;
        double discount = 1;

        private void btn_pay_Click(object sender, EventArgs e)
        {
            string customer = tb_customer.Text ?? "none";
            payBtnFunc(customer);

            DataTable receiptData = new DataTable();
            foreach (DataGridViewColumn column in tbl_cart.Columns)
            {
                receiptData.Columns.Add(column.Name);
            }

            foreach (DataGridViewRow row in tbl_cart.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    DataRow dataRow = receiptData.NewRow();
                    foreach (DataGridViewColumn column in tbl_cart.Columns)
                    {
                        dataRow[column.Name] = row.Cells[column.Index].Value;
                    }
                    receiptData.Rows.Add(dataRow);
                }
            }

            string total = lbl_total.Text;
            string transaction = lbl_transaction.Text;
            string date = lbl_date.Text;
            string customername = tb_customer.Text;
            string discounttype = cb_discount.SelectedItem.ToString();
            string discountpercent = lbl_discount.Text;

            Receipt receiptForm = new Receipt(receiptData, total, transaction, date, customername, discounttype, discountpercent)
            {
                StartPosition = FormStartPosition.CenterParent,
                Visible = false
            };

            receiptForm.Show();
            receiptForm.Hide();

            DialogResult result = MessageBox.Show("Transaction completed! Would you like to save the receipt?",
                "Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                connect.SaveReceiptToFile(transaction, customername, $"{discounttype} {discountpercent}", total, receiptForm);
            }

            receiptForm.Visible = true;
            receiptForm.FormClosed += (s, args) =>
            {
                searchFunc();
            };
        }

        public void payBtnFunc(string customer)
        {
            string transactionid = lbl_transaction.Text.ToString();
            string customerdc = lbl_discount.Text.ToString();

            decimal subtotal = Convert.ToDecimal(lbl_subtotal.Text);
            decimal total = Convert.ToDecimal(lbl_total.Text);

            connect.transferTransaction(transactionid, customer, customerdc, subtotal, total);
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void cb_discount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_discount.SelectedIndex == 0)
            {
                lbl_discount.Text = "-----";
                discount = 1;
            }
            else if (cb_discount.SelectedIndex == 1)
            {
                lbl_discount.Text = "5%";
                discount = 0.95;
            }
            else if (cb_discount.SelectedIndex == 2)
            {
                lbl_discount.Text = "5%";
                discount = 0.95;
            }

            totalPrice();
        }

        private void tb_customer_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tbl_cart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClearCart()
        {
            MySqlConnection connection = connect.getConnect;
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                MySqlCommand clearCommand = new MySqlCommand("DELETE FROM POS_CART", connection);
                clearCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error clearing cart: {ex.Message}");
            }

            tbl_cart.DataSource = null;
            tbl_cart.Rows.Clear();
            tbl_cart.Columns.Clear();
        }

        public void Cleanup()
        {
            if (VCD != null && VCD.IsRunning)
            {
                VCD.SignalToStop();
                VCD.WaitForStop();
                VCD = null;
            }

            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
        }


        private void POS_SystemControl_Load(object sender, EventArgs e)
        {
            ClearCart();
            pictureBox1.Visible = false;
            txt_Barcode.Visible = false;
            CameraListbox.Visible = false;
            pictureBox1.Visible = false;
            lbl_transaction.Text = connect.GenerateRandomID(7);
            lbl_date.Text = DateTime.Now.ToString();
            searchFunc();
            cb_discount.SelectedIndex = 0;
            if (tbl_cart.Columns["PID"] != null)
            {
                tbl_cart.Columns["PID"].Visible = false;
            }


            tbl_cart.Height = 518;
            tbl_cart.RowTemplate.Height = 30;

            tbl_cart.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            tbl_cart.AutoSize = false;

            pictureBox1.Visible = true;
            FIC = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in FIC)
            {
                CameraListbox.Items.Add(device.Name);
            }
            CameraListbox.SelectedIndex = 0;
        }
        private void CameraListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            VCD = new VideoCaptureDevice(FIC[CameraListbox.SelectedIndex].MonikerString);
            VCD.NewFrame += VideoCaptureDevice_NewFrame;
            VCD.Start();
        }
        private void tb_pid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string pid = tb_pid.Text;

                enterProduct();
                lbl_itemPrice.Text = connect.getPrice(pid);
            }
        }

        private void tb_qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string pid = tb_pid.Text;

                enterProduct();
                lbl_itemPrice.Text = connect.getPrice(pid);
            }
        }
        public void enterProduct()
        {
            string pid = tb_pid.Text;
            string transaction = lbl_transaction.Text;

            if (string.IsNullOrEmpty(pid) || !Regex.IsMatch(pid, @"^[a-zA-Z0-9]{8}$"))
            {
                MessageBox.Show("Invalid Entry");
                return;
            }

            if (!Regex.IsMatch(tb_qty.Text, @"^\d{1,3}$"))
            {
                MessageBox.Show("Invalid Quantity");
                return;
            }

            try
            {
                qty = Convert.ToInt32(tb_qty.Text);
                connect.prodDetails(pid, qty, transaction);

                searchFunc();

                tbl_cart.Height = 518;
                tbl_cart.RowTemplate.Height = 30;

                tbl_cart.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                tbl_cart.AutoSize = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            lbl_subtotal.Text = connect.getSubtotal();
            lbl_itemPrice.Text = connect.getPrice(pid);
            totalPrice();

            tb_qty.Text = "1";
            tb_pid.Focus();
        }

        public void totalPrice()
        {
            decimal subtotal = Convert.ToDecimal(lbl_subtotal.Text);
            decimal total = subtotal * Convert.ToDecimal(discount);
            decimal roundedTotal = Math.Round(total, 2);

            lbl_total.Text = roundedTotal.ToString();
        }



        private void PassBarcode()
        {
            string pid = txt_Barcode.Text;
            tb_pid.Text = pid;
            enterProduct();
            lbl_itemPrice.Text = connect.getPrice(pid);
        }

        private void searchFunc()
        {
            displayInventory(new MySqlCommand($"SELECT PID, PNAME, QUANTITY, TOTAL FROM POS_CART"));
        }

        private void displayInventory(MySqlCommand cmd)
        {
            try
            {
                cmd.Connection = connect.getConnect;
                tbl_cart.ReadOnly = true;
                tbl_cart.Height = 80;
                tbl_cart.DataSource = connect.ShowInventory(cmd);
                // tbl_cart.Columns["PRODUCTID"].Visible = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {

            try
            {
                if (eventArgs.Frame == null) return;

                using (Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone())
                {
                    var reader = new BarcodeReader();
                    var result = reader.Decode(bitmap);

                    if (result != null && txt_Barcode != null && !txt_Barcode.IsDisposed)
                    {
                        string currentBarcode = result.ToString();
                        DateTime currentTime = DateTime.Now;

                        if (currentBarcode != lastScannedBarcode ||
                            (currentTime - lastScanTime).TotalSeconds > 2)
                        {
                            txt_Barcode.Invoke((MethodInvoker)delegate
                            {
                                if (txt_Barcode != null && !txt_Barcode.IsDisposed)
                                {
                                    txt_Barcode.Text = currentBarcode;
                                    lastScannedBarcode = currentBarcode;
                                    lastScanTime = currentTime;
                                    PassBarcode();
                                }
                            });
                        }
                    }

                    if (pictureBox1 != null && !pictureBox1.IsDisposed)
                    {
                        pictureBox1.Invoke((MethodInvoker)delegate
                        {
                            if (pictureBox1 != null && !pictureBox1.IsDisposed)
                            {
                                pictureBox1.Image?.Dispose();
                                pictureBox1.Image = (Bitmap)bitmap.Clone();
                            }
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Barcode scan error: {ex.Message}");
            }
        }

        private void tbl_cart_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CameraListbox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            VCD = new VideoCaptureDevice(FIC[CameraListbox.SelectedIndex].MonikerString);
            VCD.NewFrame += VideoCaptureDevice_NewFrame;
            VCD.Start();
        }

        private void txt_Barcode_TextChanged(object sender, EventArgs e)
        {
        }

        private void POS_SystemControl_Leave(object sender, EventArgs e)
        {
            Cleanup();
            base.Dispose();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
