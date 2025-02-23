namespace Shop.presentation.Forms
{
    partial class AdminDashboad
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboad));
            Btn_ManageUsers = new Button();
            Mainpanel = new Panel();
            Btn_Close = new PictureBox();
            btn_manageProducts = new Button();
            btn_manageCategories = new Button();
            Back = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Btn_Close).BeginInit();
            SuspendLayout();
            // 
            // Btn_ManageUsers
            // 
            Btn_ManageUsers.BackColor = Color.Navy;
            Btn_ManageUsers.Cursor = Cursors.Hand;
            Btn_ManageUsers.FlatStyle = FlatStyle.Flat;
            Btn_ManageUsers.ForeColor = Color.White;
            Btn_ManageUsers.Location = new Point(12, 57);
            Btn_ManageUsers.Name = "Btn_ManageUsers";
            Btn_ManageUsers.Size = new Size(142, 50);
            Btn_ManageUsers.TabIndex = 0;
            Btn_ManageUsers.Text = "ManageUsers";
            Btn_ManageUsers.UseVisualStyleBackColor = false;
            Btn_ManageUsers.Click += Btn_ManageUsers_Click;
            // 
            // Mainpanel
            // 
            Mainpanel.BackgroundImage = (Image)resources.GetObject("Mainpanel.BackgroundImage");
            Mainpanel.Location = new Point(176, 57);
            Mainpanel.Margin = new Padding(0, 1, 1, 1);
            Mainpanel.Name = "Mainpanel";
            Mainpanel.Size = new Size(711, 466);
            Mainpanel.TabIndex = 1;
            // 
            // Btn_Close
            // 
            Btn_Close.Cursor = Cursors.Hand;
            Btn_Close.Image = (Image)resources.GetObject("Btn_Close.Image");
            Btn_Close.Location = new Point(825, 1);
            Btn_Close.Name = "Btn_Close";
            Btn_Close.Size = new Size(62, 59);
            Btn_Close.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Close.TabIndex = 2;
            Btn_Close.TabStop = false;
            Btn_Close.Click += Btn_Close_Click;
            // 
            // btn_manageProducts
            // 
            btn_manageProducts.BackColor = Color.Navy;
            btn_manageProducts.Cursor = Cursors.Hand;
            btn_manageProducts.FlatStyle = FlatStyle.Flat;
            btn_manageProducts.ForeColor = Color.White;
            btn_manageProducts.Location = new Point(12, 219);
            btn_manageProducts.Name = "btn_manageProducts";
            btn_manageProducts.Size = new Size(142, 50);
            btn_manageProducts.TabIndex = 3;
            btn_manageProducts.Text = "ManageProducts";
            btn_manageProducts.UseVisualStyleBackColor = false;
            btn_manageProducts.Click += btn_manageProducts_Click;
            // 
            // btn_manageCategories
            // 
            btn_manageCategories.BackColor = Color.Navy;
            btn_manageCategories.Cursor = Cursors.Hand;
            btn_manageCategories.FlatStyle = FlatStyle.Flat;
            btn_manageCategories.ForeColor = Color.White;
            btn_manageCategories.Location = new Point(12, 137);
            btn_manageCategories.Name = "btn_manageCategories";
            btn_manageCategories.Size = new Size(142, 50);
            btn_manageCategories.TabIndex = 4;
            btn_manageCategories.Text = "MangeCategories";
            btn_manageCategories.UseVisualStyleBackColor = false;
            btn_manageCategories.Click += button2_Click;
            // 
            // Back
            // 
            Back.BackColor = Color.RoyalBlue;
            Back.Cursor = Cursors.Hand;
            Back.FlatStyle = FlatStyle.Flat;
            Back.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.White;
            Back.Location = new Point(39, 470);
            Back.Name = "Back";
            Back.Size = new Size(106, 43);
            Back.TabIndex = 24;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(235, 1);
            label1.Name = "label1";
            label1.Size = new Size(407, 47);
            label1.TabIndex = 25;
            label1.Text = "Admin Dashboard";
            // 
            // AdminDashboad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(890, 525);
            Controls.Add(label1);
            Controls.Add(Btn_ManageUsers);
            Controls.Add(Back);
            Controls.Add(btn_manageCategories);
            Controls.Add(btn_manageProducts);
            Controls.Add(Btn_Close);
            Controls.Add(Mainpanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashboad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboad";
            Load += AdminDashboad_Load;
            ((System.ComponentModel.ISupportInitialize)Btn_Close).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Btn_ManageUsers;
        private Panel Mainpanel;
        private PictureBox Btn_Close;
        private Button btn_manageProducts;
        private Button btn_manageCategories;
        private Button Back;
        private Label label1;
    }
}