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
    public partial class Admin : Form
    {
        private string username;

        public Admin(string user)
        {
            InitializeComponent();
            lbl_username.Text = user;
            username = lbl_username.Text.ToString();

        }

        private void btn_register_acc_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationform = new RegistrationForm(username);
            registrationform.Show();
            this.Hide();
        }

        private void btn_addInventory_Click(object sender, EventArgs e)
        {
            inventoryADD inventoryADD = new inventoryADD(username);
            inventoryADD.Show();
            this.Hide();
        }

        private void btn_deleteINV_Click(object sender, EventArgs e)
        {
            inventoryDEL inventoryDEL = new inventoryDEL(username);
            inventoryDEL.Show();
            this.Hide();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_acc_Click(object sender, EventArgs e)
        {
            ACCOUNTS acc = new ACCOUNTS(username);
            acc.Show();
            this.Hide();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            inventoryUPD inventoryUPD = new inventoryUPD(username);
            inventoryUPD.Show();
            this.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            CheckLowStock();
        }

        private void CheckLowStock()
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=argus;user=root;password=;"))
            {
                string query = "SELECT COUNT(*) FROM inventory WHERE QTY < 50";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    int lowStockCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (lowStockCount > 0)
                    {
                        ShowAlert();
                    }
                }
            }
        }

        private void ShowAlert()
        {
            List<string> lowStockProducts = GetLowStockProducts();

            if (lowStockProducts.Count > 0)
            {
                string productNames = string.Join(", ", lowStockProducts);

                Alert alertForm = new Alert(productNames);
                alertForm.StartPosition = FormStartPosition.Manual;

                int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
                int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
                int x = screenWidth - alertForm.Width - 10;
                int y = screenHeight - alertForm.Height - 10;
                alertForm.Location = new Point(x, y);

                alertForm.Show();

                Task.Delay(999999).ContinueWith(t => alertForm.Invoke((Action)(() => alertForm.Close())));
            }
        }

        private List<string> GetLowStockProducts()
        {
            List<string> productNames = new List<string>();

            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=argus;user=root;password=;"))
            {
                string query = "SELECT PNAME FROM inventory WHERE QTY < 50";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            productNames.Add(reader["PNAME"].ToString());
                        }
                    }
                }
            }
            return productNames;
        }
    }
}
