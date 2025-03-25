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
    public partial class RegistrationForm : Form
    {

        private RegistrationOperations registrationOperations;
        private DatabaseOperations databaseOperations;
        public RegistrationForm()
        {
            InitializeComponent();
            databaseOperations = new DatabaseOperations();
            registrationOperations = new RegistrationOperations(this);
            cmb_region.SelectedIndexChanged += cmb_region_SelectedIndexChanged;

            this.DoubleBuffered = true;
            this.Paint += registrationOperations.HandleFormPaint;
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
                string Email = txt_email.Text;
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

                isValid &= ValidationRegistration.ValidateFirstName(FirstName, txt_fname);
                isValid &= ValidationRegistration.ValidateLastName(LastName, txt_lname);
                isValid &= ValidationRegistration.ValidateEmail(Email, txt_email);
                isValid &= ValidationRegistration.ValidateContactNumber(ContactNo, txt_contactno);

                if (!ValidationRegistration.ValidateTelephone(txt_telephone.Text, txt_telephone, out Telephone))
                {
                    isValid = false;
                }

                isValid &= ValidationRegistration.ValidatePassword(Password, txt_pass);
                isValid &= ValidationRegistration.ValidatePasswordConfirmation(Password, PasswordConfirm, txt_passconfirm);

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
                    Admin admin = new Admin();
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
    }
}
