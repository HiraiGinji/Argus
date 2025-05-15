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
    public partial class inventoryDEL : Form
    {
        string pname;
        private string username;
        public inventoryDEL(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        DatabaseOperations connect = new DatabaseOperations();

        private void inventoryDEL_Load(object sender, EventArgs e)
        {
            displayInventory(new MySqlCommand("SELECT * FROM INVENTORY"));
        }

        public void deleteFunction(string pid)
        {
            try
            {
                connect.deleteRecord(pid);
                displayInventory(new MySqlCommand("SELECT * FROM INVENTORY"));
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



        private void btn_delete_Click(object sender, EventArgs e)
        {
            string pid = txt_pid.Text;

            if (MessageBox.Show($"Are you sure you want to delete this record?\nPID: {pid}", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                deleteFunction(pid);
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

        private void getproductname(string pname)
        {
            string pid = txt_pid.Text;
            try
            {
                pname = connect.GetProductName(pid);
                txt_pname.Text = pname;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void tbl_records_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nud_price_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_pname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nud_qty_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(username);
            admin.Show();
            this.Hide();
        }

        private void txt_pid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string pid = txt_pid.Text;

                if (MessageBox.Show($"Are you sure you want to delete this record?\nPID: {pid}", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    deleteFunction(pid);
                }
            }
        }

        private void txt_pid_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            string pid = txt_pid.Text;

            if (MessageBox.Show($"Are you sure you want to delete this record?\nPID: {pid}", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                deleteFunction(pid);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            searchFunc();
            getproductname(pname);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
