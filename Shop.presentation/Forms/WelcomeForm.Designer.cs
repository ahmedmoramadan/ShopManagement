namespace Shop.presentation
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            lbl_Welcome = new Label();
            label3 = new Label();
            lbl_login = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_Welcome
            // 
            lbl_Welcome.Font = new Font("MS UI Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Welcome.ForeColor = Color.Navy;
            lbl_Welcome.Location = new Point(527, 63);
            lbl_Welcome.Name = "lbl_Welcome";
            lbl_Welcome.RightToLeft = RightToLeft.No;
            lbl_Welcome.Size = new Size(311, 121);
            lbl_Welcome.TabIndex = 0;
            lbl_Welcome.Text = "Welcome To Our Application";
            lbl_Welcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Navy;
            label3.FlatStyle = FlatStyle.Flat;
            label3.ForeColor = Color.White;
            label3.Location = new Point(687, 339);
            label3.Name = "label3";
            label3.Size = new Size(151, 46);
            label3.TabIndex = 2;
            label3.Text = "REGISTER";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // lbl_login
            // 
            lbl_login.BackColor = Color.Navy;
            lbl_login.FlatStyle = FlatStyle.Flat;
            lbl_login.ForeColor = Color.White;
            lbl_login.Location = new Point(516, 339);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(151, 46);
            lbl_login.TabIndex = 3;
            lbl_login.Text = "LOG IN";
            lbl_login.TextAlign = ContentAlignment.MiddleCenter;
            lbl_login.Click += lbl_login_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(469, 525);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(890, 525);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_login);
            Controls.Add(label3);
            Controls.Add(lbl_Welcome);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WelcomeForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_Welcome;
        private Label label3;
        private Label lbl_login;
        private PictureBox pictureBox1;
    }
}