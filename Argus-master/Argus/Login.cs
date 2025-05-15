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
    public partial class Login : Form
    {
        private string username;
        private LoginOperations loginOperations;
        private DatabaseOperations databaseOperations;
        settersGetters sgValues = new settersGetters();
        public Login()
        {
            InitializeComponent();
            databaseOperations = new DatabaseOperations();

            this.DoubleBuffered = true;
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        public void loginFunction()
        {
            string email = txt_email.Text;
            string password = txt_password.Text;

            try
            {
                bool isValid = databaseOperations.ValidateLogin(email, password);

                if (isValid)
                {
                    var UserCredentials = databaseOperations.GetUserCredentials(email);

                    if (UserCredentials.IsAdmin == 0)
                    {
                        User UserForm = new User();

                        sgValues.sg_user = UserCredentials.FirstName;
                        sgValues.sg_uid = UserCredentials.uid.ToString();

                        UserForm.lbl_username.Text = UserCredentials.FirstName;
                        UserForm.Show();
                        this.Hide();
                    }
                    else if (UserCredentials.IsAdmin == 1)
                    {
                        Admin admin = new Admin(UserCredentials.FirstName);

                        sgValues.sg_user = UserCredentials.FirstName;
                        sgValues.sg_uid = UserCredentials.uid.ToString();

                        admin.lbl_username.Text = UserCredentials.FirstName;
                        admin.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid email or password. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            loginFunction();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
