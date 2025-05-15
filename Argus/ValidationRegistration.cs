using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Argus
{
    public class ValidationRegistration
    {
        public static bool ValidateFirstName(string FirstName, TextBox Txt_Fname, PictureBox PboxIncorrect)
        {
            string Pattern = @"^[a-zA-Z0-9\s'-]+$";
            bool isValid = Regex.IsMatch(FirstName, Pattern);

            PboxIncorrect.Visible = !isValid;
            Txt_Fname.ForeColor = isValid ? Color.Black : Color.Red;

            return isValid;
        }

        public static bool ValidateLastName(string LastName, TextBox Txt_Lname, PictureBox PboxIncorrect1)
        {
            string Pattern = @"^[a-zA-Z0-9\s'-]+$";
            bool isValid = Regex.IsMatch(LastName, Pattern);

            PboxIncorrect1.Visible = !isValid;
            Txt_Lname.ForeColor = isValid ? Color.Black : Color.Red;

            return isValid;
        }

        public static bool ValidateEmail(string Email, TextBox Txt_Email, PictureBox PboxIncorrect2, Func<string, bool> emailExistsFunc)
        {
            string Pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            bool isFormatValid = Regex.IsMatch(Email, Pattern);

            bool isUnique = !emailExistsFunc(Email);
            bool isValid = isFormatValid && isUnique;

            PboxIncorrect2.Visible = !isValid;
            Txt_Email.ForeColor = isValid ? Color.Black : Color.Red;

            return isValid;

        }

        public static bool ValidateContactNumber(string ContactNo, TextBox Txt_Contactno, PictureBox PboxIncorrect3)
        {
            string Pattern = @"^\d{10,11}$";
            bool isValid = Regex.IsMatch(ContactNo, Pattern);

            PboxIncorrect3.Visible = !isValid;
            Txt_Contactno.ForeColor = isValid ? Color.Black : Color.Red;

            return isValid;
        }

        public static bool ValidateTelephone(string Telephone, TextBox Txt_Telephone, PictureBox PboxIncorrect4, out string processedTelephone)
        {
            if (string.IsNullOrWhiteSpace(Telephone))
            {
                processedTelephone = "N/A";
                PboxIncorrect4.Visible = false;
                Txt_Telephone.ForeColor = Color.Black;
                return true;
            }

            string Pattern = @"^\d{10,11}$";
            bool isValid = Regex.IsMatch(Telephone, Pattern);

            PboxIncorrect4.Visible = !isValid;
            Txt_Telephone.ForeColor = isValid ? Color.Black : Color.Red;

            processedTelephone = isValid ? Telephone : null;
            return isValid;
        }

        public static bool ValidatePassword(string Password, TextBox Txt_Pass, PictureBox PboxIncorrect5)
        {
            bool isValid = Password.Length >= 8;

            PboxIncorrect5.Visible = !isValid;
            Txt_Pass.ForeColor = isValid ? Color.Black : Color.Red;

            return isValid;
        }

        public static bool ValidatePasswordConfirmation(string Password, string PasswordConfirm, TextBox Txt_Passconfirm, PictureBox PboxIncorrect6)
        {
            bool isValid = Password == PasswordConfirm;

            PboxIncorrect6.Visible = !isValid;
            Txt_Passconfirm.ForeColor = isValid ? Color.Black : Color.Red;

            return isValid;
        }
    }
}