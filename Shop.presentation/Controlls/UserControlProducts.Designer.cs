namespace Shop.presentation.Controlls
{
    partial class UserControlProducts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlProducts));
            Back = new Button();
            n_Price = new NumericUpDown();
            txt_Productname = new TextBox();
            lbl_Price = new Label();
            lbl_name = new Label();
            btn_Add = new Button();
            btn_update = new Button();
            btn_Delete = new Button();
            dgv_Products = new DataGridView();
            CB_Categories = new ComboBox();
            lbl_Category = new Label();
            ((System.ComponentModel.ISupportInitialize)n_Price).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Products).BeginInit();
            SuspendLayout();
            // 
            // Back
            // 
            Back.BackColor = Color.RoyalBlue;
            Back.Cursor = Cursors.Hand;
            Back.FlatStyle = FlatStyle.Flat;
            Back.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.White;
            Back.Location = new Point(626, 3);
            Back.Name = "Back";
            Back.Size = new Size(78, 43);
            Back.TabIndex = 43;
            Back.Text = "Close";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // n_Price
            // 
            n_Price.BorderStyle = BorderStyle.None;
            n_Price.Location = new Point(292, 67);
            n_Price.Name = "n_Price";
            n_Price.Size = new Size(150, 23);
            n_Price.TabIndex = 41;
            // 
            // txt_Productname
            // 
            txt_Productname.BorderStyle = BorderStyle.None;
            txt_Productname.Location = new Point(77, 70);
            txt_Productname.Name = "txt_Productname";
            txt_Productname.Size = new Size(148, 20);
            txt_Productname.TabIndex = 36;
            // 
            // lbl_Price
            // 
            lbl_Price.AutoSize = true;
            lbl_Price.BackColor = Color.Transparent;
            lbl_Price.ForeColor = Color.White;
            lbl_Price.Location = new Point(292, 44);
            lbl_Price.Name = "lbl_Price";
            lbl_Price.Size = new Size(41, 20);
            lbl_Price.TabIndex = 31;
            lbl_Price.Text = "Price";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.BackColor = Color.Transparent;
            lbl_name.ForeColor = Color.White;
            lbl_name.Location = new Point(77, 44);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(97, 20);
            lbl_name.TabIndex = 30;
            lbl_name.Text = "Productname";
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.FromArgb(116, 86, 174);
            btn_Add.Cursor = Cursors.Hand;
            btn_Add.FlatStyle = FlatStyle.Flat;
            btn_Add.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            btn_Add.ForeColor = Color.White;
            btn_Add.Location = new Point(6, 120);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(106, 46);
            btn_Add.TabIndex = 29;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(116, 86, 174);
            btn_update.Cursor = Cursors.Hand;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(6, 151);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(106, 46);
            btn_update.TabIndex = 28;
            btn_update.Text = "Edit";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Visible = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.FromArgb(116, 86, 174);
            btn_Delete.Cursor = Cursors.Hand;
            btn_Delete.FlatStyle = FlatStyle.Flat;
            btn_Delete.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            btn_Delete.ForeColor = Color.White;
            btn_Delete.Location = new Point(6, 247);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(106, 46);
            btn_Delete.TabIndex = 27;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Visible = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // dgv_Products
            // 
            dgv_Products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Products.Location = new Point(130, 120);
            dgv_Products.Name = "dgv_Products";
            dgv_Products.RowHeadersWidth = 51;
            dgv_Products.Size = new Size(574, 346);
            dgv_Products.TabIndex = 26;
            dgv_Products.RowHeaderMouseDoubleClick += dgv_users_RowHeaderMouseDoubleClick;
            // 
            // CB_Categories
            // 
            CB_Categories.FormattingEnabled = true;
            CB_Categories.Location = new Point(483, 62);
            CB_Categories.Name = "CB_Categories";
            CB_Categories.Size = new Size(151, 28);
            CB_Categories.TabIndex = 44;
            // 
            // lbl_Category
            // 
            lbl_Category.AutoSize = true;
            lbl_Category.BackColor = Color.Transparent;
            lbl_Category.ForeColor = Color.White;
            lbl_Category.Location = new Point(483, 39);
            lbl_Category.Name = "lbl_Category";
            lbl_Category.Size = new Size(69, 20);
            lbl_Category.TabIndex = 45;
            lbl_Category.Text = "Category";
            // 
            // UserControlProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(lbl_Category);
            Controls.Add(CB_Categories);
            Controls.Add(Back);
            Controls.Add(n_Price);
            Controls.Add(txt_Productname);
            Controls.Add(lbl_Price);
            Controls.Add(lbl_name);
            Controls.Add(btn_Add);
            Controls.Add(btn_update);
            Controls.Add(btn_Delete);
            Controls.Add(dgv_Products);
            Name = "UserControlProducts";
            Size = new Size(707, 466);
            Load += UserControlProducts_Load;
            ((System.ComponentModel.ISupportInitialize)n_Price).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Products).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Back;
        private NumericUpDown n_Price;
        private TextBox txt_Productname;
        private Label lbl_Price;
        private Label lbl_name;
        private Button btn_Add;
        private Button btn_update;
        private Button btn_Delete;
        private DataGridView dgv_Products;
        private ComboBox CB_Categories;
        private Label lbl_Category;
    }
}
