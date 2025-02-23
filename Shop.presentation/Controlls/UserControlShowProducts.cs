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
using Microsoft.VisualBasic.ApplicationServices;
using Shop.BusinessLogic;

namespace Shop.presentation.Controlls
{
    public partial class UserControlShowProducts : UserControl
    {
        private  FevProdServices fevProdServices;
        private UserServices userServices;
        private ProductServices productServices;
        private Panel _panel;
        int P_id;
        public UserControlShowProducts(Panel panel)
        {
            InitializeComponent();
            _panel = panel;
            //  categoryServices = new CategoryServices(ConfigurationManager.ConnectionStrings["ShowDB"].ConnectionString);
            productServices = new ProductServices(ConfigurationManager.ConnectionStrings["ShowDB"].ConnectionString);
            userServices = new UserServices(ConfigurationManager.ConnectionStrings["ShowDB"].ConnectionString);
            fevProdServices = new FevProdServices(ConfigurationManager.ConnectionStrings["ShowDB"].ConnectionString);

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            P_id = (int)(dgv_ShowProducts.SelectedRows[0].Cells[0].Value)!;

            DataTable dt = productServices.GetById(P_id);

            // Check if data is returned
            if (dt.Rows.Count > 0)
            {
                int UID = userServices.GetUser();
                if (UID == 0)
                    return;
                var result = fevProdServices.Add(UID , P_id);
                MessageBox.Show(result.Message);

                if(result.Success)
                {

                }

            }
            else
            {
                MessageBox.Show("product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void UserControlShowProducts_Load(object sender, EventArgs e)
        {
            LoadProductsData();
        }

        public void LoadProductsData()
        {
            try
            {
                DataTable dt = productServices.GetAllProducts();
                dgv_ShowProducts.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading Products: " + ex.Message);
            }
        }
    }
}
