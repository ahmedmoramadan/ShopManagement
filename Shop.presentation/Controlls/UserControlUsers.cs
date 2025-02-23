using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop.BusinessLogic;
using Shop.DataAccess;
using Shop.presentation.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Shop.presentation.Controlls
{
    public partial class UserControlUsers : UserControl
    {
        private UserServices _userServices;
        private Panel _panel;

       
        public UserControlUsers(Panel panel)
        {
            InitializeComponent();
            _userServices = new UserServices(ConfigurationManager.ConnectionStrings["ShowDB"].ConnectionString);
            _panel = panel;
        }

        private void dgv_users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadUsersData();
        }
        public void LoadUsersData()
        {
            try
            {
                DataTable dt = _userServices.GetAllUsers();
                dgv_users.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading users: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addUser();
        }

        private void addUser()
        {

            if (text_pass.Text != text_confirm.Text)
            {
                MessageBox.Show("❌ Password and confirmation do not match.");
                return;
            }
            var result = _userServices.AddUser(txt_Username.Text, text_pass.Text, txt_Email.Text, (int)n_Age.Value, txt_Address.Text, ISAdmian.Checked);

            MessageBox.Show(result.message);

            if (result.isSuccess)
            {
                LoadUsersData();
                ClearFeilds();
            }
        }
        public void ClearFeilds()
        {
            var defaultValues = _userServices.GetDefaultUserValues();
            txt_Address.Text = string.Empty;
            txt_Email.Text = string.Empty;
            txt_Username.Text = string.Empty;
            text_confirm.Text = string.Empty;
            text_pass.Text = string.Empty;
            ISAdmian.Checked = false;
            n_Age.Value = 0;
        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (box_ShowPass.Checked)
            {
                text_confirm.UseSystemPasswordChar = false;
                text_pass.UseSystemPasswordChar = false;
            }
            else
            {
                text_confirm.UseSystemPasswordChar = true;
                text_pass.UseSystemPasswordChar = true;
            }
        }

        int U_id;
        DataTable user;
        private void dgv_users_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0)
                U_id = (int)(dgv_users.SelectedRows[0].Cells[0].Value)!;
            else
                return;
            if (U_id == 0)
                return;

            user = _userServices.GetUserById(U_id);
            if (user == null) return;

            txt_Address.Text = user.Rows[0]["Address"].ToString();
            txt_Email.Text = user.Rows[0]["Email"].ToString();
            txt_Username.Text = user.Rows[0]["Username"].ToString();
            n_Age.Value = (int)user.Rows[0]["Age"];
            ISAdmian.Checked = user.Rows[0]["Role"].ToString() == "User" ? false : true;
            ShowDefault(false);
        }

        private void ShowDefault(bool isadd)
        {
            if (!isadd)
            {
                text_confirm.Visible = false;
                text_pass.Visible = false;
                lbl_confirm.Visible = false;
                lbl_pass.Visible = false;
                box_ShowPass.Visible = false;

                btn_Delete.Visible = true;
                btn_update.Visible = true;
                btn_Add.Hide();
            }
            else
            {
                text_confirm.Visible = true;
                text_pass.Visible = true;
                lbl_confirm.Visible = true;
                lbl_pass.Visible = true;
                box_ShowPass.Visible = true;

                btn_Delete.Visible = false;
                btn_update.Visible = false;
                btn_Add.Show();
            }

        }

        private void ISAdmian_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text;
            string email = txt_Email.Text;
            int age = (int)n_Age.Value;
            string address = txt_Address.Text;
            bool isAdmin = ISAdmian.Checked;
            // تحديث المستخدم
            bool RowAffected = _userServices.UpdateUser(U_id, username, email, age, address, isAdmin);

            // التحقق من نجاح التحديث
            if (RowAffected)
            {
                ClearFeilds();
                LoadUsersData();
                ShowDefault(true);

                MessageBox.Show("Update Success!");
            }
            else
            {
                MessageBox.Show("Update Failed!");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            bool RowAffected = _userServices.DeleteUser(U_id);


            if (RowAffected)
            {
                ClearFeilds();
                LoadUsersData();
                ShowDefault(true);
                MessageBox.Show("Deleted Success!");
            }
            else
            {
                MessageBox.Show("Deleted Failed!");
            }
        }
        // back to main panal
        private void Back_Click(object sender, EventArgs e)
        {
            _panel.Controls.Remove(this);
        }
    }
}
