namespace Shop.presentation.Controlls
{
    partial class UserControlShowProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlShowProducts));
            dgv_ShowProducts = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_ShowProducts).BeginInit();
            SuspendLayout();
            // 
            // dgv_ShowProducts
            // 
            dgv_ShowProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ShowProducts.Location = new Point(73, 180);
            dgv_ShowProducts.Name = "dgv_ShowProducts";
            dgv_ShowProducts.RowHeadersWidth = 51;
            dgv_ShowProducts.Size = new Size(568, 243);
            dgv_ShowProducts.TabIndex = 0;
            dgv_ShowProducts.RowHeaderMouseDoubleClick += dataGridView1_RowHeaderMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(314, 18);
            label1.Name = "label1";
            label1.Size = new Size(0, 31);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DodgerBlue;
            label2.Font = new Font("Imprint MT Shadow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(108, 89);
            label2.Name = "label2";
            label2.Padding = new Padding(15);
            label2.Size = new Size(497, 54);
            label2.TabIndex = 2;
            label2.Text = "Double Click on ProductTo add It For favorites ";
            // 
            // UserControlShowProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_ShowProducts);
            Name = "UserControlShowProducts";
            Size = new Size(711, 466);
            Load += UserControlShowProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_ShowProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_ShowProducts;
        private Label label1;
        private Label label2;
    }
}
