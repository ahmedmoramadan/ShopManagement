namespace Shop.presentation
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            textBox1 = new TextBox();
            text_password = new TextBox();
            button2 = new Button();
            Login = new Button();
            ShowPassword = new CheckBox();
            Back = new Button();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(text_password);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(Login);
            panel1.Controls.Add(ShowPassword);
            panel1.Controls.Add(Back);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(257, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 417);
            panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gainsboro;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(147, 122);
            textBox1.MinimumSize = new Size(0, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(251, 27);
            textBox1.TabIndex = 29;
            // 
            // text_password
            // 
            text_password.BackColor = Color.Gainsboro;
            text_password.BorderStyle = BorderStyle.None;
            text_password.Location = new Point(147, 177);
            text_password.MinimumSize = new Size(0, 27);
            text_password.Name = "text_password";
            text_password.Size = new Size(251, 27);
            text_password.TabIndex = 28;
            text_password.UseSystemPasswordChar = true;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.DarkGray;
            button2.Location = new Point(230, 372);
            button2.Name = "button2";
            button2.Size = new Size(99, 42);
            button2.TabIndex = 27;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Login
            // 
            Login.BackColor = Color.Navy;
            Login.Cursor = Cursors.Hand;
            Login.FlatStyle = FlatStyle.Flat;
            Login.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.ForeColor = Color.White;
            Login.Location = new Point(147, 284);
            Login.Name = "Login";
            Login.Size = new Size(182, 49);
            Login.TabIndex = 26;
            Login.Text = "Log in";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // ShowPassword
            // 
            ShowPassword.AutoSize = true;
            ShowPassword.Cursor = Cursors.Hand;
            ShowPassword.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowPassword.Location = new Point(243, 210);
            ShowPassword.Name = "ShowPassword";
            ShowPassword.Size = new Size(155, 27);
            ShowPassword.TabIndex = 25;
            ShowPassword.Text = "Show Password";
            ShowPassword.UseVisualStyleBackColor = true;
            ShowPassword.CheckedChanged += ShowPass_CheckedChanged;
            // 
            // Back
            // 
            Back.BackColor = Color.RoyalBlue;
            Back.Cursor = Cursors.Hand;
            Back.FlatStyle = FlatStyle.Flat;
            Back.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.White;
            Back.Location = new Point(335, 371);
            Back.Name = "Back";
            Back.Size = new Size(106, 43);
            Back.TabIndex = 24;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS UI Gothic", 19.8000011F, FontStyle.Bold);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(160, 18);
            label6.Name = "label6";
            label6.Size = new Size(126, 34);
            label6.TabIndex = 5;
            label6.Text = "LOG IN";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += label6_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 177);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 122);
            label1.Name = "label1";
            label1.Size = new Size(92, 23);
            label1.TabIndex = 0;
            label1.Text = "UserName";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(116, 86, 174);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(890, 525);
            Controls.Add(panel1);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label2;
        private Label label1;
        private Button Back;
        private Button button2;
        private Button Login;
        private CheckBox ShowPassword;
        private TextBox text_password;
        private TextBox textBox1;
    }
}