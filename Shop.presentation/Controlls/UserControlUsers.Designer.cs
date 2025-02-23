namespace Shop.presentation.Controlls
{
    partial class UserControlUsers
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        public void HideButtons()
        {
            btn_update.Visible = false;
            btn_Delete.Visible = false;
        }

        public void ShowButtons()
        {
            btn_update.Visible = true;
            btn_Delete.Visible = true;
        }
        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlUsers));
            dgv_users = new DataGridView();
            btn_Delete = new Button();
            btn_update = new Button();
            btn_Add = new Button();
            lbl_name = new Label();
            lbl_Age = new Label();
            lbl_Address = new Label();
            lbl_Email = new Label();
            lbl_confirm = new Label();
            lbl_pass = new Label();
            txt_Username = new TextBox();
            txt_Address = new TextBox();
            txt_Email = new TextBox();
            text_confirm = new TextBox();
            text_pass = new TextBox();
            n_Age = new NumericUpDown();
            ISAdmian = new CheckBox();
            Back = new Button();
            box_ShowPass = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgv_users).BeginInit();
            ((System.ComponentModel.ISupportInitialize)n_Age).BeginInit();
            SuspendLayout();
            // 
            // dgv_users
            // 
            dgv_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_users.Location = new Point(137, 120);
            dgv_users.Name = "dgv_users";
            dgv_users.RowHeadersWidth = 51;
            dgv_users.Size = new Size(574, 346);
            dgv_users.TabIndex = 0;
            dgv_users.CellContentClick += dgv_users_CellContentClick;
            dgv_users.RowHeaderMouseDoubleClick += dgv_users_RowHeaderMouseDoubleClick;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.FromArgb(116, 86, 174);
            btn_Delete.Cursor = Cursors.Hand;
            btn_Delete.FlatStyle = FlatStyle.Flat;
            btn_Delete.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            btn_Delete.ForeColor = Color.White;
            btn_Delete.Location = new Point(13, 247);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(106, 46);
            btn_Delete.TabIndex = 1;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(116, 86, 174);
            btn_update.Cursor = Cursors.Hand;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(13, 151);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(106, 46);
            btn_update.TabIndex = 2;
            btn_update.Text = "Edit";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.FromArgb(116, 86, 174);
            btn_Add.Cursor = Cursors.Hand;
            btn_Add.FlatStyle = FlatStyle.Flat;
            btn_Add.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            btn_Add.ForeColor = Color.White;
            btn_Add.Location = new Point(13, 120);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(106, 46);
            btn_Add.TabIndex = 3;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += button2_Click;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.BackColor = Color.Transparent;
            lbl_name.ForeColor = Color.White;
            lbl_name.Location = new Point(51, 1);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(75, 20);
            lbl_name.TabIndex = 4;
            lbl_name.Text = "Username";
            // 
            // lbl_Age
            // 
            lbl_Age.AutoSize = true;
            lbl_Age.BackColor = Color.Transparent;
            lbl_Age.ForeColor = Color.White;
            lbl_Age.Location = new Point(236, 47);
            lbl_Age.Name = "lbl_Age";
            lbl_Age.Size = new Size(36, 20);
            lbl_Age.TabIndex = 5;
            lbl_Age.Text = "Age";
            // 
            // lbl_Address
            // 
            lbl_Address.AutoSize = true;
            lbl_Address.BackColor = Color.Transparent;
            lbl_Address.ForeColor = Color.White;
            lbl_Address.Location = new Point(234, 1);
            lbl_Address.Name = "lbl_Address";
            lbl_Address.Size = new Size(62, 20);
            lbl_Address.TabIndex = 6;
            lbl_Address.Text = "Address";
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.BackColor = Color.Transparent;
            lbl_Email.ForeColor = Color.White;
            lbl_Email.Location = new Point(53, 47);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(46, 20);
            lbl_Email.TabIndex = 7;
            lbl_Email.Text = "Email";
            // 
            // lbl_confirm
            // 
            lbl_confirm.AutoSize = true;
            lbl_confirm.BackColor = Color.Transparent;
            lbl_confirm.ForeColor = Color.White;
            lbl_confirm.Location = new Point(445, 47);
            lbl_confirm.Name = "lbl_confirm";
            lbl_confirm.Size = new Size(62, 20);
            lbl_confirm.TabIndex = 8;
            lbl_confirm.Text = "Confirm";
            // 
            // lbl_pass
            // 
            lbl_pass.AutoSize = true;
            lbl_pass.BackColor = Color.Transparent;
            lbl_pass.ForeColor = Color.White;
            lbl_pass.Location = new Point(443, 1);
            lbl_pass.Name = "lbl_pass";
            lbl_pass.Size = new Size(70, 20);
            lbl_pass.TabIndex = 9;
            lbl_pass.Text = "Password";
            // 
            // txt_Username
            // 
            txt_Username.BorderStyle = BorderStyle.None;
            txt_Username.Location = new Point(53, 24);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(148, 20);
            txt_Username.TabIndex = 10;
            txt_Username.TextChanged += txt_Username_TextChanged;
            // 
            // txt_Address
            // 
            txt_Address.BorderStyle = BorderStyle.None;
            txt_Address.Location = new Point(234, 24);
            txt_Address.Name = "txt_Address";
            txt_Address.Size = new Size(148, 20);
            txt_Address.TabIndex = 11;
            // 
            // txt_Email
            // 
            txt_Email.BorderStyle = BorderStyle.None;
            txt_Email.Location = new Point(53, 70);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(148, 20);
            txt_Email.TabIndex = 12;
            // 
            // text_confirm
            // 
            text_confirm.BorderStyle = BorderStyle.None;
            text_confirm.Location = new Point(445, 71);
            text_confirm.Margin = new Padding(0);
            text_confirm.Name = "text_confirm";
            text_confirm.Size = new Size(137, 20);
            text_confirm.TabIndex = 13;
            text_confirm.UseSystemPasswordChar = true;
            // 
            // text_pass
            // 
            text_pass.BorderStyle = BorderStyle.None;
            text_pass.Location = new Point(443, 24);
            text_pass.Name = "text_pass";
            text_pass.Size = new Size(139, 20);
            text_pass.TabIndex = 14;
            text_pass.UseSystemPasswordChar = true;
            // 
            // n_Age
            // 
            n_Age.BorderStyle = BorderStyle.None;
            n_Age.Location = new Point(234, 68);
            n_Age.Name = "n_Age";
            n_Age.Size = new Size(150, 23);
            n_Age.TabIndex = 15;
            // 
            // ISAdmian
            // 
            ISAdmian.AutoSize = true;
            ISAdmian.BackColor = Color.Transparent;
            ISAdmian.FlatStyle = FlatStyle.Flat;
            ISAdmian.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            ISAdmian.ForeColor = Color.FromArgb(116, 86, 174);
            ISAdmian.Location = new Point(614, 68);
            ISAdmian.Name = "ISAdmian";
            ISAdmian.Size = new Size(92, 32);
            ISAdmian.TabIndex = 16;
            ISAdmian.Text = "Admin";
            ISAdmian.UseVisualStyleBackColor = false;
            ISAdmian.CheckedChanged += ISAdmian_CheckedChanged;
            // 
            // Back
            // 
            Back.BackColor = Color.RoyalBlue;
            Back.Cursor = Cursors.Hand;
            Back.FlatStyle = FlatStyle.Flat;
            Back.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.White;
            Back.Location = new Point(628, 5);
            Back.Name = "Back";
            Back.Size = new Size(78, 43);
            Back.TabIndex = 24;
            Back.Text = "Close";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // box_ShowPass
            // 
            box_ShowPass.AutoSize = true;
            box_ShowPass.BackColor = Color.Transparent;
            box_ShowPass.FlatStyle = FlatStyle.Flat;
            box_ShowPass.ForeColor = Color.FromArgb(116, 86, 174);
            box_ShowPass.Location = new Point(485, 91);
            box_ShowPass.Margin = new Padding(0);
            box_ShowPass.Name = "box_ShowPass";
            box_ShowPass.Size = new Size(97, 24);
            box_ShowPass.TabIndex = 25;
            box_ShowPass.Text = "checkBox1";
            box_ShowPass.UseVisualStyleBackColor = false;
            box_ShowPass.CheckedChanged += box_ShowPass_CheckedChanged;
            // 
            // UserControlUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(box_ShowPass);
            Controls.Add(Back);
            Controls.Add(ISAdmian);
            Controls.Add(n_Age);
            Controls.Add(text_pass);
            Controls.Add(text_confirm);
            Controls.Add(txt_Email);
            Controls.Add(txt_Address);
            Controls.Add(txt_Username);
            Controls.Add(lbl_pass);
            Controls.Add(lbl_confirm);
            Controls.Add(lbl_Email);
            Controls.Add(lbl_Address);
            Controls.Add(lbl_Age);
            Controls.Add(lbl_name);
            Controls.Add(btn_Add);
            Controls.Add(btn_update);
            Controls.Add(btn_Delete);
            Controls.Add(dgv_users);
            Name = "UserControlUsers";
            Padding = new Padding(2);
            Size = new Size(711, 466);
            ((System.ComponentModel.ISupportInitialize)dgv_users).EndInit();
            ((System.ComponentModel.ISupportInitialize)n_Age).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_users;
        private Button btn_Delete;
        private Button btn_update;
        private Button btn_Add;
        private Label lbl_name;
        private Label lbl_Age;
        private Label lbl_Address;
        private Label lbl_Email;
        private Label lbl_confirm;
        private Label lbl_pass;
        private TextBox txt_Username;
        private TextBox txt_Address;
        private TextBox txt_Email;
        private TextBox text_confirm;
        private TextBox text_pass;
        private NumericUpDown n_Age;
        private CheckBox ISAdmian;
        private Button Back;
        private CheckBox box_ShowPass;
    }
}
