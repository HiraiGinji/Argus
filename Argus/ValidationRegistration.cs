using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Argus
{
    public class ValidationRegistration
    {
        public static bool ValidateFirstName(string FirstName, TextBox Txt_Fname)
        {
            string Pattern = @"^[a-zA-Z0-9\s'-]+$";  // Letters, numbers, spaces, apostrophes, and hyphens
            if (!Regex.IsMatch(FirstName, Pattern))
            {
                MessageBox.Show("Input a valid first name");
                Txt_Fname.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            Txt_Fname.ForeColor = System.Drawing.Color.Black;
            return true;
        }

        public static bool ValidateLastName(string LastName, TextBox Txt_Lname)
        {
            string Pattern = @"^[a-zA-Z0-9\s'-]+$";  // Letters, numbers, spaces, apostrophes, and hyphens
            if (!Regex.IsMatch(LastName, Pattern))
            {
                MessageBox.Show("Input a valid last name");
                Txt_Lname.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            Txt_Lname.ForeColor = System.Drawing.Color.Black;
            return true;
        }

        public static bool ValidateEmail(string Email, TextBox Txt_Email)
        {
            string Pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";  // Email pattern
            if (!Regex.IsMatch(Email, Pattern))
            {
                MessageBox.Show("Input a valid email");
                Txt_Email.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            Txt_Email.ForeColor = System.Drawing.Color.Black;
            return true;
        }

        public static bool ValidateContactNumber(string ContactNo, TextBox Txt_Contactno)
        {
            string Pattern = @"^\d{10,11}$";  // Numbers only, 10 or 11 digits
            if (!Regex.IsMatch(ContactNo, Pattern))
            {
                MessageBox.Show("Input a valid contact number");
                Txt_Contactno.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            Txt_Contactno.ForeColor = System.Drawing.Color.Black;
            return true;
        }

        public static bool ValidateTelephone(string Telephone, TextBox Txt_Telephone, out string processedTelephone)
        {
            // If field is empty, return "N/A" and consider it valid
            if (string.IsNullOrWhiteSpace(Telephone))
            {
                processedTelephone = "N/A";
                Txt_Telephone.ForeColor = System.Drawing.Color.Black;
                return true;
            }

            // If field has input, validate it
            string Pattern = @"^\d{10,11}$";  // Numbers only, 10 or 11 digits
            if (!Regex.IsMatch(Telephone, Pattern))
            {
                MessageBox.Show("Input a valid telephone number (10-11 digits) or leave empty");
                Txt_Telephone.ForeColor = System.Drawing.Color.Red;
                processedTelephone = null;
                return false;
            }

            processedTelephone = Telephone;
            Txt_Telephone.ForeColor = System.Drawing.Color.Black;
            return true;
        }

        public static bool ValidatePassword(string Password, TextBox Txt_Pass)
        {
            if (Password.Length < 8)  //At least 8 characters
            {
                MessageBox.Show("Password should be at least 8 characters minimum");
                Txt_Pass.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            Txt_Pass.ForeColor = System.Drawing.Color.Black;
            return true;
        }

        public static bool ValidatePasswordConfirmation(string Password, string PasswordConfirm, TextBox Txt_Passconfirm)
        {
            if (Password != PasswordConfirm)  // Check if passwords match
            {
                MessageBox.Show("Password confirmation does not match with password");
                Txt_Passconfirm.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            Txt_Passconfirm.ForeColor = System.Drawing.Color.Black;
            return true;
        }
    }
}
