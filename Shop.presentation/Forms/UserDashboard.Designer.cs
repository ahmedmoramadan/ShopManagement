namespace Shop.presentation.Forms
{
    partial class UserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            Btn_Close = new PictureBox();
            label1 = new Label();
            Btn_ShowProducts = new Button();
            btn_manageCategories = new Button();
            btn_manageProducts = new Button();
            Mainpanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)Btn_Close).BeginInit();
            SuspendLayout();
            // 
            // Btn_Close
            // 
            Btn_Close.Image = (Image)resources.GetObject("Btn_Close.Image");
            Btn_Close.Location = new Point(845, 1);
            Btn_Close.Name = "Btn_Close";
            Btn_Close.Size = new Size(43, 50);
            Btn_Close.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Close.TabIndex = 1;
            Btn_Close.TabStop = false;
            Btn_Close.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(226, 4);
            label1.Name = "label1";
            label1.Size = new Size(407, 47);
            label1.TabIndex = 32;
            label1.Text = "User Dashboard";
            // 
            // Btn_ShowProducts
            // 
            Btn_ShowProducts.BackColor = Color.Navy;
            Btn_ShowProducts.Cursor = Cursors.Hand;
            Btn_ShowProducts.FlatStyle = FlatStyle.Flat;
            Btn_ShowProducts.ForeColor = Color.White;
            Btn_ShowProducts.Location = new Point(3, 87);
            Btn_ShowProducts.Name = "Btn_ShowProducts";
            Btn_ShowProducts.Size = new Size(142, 50);
            Btn_ShowProducts.TabIndex = 26;
            Btn_ShowProducts.Text = "ShowProducts";
            Btn_ShowProducts.UseVisualStyleBackColor = false;
            Btn_ShowProducts.Click += Btn_ShowProducts_Click;
            // 
            // btn_manageCategories
            // 
            btn_manageCategories.BackColor = Color.Navy;
            btn_manageCategories.Cursor = Cursors.Hand;
            btn_manageCategories.FlatStyle = FlatStyle.Flat;
            btn_manageCategories.ForeColor = Color.White;
            btn_manageCategories.Location = new Point(3, 185);
            btn_manageCategories.Name = "btn_manageCategories";
            btn_manageCategories.Size = new Size(142, 50);
            btn_manageCategories.TabIndex = 30;
            btn_manageCategories.Text = "Change Password";
            btn_manageCategories.UseVisualStyleBackColor = false;
            btn_manageCategories.Click += btn_manageCategories_Click;
            // 
            // btn_manageProducts
            // 
            btn_manageProducts.BackColor = Color.Navy;
            btn_manageProducts.Cursor = Cursors.Hand;
            btn_manageProducts.FlatStyle = FlatStyle.Flat;
            btn_manageProducts.ForeColor = Color.White;
            btn_manageProducts.Location = new Point(3, 281);
            btn_manageProducts.Name = "btn_manageProducts";
            btn_manageProducts.Size = new Size(142, 50);
            btn_manageProducts.TabIndex = 29;
            btn_manageProducts.Text = "FavoriteProduct";
            btn_manageProducts.UseVisualStyleBackColor = false;
            btn_manageProducts.Click += btn_manageProducts_Click;
            // 
            // Mainpanel
            // 
            Mainpanel.BackgroundImage = (Image)resources.GetObject("Mainpanel.BackgroundImage");
            Mainpanel.Location = new Point(177, 60);
            Mainpanel.Margin = new Padding(0, 1, 1, 1);
            Mainpanel.Name = "Mainpanel";
            Mainpanel.Size = new Size(711, 466);
            Mainpanel.TabIndex = 27;
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(890, 525);
            Controls.Add(label1);
            Controls.Add(Btn_ShowProducts);
            Controls.Add(btn_manageCategories);
            Controls.Add(btn_manageProducts);
            Controls.Add(Mainpanel);
            Controls.Add(Btn_Close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserDashboard";
            Load += UserDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)Btn_Close).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Btn_Close;
        private Label label1;
        private Button Btn_ShowProducts;
        private Button btn_manageCategories;
        private Button btn_manageProducts;
        private Panel Mainpanel;
    }
}