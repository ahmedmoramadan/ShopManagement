using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop.BusinessLogic;

namespace Shop.presentation.Controlls
{
    public partial class UserControlProducts : UserControl
    {
        private CategoryServices categoryServices;
        private ProductServices productServices;
        private Panel _panel;
        int P_id;

        public UserControlProducts(Panel panel)
        {
            InitializeComponent();
            _panel = panel;
            categoryServices = new CategoryServices(ConfigurationManager.ConnectionStrings["ShowDB"].ConnectionString);
            productServices = new ProductServices(ConfigurationManager.ConnectionStrings["ShowDB"].ConnectionString);

        }

        private void Back_Click(object sender, EventArgs e)
        {
            _panel.Controls.Remove(this);

        }
        private void dgv_users_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            P_id = (int)(dgv_Products.SelectedRows[0].Cells[0].Value)!;

            DataTable dt = productServices.GetById(P_id);

            // Check if data is returned
            if (dt.Rows.Count > 0)
            {
                txt_Productname.Text = dt.Rows[0]["ProductName"].ToString();
                n_Price.Value = (decimal)dt.Rows[0]["Price"];
                CB_Categories.SelectedValue = dt.Rows[0]["CategoryId"];
            }
            else
            {
                MessageBox.Show("product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            DefaultView(false);
        }

        public void LoadProductsData()
        {
            try
            {
                DataTable dt = productServices.GetAllProducts();
                dgv_Products.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading Products: " + ex.Message);
            }
        }
        public void LoadCategoriesDataIN_CB()
        {
            try
            {
                DataTable dt = categoryServices.GetAllCategories();
                CB_Categories.DataSource = dt;
                CB_Categories.DisplayMember = "CategoryName";
                CB_Categories.ValueMember = "CategoryId";

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading users: " + ex.Message);
            }
        }
        public void DefaultView(bool isDefault)
        {
            if (isDefault)
            {
                btn_Add.Show();
                btn_Delete.Visible = false;
                btn_update.Visible = false;
            }
            else
            {
                btn_Add.Hide();
                btn_Delete.Visible = true;
                btn_update.Visible = true;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            bool isDeleted = productServices.Delete(P_id);

            if (isDeleted)
            {
                MessageBox.Show("Product deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DefaultView(true);
            }
            else
            {
                MessageBox.Show("Failed to delete the product. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var result = productServices.Update(txt_Productname.Text, n_Price.Value, P_id, (int)CB_Categories.SelectedValue!);

            if (result.Success)
            {
                MessageBox.Show(result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DefaultView(true);
            }
            else
            {
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_Add_Click(object sender, EventArgs e)
        {
            var result = productServices.Add(txt_Productname.Text, (decimal)n_Price.Value, (int)CB_Categories.SelectedValue);
            MessageBox.Show(result.Message);
            if (result.Success)
            {
                LoadProductsData();
                ClearFields();
            }
        }

        public void ClearFields()
        {
            txt_Productname.Text = string.Empty;
            n_Price.Value = 0;
            CB_Categories.SelectedValue = 0;
        }

        private void UserControlProducts_Load(object sender, EventArgs e)
        {

        }
    }
}
