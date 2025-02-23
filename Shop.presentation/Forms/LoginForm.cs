using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;
using Azure;
using Shop.BusinessLogic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net;
using System.Configuration;
using Shop.presentation.Forms;

namespace Shop.presentation
{
    public partial class LoginForm : Form
    {
        UserServices _userServices;
       // public string UserName { get; private set; }
        public LoginForm()
        {
            //UserName = "";
            InitializeComponent();
            _userServices = new UserServices(ConfigurationManager.ConnectionStrings["ShowDB"].ConnectionString);

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
            {
                text_password.UseSystemPasswordChar = false;
            }
            else
            {
                text_password.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void ClearForm()
        {
            // Clear all input fields
            text_password.Text = string.Empty;
            textBox1.Text = string.Empty;
        }
        
        private void Back_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.Show();
            this.Hide();
        }
        private void Login_Click(object sender, EventArgs e)
        {
            string UserName = textBox1.Text;
            string Password = text_password.Text;

            string isfounded = _userServices.LoginUser(UserName, Password);

            if (isfounded != null) 
            {

                if (isfounded == "User")
                {
                    MessageBox.Show("User login successfully!");

                    UserDashboard userDashboard = new UserDashboard();
                    userDashboard.Show();
                }
                else if(isfounded == "Admin")
                {
                    MessageBox.Show("Admin login successfully!");

                    AdminDashboad adminDashboad = new AdminDashboad();
                    adminDashboad.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Failed to register user. Please try again.");
            }

        }
    }
}
