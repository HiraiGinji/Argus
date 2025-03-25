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
        public Admin()
        {
            InitializeComponent();
        }

        private void btn_register_acc_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationform = new RegistrationForm();
            registrationform.Show();
            this.Hide();
        }
    }
}
