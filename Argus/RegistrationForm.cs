using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Argus
{
    public partial class RegistrationForm : Form
    {
        private string username;
        private RegistrationOperations registrationOperations;
        private DatabaseOperations databaseOperations;
        public RegistrationForm(string user)
        {
            InitializeComponent();
            databaseOperations = new DatabaseOperations();
            registrationOperations = new RegistrationOperations(this);
            cmb_region.SelectedIndexChanged += cmb_region_SelectedIndexChanged;

            this.DoubleBuffered = true;
            this.Paint += registrationOperations.HandleFormPaint;

            username = user;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            cmb_email.Items.AddRange(new string[] {
        "@yahoo.com",
        "@gmail.com",
        "@outlook.com",
        "@icloud.com"
    });

            cmb_email.SelectedIndex = 1;

            cmb_email.DropDownStyle = ComboBoxStyle.DropDownList;

            txt_email.TextChanged += Txt_email_TextChanged;
        }

        private void Txt_email_TextChanged(object sender, EventArgs e)
        {
            string currentText = txt_email.Text;
            int atIndex = currentText.IndexOf('@');

            if (atIndex >= 0)
            {
                MessageBox.Show("Please select your email domain from the dropdown instead of typing it.");

                txt_email.Text = currentText.Substring(0, atIndex);
                txt_email.SelectionStart = txt_email.Text.Length;
            }
        }

        private bool EmailExists(string email)
        {
            bool exists = false;

            try
            {
                string connectionString = "server=localhost;database=argus;user=root;password=";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM accounts WHERE EMAIL = @Email", conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        exists = count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
                exists = false;
            }

            return exists;
        }


        private void cmb_region_SelectedIndexChanged(object sender, EventArgs e)
        {
            registrationOperations.ChangeCityCMB(cmb_region, cmb_city);
        }

        public void fieldValidation()
        {
            try
            {
                string FirstName = txt_fname.Text;
                string LastName = txt_lname.Text;
                string emailPrefix = txt_email.Text;
                string emailDomain = cmb_email.SelectedItem?.ToString() ?? "";
                string Email = emailPrefix + emailDomain;
                string ContactNo = txt_contactno.Text;
                string Telephone;
                string Password = txt_pass.Text;
                string PasswordConfirm = txt_passconfirm.Text;
                string Region = cmb_region.SelectedItem?.ToString();
                string City = cmb_city.SelectedItem?.ToString();

                bool isValid = true;

                if (string.IsNullOrWhiteSpace(FirstName) ||
                    string.IsNullOrWhiteSpace(LastName) ||
                    string.IsNullOrWhiteSpace(Email) ||
                    string.IsNullOrWhiteSpace(ContactNo) ||
                    string.IsNullOrWhiteSpace(Password) ||
                    string.IsNullOrWhiteSpace(PasswordConfirm) ||
                    cmb_region.SelectedItem == null ||
                    cmb_city.SelectedItem == null)
                {
                    MessageBox.Show("Please complete all required fields");
                    return;
                }

                isValid &= ValidationRegistration.ValidateFirstName(FirstName, txt_fname, pbox_incorrect);
                isValid &= ValidationRegistration.ValidateLastName(LastName, txt_lname, pbox_incorrect1);
                isValid &= ValidationRegistration.ValidateEmail(Email, txt_email, pbox_incorrect2, EmailExists);
                isValid &= ValidationRegistration.ValidateContactNumber(ContactNo, txt_contactno, pbox_incorrect3);

                if (!ValidationRegistration.ValidateTelephone(txt_telephone.Text, txt_telephone, pbox_incorrect4, out Telephone))
                {
                    isValid = false;
                }

                isValid &= ValidationRegistration.ValidatePassword(Password, txt_pass, pbox_incorrect5);
                isValid &= ValidationRegistration.ValidatePasswordConfirmation(Password, PasswordConfirm, txt_passconfirm, pbox_incorrect6);

                if (!isValid)
                {
                    return;
                }

                bool isInserted = databaseOperations.InsertAccount(
                    FirstName,
                    LastName,
                    Email,
                    ContactNo,
                    Telephone,
                    Password,
                    Region,
                    City);

                MessageBox.Show(isInserted ? "Registration successful!" : "Registration failed. Please try again.");

                if (isInserted)
                {
                    Admin admin = new Admin(username);
                    admin.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

private void btn_register_Click(object sender, EventArgs e)
        {
            fieldValidation();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(username);
            admin.Show();
            this.Hide();
        }

        private void txt_telephone_TextChanged(object sender, EventArgs e)
        {
            string dummy;
            ValidationRegistration.ValidateTelephone(txt_telephone.Text, txt_telephone, pbox_incorrect4, out dummy);
        }

        private void txt_fname_TextChanged(object sender, EventArgs e)
        {
            ValidationRegistration.ValidateFirstName(txt_fname.Text, txt_fname, pbox_incorrect);
        }

        private void txt_lname_TextChanged(object sender, EventArgs e)
        {
            ValidationRegistration.ValidateLastName(txt_lname.Text, txt_lname, pbox_incorrect1);
        }

        private void txt_email_TextChanged_1(object sender, EventArgs e)
        {
            string emailPrefix = txt_email.Text;
            string emailDomain = cmb_email.SelectedItem?.ToString() ?? "";
            string fullEmail = emailPrefix + emailDomain;

            ValidationRegistration.ValidateEmail(fullEmail, txt_email, pbox_incorrect2, EmailExists);
        }

        private void txt_contactno_TextChanged(object sender, EventArgs e)
        {
            ValidationRegistration.ValidateContactNumber(txt_contactno.Text, txt_contactno, pbox_incorrect3);
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            ValidationRegistration.ValidatePassword(txt_pass.Text, txt_pass, pbox_incorrect5);
        }

        private void txt_passconfirm_TextChanged(object sender, EventArgs e)
        {
            ValidationRegistration.ValidatePasswordConfirmation(txt_pass.Text, txt_passconfirm.Text, txt_passconfirm, pbox_incorrect6);
        }

        private void pbox_incorrect4_Click(object sender, EventArgs e)
        {

        }
    }
}
