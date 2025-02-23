namespace Shop.presentation.Controlls
{
    partial class UserControlFavorite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlFavorite));
            label2 = new Label();
            label1 = new Label();
            dgv_ShowFevProducts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_ShowFevProducts).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DodgerBlue;
            label2.Font = new Font("Imprint MT Shadow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(76, 104);
            label2.Name = "label2";
            label2.Padding = new Padding(15);
            label2.Size = new Size(559, 54);
            label2.TabIndex = 5;
            label2.Text = "Double Click on ProductTo Remove It From favorites ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(312, 31);
            label1.Name = "label1";
            label1.Size = new Size(0, 31);
            label1.TabIndex = 4;
            // 
            // dgv_ShowFevProducts
            // 
            dgv_ShowFevProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ShowFevProducts.Location = new Point(148, 192);
            dgv_ShowFevProducts.Name = "dgv_ShowFevProducts";
            dgv_ShowFevProducts.RowHeadersWidth = 51;
            dgv_ShowFevProducts.Size = new Size(427, 243);
            dgv_ShowFevProducts.TabIndex = 3;
            dgv_ShowFevProducts.RowHeaderMouseDoubleClick += dgv_ShowFevProducts_RowHeaderMouseDoubleClick;
            // 
            // UserControlFavorite
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_ShowFevProducts);
            Name = "UserControlFavorite";
            Size = new Size(711, 466);
            Load += UserControlFavorite_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_ShowFevProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private DataGridView dgv_ShowFevProducts;
    }
}
