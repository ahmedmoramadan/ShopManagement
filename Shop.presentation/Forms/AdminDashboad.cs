using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop.BusinessLogic;
using Shop.presentation.Controlls;

namespace Shop.presentation.Forms
{
    public partial class AdminDashboad : Form
    {
        private readonly UserControlUsers userControlUsers;
        private readonly UserControlProducts userControlProducts;
        private readonly UserControlCategories userControlCategories;

        public AdminDashboad()
        {
            InitializeComponent();
            // Initialize UserControlUsers with Mainpanel
            userControlUsers = new UserControlUsers(Mainpanel);
            userControlProducts = new UserControlProducts(Mainpanel);
            userControlCategories = new UserControlCategories(Mainpanel);
        }

        private void AdminDashboad_Load(object sender, EventArgs e)
        {
            // Load any initial data or setup
        }

        public void ClearPanel()
        {
            Mainpanel.Controls.Clear();
        }

        private void Btn_ManageUsers_Click(object sender, EventArgs e)
        {
            ClearPanel();

            // Add UserControlUsers to Mainpanel
            userControlUsers.Dock = DockStyle.Fill;
            Mainpanel.Controls.Add(userControlUsers);
            userControlUsers.LoadUsersData();
            userControlUsers.HideButtons();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            ClearPanel();

            // Add UserControlUsers to Mainpanel
            userControlCategories.Dock = DockStyle.Fill;
            Mainpanel.Controls.Add(userControlCategories);
            userControlCategories.LoadCategoriesData();

        }
        #region Back , Close 
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            SharedClass.Instance.GoTOWelcomePage(this);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
        #endregion

        private void btn_manageProducts_Click(object sender, EventArgs e)
        {
            ClearPanel();

            // Add UserControlUsers to Mainpanel
            userControlProducts.Dock = DockStyle.Fill;
            Mainpanel.Controls.Add(userControlProducts);
            userControlProducts.LoadCategoriesDataIN_CB();
            userControlProducts.LoadProductsData();

        }
    }
}