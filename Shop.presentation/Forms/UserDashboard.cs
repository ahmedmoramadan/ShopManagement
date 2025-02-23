using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop.presentation.Controlls;

namespace Shop.presentation.Forms
{
    public partial class UserDashboard : Form
    {
        private readonly UserControlFavorite userControlFavorite;
        private readonly UserControlHisPassword userControlHisPassword;
        private readonly UserControlShowProducts userControlShowProducts;
        private Panel Panel;
        public UserDashboard()
        {
            InitializeComponent();
            userControlFavorite = new UserControlFavorite();
            userControlHisPassword = new UserControlHisPassword();
            userControlShowProducts = new UserControlShowProducts(Panel);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SharedClass.Instance.GoTOWelcomePage(this);
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {

        }

        private void Btn_ShowProducts_Click(object sender, EventArgs e)
        {
            ClearPanel();

            // Add UserControlUsers to Mainpanel
            userControlShowProducts.Dock = DockStyle.Fill;
            Mainpanel.Controls.Add(userControlShowProducts);
            //userControlShowProducts.LoadUsersData();
        }
        public void ClearPanel()
        {
            Mainpanel.Controls.Clear();
        }

        private void btn_manageProducts_Click(object sender, EventArgs e)
        {
            ClearPanel();
            userControlFavorite.Dock = DockStyle.Fill;
            Mainpanel.Controls.Add(userControlFavorite);
        }

        private void btn_manageCategories_Click(object sender, EventArgs e)
        {
            ClearPanel();
            userControlHisPassword.Dock = DockStyle.Fill;
            Mainpanel.Controls.Add(userControlHisPassword);
        }

        private void Back_Click(object sender, EventArgs e)
        {

        }
    }
}
