using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop.BusinessLogic;

namespace Shop.presentation.Controlls
{
    public partial class UserControlHisPassword : UserControl
    {
        private UserServices userServices;

        public UserControlHisPassword()
        {
            InitializeComponent();
            userServices = new UserServices(ConfigurationManager.ConnectionStrings["ShowDB"].ConnectionString);

        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (!ShowPass.Checked)
            {
                text_Confirm.UseSystemPasswordChar = true;
                text_new.UseSystemPasswordChar = true;
                text_OLD.UseSystemPasswordChar = true;
            }
            else
            {
                text_Confirm.UseSystemPasswordChar = false;
                text_new.UseSystemPasswordChar = false;
                text_OLD.UseSystemPasswordChar = false;
            }
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int U_id = userServices.GetUser();
            DataTable dt = userServices.GetUserById(U_id);

            
            string storedHashedPassword = dt.Rows[0]["Password"].ToString();

           
            string hashedOldPassword = HashPassword(text_OLD.Text);

            if (hashedOldPassword == storedHashedPassword)
            {
                // Check if the new password and confirm password match
                if (text_new.Text == text_Confirm.Text)
                {
                    // Hash the new password before storing it in the database
                    string newHashedPassword = HashPassword(text_new.Text);

                    bool isUpdated = userServices.UpdatePassword(U_id, newHashedPassword);

                    if (isUpdated)
                    {
                        MessageBox.Show("Password updated successfully.");
                        text_OLD.Text = string.Empty;
                        text_new.Text = string.Empty;
                        text_Confirm.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Failed to update password. Please try again.");
                    }
                }
                else
                {
                    MessageBox.Show("New password and confirm password do not match.");
                }
            }
            else
            {
                MessageBox.Show("Old password is incorrect.");
            }
        }

    }

}