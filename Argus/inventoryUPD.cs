using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Argus
{
    public partial class inventoryUPD : Form
    {
        private string username;
        public inventoryUPD(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        DatabaseOperations connect = new DatabaseOperations();

        private void inventoryUPD_Load(object sender, EventArgs e)
        {
            displayInventory(new MySqlCommand("SELECT * FROM INVENTORY"));
        }

        public void searchInfo()
        {
            try
            {
                string pid = txt_pid.Text;
                DataTable dt = connect.searchProduct(pid);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txt_pname.Text = row["PNAME"].ToString();
                    nud_price.Text = row["ITEMPRICE"].ToString();
                    nud_qty.Text = row["QTY"].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private void searchFunc()
        {
            string pid = txt_pid.Text;
            displayInventory(new MySqlCommand($"SELECT * FROM INVENTORY WHERE PID LIKE '%{pid}%'"));
        }

        public void updateTransistion()
        {
            try
            {
                string pid = txt_pid.Text;
                updateFunction(pid);
                displayInventory(new MySqlCommand("SELECT * FROM INVENTORY"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private void displayInventory(MySqlCommand cmd)
        {
            try
            {
                cmd.Connection = connect.getConnect;
                tbl_records.ReadOnly = true;
                tbl_records.DataSource = connect.ShowInventory(cmd);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            searchInfo();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            updateTransistion();
        }
        private void updateFunction(string pid)
        {
            try
            {
                string priceRegex = @"^\d{4}\.\d{2}$", qtyRegex = @"^\d{1,3}$";
                string itemPrice = nud_price.Text;
                string itemQuantity = nud_qty.Text;

                string itmName, itmPrice, itmQuantity;

                Regex priceReg = new Regex(priceRegex);
                Regex qtyReg = new Regex(qtyRegex);

                if (txt_pname.Text == "" || nud_price.Text == "" || nud_qty.Value == 0)
                {
                    MessageBox.Show("Please complete all fields");
                }
                else if (Regex.IsMatch(itemPrice, itemPrice.ToString()) == false)
                {
                    MessageBox.Show("Invalid Price");
                }
                else if (Regex.IsMatch(itemQuantity, qtyRegex) == false || Convert.ToInt32(nud_qty.Text) > 200)
                {
                    MessageBox.Show("Invalid Quantity");
                }
                else
                {
                    itmName = txt_pname.Text.ToUpper();
                    itmPrice = nud_price.Text.ToString();
                    itmQuantity = nud_qty.Text.ToString();
   

                    connect.updateRecord(itmName, itmPrice, itmQuantity, pid);
                    displayInventory(new MySqlCommand("SELECT * FROM INVENTORY"));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(username);
            admin.Show();
            this.Hide();
        }

        private void txt_pid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
