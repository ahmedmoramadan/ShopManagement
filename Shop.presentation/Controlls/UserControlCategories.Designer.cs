namespace Shop.presentation.Controlls
{
    partial class UserControlCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlCategories));
            Back = new Button();
            txt_Catename = new TextBox();
            lbl_name = new Label();
            btn_Add = new Button();
            btn_update = new Button();
            btn_Delete = new Button();
            dgv_categ = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_categ).BeginInit();
            SuspendLayout();
            // 
            // Back
            // 
            Back.BackColor = Color.RoyalBlue;
            Back.Cursor = Cursors.Hand;
            Back.FlatStyle = FlatStyle.Flat;
            Back.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.White;
            Back.Location = new Point(621, 14);
            Back.Name = "Back";
            Back.Size = new Size(78, 43);
            Back.TabIndex = 43;
            Back.Text = "Close";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // txt_Catename
            // 
            txt_Catename.BorderStyle = BorderStyle.None;
            txt_Catename.Location = new Point(478, 132);
            txt_Catename.Name = "txt_Catename";
            txt_Catename.Size = new Size(148, 20);
            txt_Catename.TabIndex = 36;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.BackColor = Color.Transparent;
            lbl_name.ForeColor = Color.White;
            lbl_name.Location = new Point(478, 109);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(109, 20);
            lbl_name.TabIndex = 30;
            lbl_name.Text = "CategoryName";
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.FromArgb(116, 86, 174);
            btn_Add.Cursor = Cursors.Hand;
            btn_Add.FlatStyle = FlatStyle.Flat;
            btn_Add.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            btn_Add.ForeColor = Color.White;
            btn_Add.Location = new Point(275, 116);
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
            btn_update.Location = new Point(229, 132);
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
            btn_Delete.Location = new Point(229, 280);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(106, 46);
            btn_Delete.TabIndex = 27;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Visible = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // dgv_categ
            // 
            dgv_categ.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_categ.Location = new Point(391, 181);
            dgv_categ.Name = "dgv_categ";
            dgv_categ.RowHeadersWidth = 51;
            dgv_categ.Size = new Size(307, 304);
            dgv_categ.TabIndex = 26;
            dgv_categ.RowHeaderMouseDoubleClick += dgv_categ_RowHeaderMouseDoubleClick;
            // 
            // UserControlCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(Back);
            Controls.Add(txt_Catename);
            Controls.Add(lbl_name);
            Controls.Add(btn_Add);
            Controls.Add(btn_update);
            Controls.Add(btn_Delete);
            Controls.Add(dgv_categ);
            Name = "UserControlCategories";
            Size = new Size(701, 485);
            ((System.ComponentModel.ISupportInitialize)dgv_categ).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Back;
        private TextBox txt_Catename;
        private Label lbl_name;
        private Button btn_Add;
        private Button btn_update;
        private Button btn_Delete;
        private DataGridView dgv_categ;
    }
}
