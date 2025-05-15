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
    public partial class ACCOUNTS : Form
    {
        string username;
        public ACCOUNTS(string username)
        {
            InitializeComponent();
            this.username = username;
            
        }
        
        DatabaseOperations connect = new DatabaseOperations();




        private void btn_back_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(username);
            admin.Show();
            this.Hide();
        }

        private void displayAccounts(MySqlCommand cmd)
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


        private void ACCOUNTS_Load(object sender, EventArgs e)
        {
            displayAccounts(new MySqlCommand("SELECT * FROM ACCOUNTS"));
        }
    }
}
