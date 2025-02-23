using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop.BusinessLogic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Shop.presentation
{
    public partial class RegisterForm : Form
    {
        UserServices _userServices;
        public RegisterForm()
        {
            InitializeComponent();
            _userServices = new UserServices(ConfigurationManager.ConnectionStrings["ShowDB"].ConnectionString);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ShowPasss();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.Show();
            this.Hide();
        }
       // private void ClearForm()
        //{
        //    // Clear all input fields
        //    text_password.Text = string.Empty;
        //    txt_Username.Text = string.Empty;
        //    txt_confirm.Text = string.Empty;
        //    N_age.Value = 0;
        //    txt_email.Text = string.Empty;


        //}
        private void ShowPasss()
        {
            if (checkBox1.Checked)
            {
                text_password.UseSystemPasswordChar = false;
                txt_confirm.UseSystemPasswordChar = false;
            }
            else
            {
                text_password.UseSystemPasswordChar = true;
                txt_confirm.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var defaultValues = _userServices.GetDefaultUserValues();

            txt_Username.Text = defaultValues.username;
            text_password.Text = defaultValues.password;
            txt_confirm.Text = defaultValues.confirmPassword;
            txt_email.Text = defaultValues.email;
            N_age.Value = defaultValues.age;
            txt_address.Text = defaultValues.address;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        #region Register
        //private void Register_Click(object sender, EventArgs e)
        //{
        //    // Get user input
        //    string username = txt_Username.Text;
        //    string confirmPassword = txt_confirm.Text;
        //    string email = txt_email.Text;
        //    int age = (int)N_age.Value;
        //    string address = txt_address.Text;
        //    string password = text_password.Text;

        //    // Validate input
        //    if (!ValidateInput(username, email, password, confirmPassword, age))
        //    {
        //        return; // Stop if validation fails
        //    }

        //    if (_userServices.IsUsernameTaken(username))
        //    {
        //        MessageBox.Show("Username is already taken. Please choose a different username.");
        //        return;
        //    }

        //    // Check if email is already registered
        //    if (_userServices.IsEmailTaken(email))
        //    {
        //        MessageBox.Show("Email is already registered. Please use a different email.");
        //        return;
        //    }
        //    // Register the user
        //    bool isRegistered = _userServices.RegisterUser(username, password, email, age, address);

        //    if (isRegistered)
        //    {
        //        MessageBox.Show("User registered successfully!");
        //        var loginForm = new LoginForm();
        //        loginForm.Show();
        //        this.Hide();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Failed to register user. Please try again.");
        //    }
        //}
        //private bool ValidateInput(string username, string email, string password, string confirmPassword, int age)
        //{
        //    if (string.IsNullOrWhiteSpace(username))
        //    {
        //        MessageBox.Show("Username is invalid. It must contain text.");
        //        return false;
        //    }

        //    if (!Regex.IsMatch(email, @"^[^@\s]+@gmail\.com$"))
        //    {
        //        MessageBox.Show("Email is invalid. It must be in the format 'name@gmail.com'.");
        //        return false;
        //    }

        //    if (password.Length < 6)
        //    {
        //        MessageBox.Show("Password is invalid. It must be at least 6 characters long.");
        //        return false;
        //    }

        //    if (password != confirmPassword)
        //    {
        //        MessageBox.Show("Passwords do not match.");
        //        return false;
        //    }

        //    if (age <= 0)
        //    {
        //        MessageBox.Show("Age is invalid. It must be greater than 0.");
        //        return false;
        //    }

        //    return true;
        //}


        #endregion
        private void Register_Click(object sender, EventArgs e)
        {
            // Get user input
            string username = txt_Username.Text;
            string confirmPassword = txt_confirm.Text;
            string email = txt_email.Text;
            int age = (int)N_age.Value;
            string address = txt_address.Text;
            string password = text_password.Text;

            // Call the validation method from UserServices
            var validationResult = _userServices.ValidateUserInput(username, email, password, confirmPassword, age);

            // If validation fails, show the message and stop further execution
            if (!validationResult.isValid)
            {
                MessageBox.Show(validationResult.message);
                return;
            }

            // Check if username is already taken
            if (_userServices.IsUsernameTaken(username))
            {
                MessageBox.Show("Username is already taken. Please choose a different username.");
                return;
            }

            // Check if email is already registered
            if (_userServices.IsEmailTaken(email))
            {
                MessageBox.Show("Email is already registered. Please use a different email.");
                return;
            }

            // Register the user
            bool isRegistered = _userServices.RegisterUser(username, password, email, age, address);

            if (isRegistered)
            {
                MessageBox.Show("User registered successfully!");
                var loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Failed to register user. Please try again.");
            }
        }

    }
}

