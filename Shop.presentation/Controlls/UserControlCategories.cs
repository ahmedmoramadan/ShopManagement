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
    public partial class UserControlCategories : UserControl
    {
        private Panel _panel;

        private CategoryServices categoryServices;
        public UserControlCategories(Panel panel)
        {
            InitializeComponent();
            _panel = panel;
            categoryServices = new CategoryServices(ConfigurationManager.ConnectionStrings["ShowDB"].ConnectionString);

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var result = categoryServices.Add(txt_Catename.Text);
            MessageBox.Show(result.Message);

            if (result.Success)
            {
                LoadCategoriesData();
                ClearFeilds();
            }
        }

        public void ClearFeilds()
        {
            txt_Catename.Text = string.Empty;
        }
        public void LoadCategoriesData()
        {
            try
            {
                DataTable dt = categoryServices.GetAllCategories();
                dgv_categ.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading users: " + ex.Message);
            }
        }
       

        private void Back_Click(object sender, EventArgs e)
        {
            _panel.Controls.Remove(this);
        }

        int C_id;
        private void dgv_categ_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            C_id = (int)(dgv_categ.SelectedRows[0].Cells[0].Value)!;

            DataTable dt = categoryServices.GetById(C_id);

            // Check if data is returned
            if (dt.Rows.Count > 0)
            {
                // Populate the txt_Catename control with the CategoryName
                txt_Catename.Text = dt.Rows[0]["CategoryName"].ToString();
            }
            else
            {
                MessageBox.Show("Category not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            DefaultView(false);
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Catename.Text))
            {
                MessageBox.Show("Category name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var result = categoryServices.Update(txt_Catename.Text, C_id);
            MessageBox.Show(result.Message, result.Success ? "Success" : "Error", MessageBoxButtons.OK, result.Success ? MessageBoxIcon.Information : MessageBoxIcon.Error);


            if (result.Success)
            {
                LoadCategoriesData();
                txt_Catename.Text = string.Empty;
                DefaultView(true);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            bool isDeleted = categoryServices.DeleteCategory(C_id);

            if (isDeleted)
            {
                MessageBox.Show("Category deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCategoriesData(); 
                ClearFeilds(); 
                DefaultView(true);
            }
            else
            {
                MessageBox.Show("Failed to delete the category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
