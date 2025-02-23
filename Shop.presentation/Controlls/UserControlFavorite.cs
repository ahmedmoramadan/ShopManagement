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
    public partial class UserControlFavorite : UserControl
    {
        private UserServices userServices;
        private FevProdServices fevProdServices;

        public UserControlFavorite()
        {
            InitializeComponent();
            userServices = new UserServices(ConfigurationManager.ConnectionStrings["ShowDB"].ConnectionString);
            fevProdServices = new FevProdServices(ConfigurationManager.ConnectionStrings["ShowDB"].ConnectionString);

        }
        int P_id;
        private void dgv_ShowFevProducts_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            P_id = (int)(dgv_ShowFevProducts.SelectedRows[0].Cells[1].Value)!;
            int UID = userServices.GetUser();
            if (UID == 0)
                return;

            var isDeleted = fevProdServices.Delete(P_id, UID);

            if (isDeleted)
            {
                MessageBox.Show("Product removed from favorites successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // يمكنك إعادة تحميل البيانات لتحديث الجدول
                dgv_ShowFevProducts.DataSource = fevProdServices.GetAll(UID);
            }
            else
            {
                MessageBox.Show("Failed to remove product from favorites.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserControlFavorite_Load(object sender, EventArgs e)
        {
                DataTable dt = fevProdServices.GetAll(userServices.GetUser());
            dgv_ShowFevProducts.DataSource = dt;
        }
    }
}
