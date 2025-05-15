using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Argus
{
    public partial class inventoryADD : Form
    {
        private string username;
        public inventoryADD(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        DatabaseOperations connect = new DatabaseOperations();

        private void clearFunc()
        {
            txt_pname.Text = " ";
            nud_price.Value = 0;
            nud_price.Value = 0;
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

        public void createFunc()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_pname.Text))
                {
                    MessageBox.Show("Please enter a product name.");
                    return;
                }

                string itmName = txt_pname.Text.ToUpper();
                decimal itmPrice = nud_price.Value;
                int itmQuantity = (int)nud_qty.Value;


                if (itmPrice <= 0)
                {
                    MessageBox.Show("Price must be greater than zero.");
                    return;
                }

                if (itmQuantity <= 0 || itmQuantity > 100)
                {
                    MessageBox.Show("Quantity must be between 1 and 100.");
                    return;
                }

                string productId = connect.GetProductId(itmName);

                if (!string.IsNullOrEmpty(productId))
                {
                    MessageBox.Show("Product already exists with ID: " + productId);
                }
                else
                {
                    connect.addRecord(itmName, itmPrice, itmQuantity);
                    MessageBox.Show("Product added successfully.");
                }

                displayInventory(new MySqlCommand("SELECT * FROM INVENTORY"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        private void tbl_records_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void inventoryADD_Load(object sender, EventArgs e)
        {
            displayInventory(new MySqlCommand("SELECT * FROM INVENTORY ORDER BY QTY"));
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(username);
            admin.Show();
            this.Hide();
        }

        private void inventoryADD_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            createFunc();
            clearFunc();
        }
    }
}
