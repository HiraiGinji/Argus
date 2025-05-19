using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Argus
{
    public partial class Receipt : Form
    {
        public Receipt(DataTable data, string total, string transaction, string date,
                      string customername, string discounttype, string discountpercent,
                      string taxAmount, string cashierName)
        {
            InitializeComponent();
            dataGridView1.DataSource = data;
            lbl_total_receipt.Text = total;
            lbl_transaction_receipt.Text = transaction;
            lbl_date_receipt.Text = date;
            lbl_customer_receipt.Text = customername;
            lbl_discount_receipt.Text = discounttype;
            lbl_discountpercent.Text = discountpercent;
            lbl_vat.Text = taxAmount;
            lbl_cashier.Text = cashierName;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            lbl_total_receipt.AutoSize = false;
            lbl_total_receipt.Width = 100;
            lbl_total_receipt.TextAlign = ContentAlignment.MiddleRight;
            lbl_total_receipt.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            lbl_vat.AutoSize = false;
            lbl_vat.Width = 100;
            lbl_vat.TextAlign = ContentAlignment.MiddleRight;
            lbl_vat.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            if (decimal.TryParse(lbl_vat.Text, out decimal vat))
            {
                lbl_vat.Text = vat.ToString("₱0.00");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_transaction_receipt_Click(object sender, EventArgs e)
        {

        }

        private void lbl_date_receipt_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lbl_cashier_Click(object sender, EventArgs e)
        {

        }

        private void lbl_customer_receipt_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lbl_discountpercent_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lbl_total_receipt_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
