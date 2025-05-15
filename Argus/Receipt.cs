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
        public Receipt(DataTable data, string total, string transaction, string date, string customername, string discounttype, string discountpercent)
        {
            InitializeComponent();
            dataGridView1.DataSource = data;
            lbl_total_receipt.Text = total;
            lbl_transaction_receipt.Text = transaction;
            lbl_date_receipt.Text = date;
            lbl_customer_receipt.Text = customername;
            lbl_discount_receipt.Text = discounttype;
            lbl_discountpercent.Text = discountpercent;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
