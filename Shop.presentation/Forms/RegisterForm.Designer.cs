namespace Shop.presentation
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            panel1 = new Panel();
            txt_address = new TextBox();
            address = new Label();
            txt_confirm = new TextBox();
            text_password = new TextBox();
            Back = new Button();
            label8 = new Label();
            label7 = new Label();
            button2 = new Button();
            Register = new Button();
            txt_email = new TextBox();
            label6 = new Label();
            checkBox1 = new CheckBox();
            N_age = new NumericUpDown();
            txt_Username = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)N_age).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txt_address);
            panel1.Controls.Add(address);
            panel1.Controls.Add(txt_confirm);
            panel1.Controls.Add(text_password);
            panel1.Controls.Add(Back);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(Register);
            panel1.Controls.Add(txt_email);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(N_age);
            panel1.Controls.Add(txt_Username);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(153, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(604, 504);
            panel1.TabIndex = 1;
            // 
            // txt_address
            // 
            txt_address.BackColor = Color.Gainsboro;
            txt_address.BorderStyle = BorderStyle.None;
            txt_address.Location = new Point(237, 138);
            txt_address.Multiline = true;
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(322, 30);
            txt_address.TabIndex = 28;
            // 
            // address
            // 
            address.AutoSize = true;
            address.Location = new Point(66, 138);
            address.Name = "address";
            address.Size = new Size(74, 23);
            address.TabIndex = 27;
            address.Text = "Address";
            // 
            // txt_confirm
            // 
            txt_confirm.BackColor = Color.Gainsboro;
            txt_confirm.BorderStyle = BorderStyle.None;
            txt_confirm.Location = new Point(237, 243);
            txt_confirm.MinimumSize = new Size(0, 27);
            txt_confirm.Name = "txt_confirm";
            txt_confirm.Size = new Size(322, 27);
            txt_confirm.TabIndex = 26;
            txt_confirm.UseSystemPasswordChar = true;
            // 
            // text_password
            // 
            text_password.BackColor = Color.Gainsboro;
            text_password.BorderStyle = BorderStyle.None;
            text_password.Location = new Point(237, 210);
            text_password.MinimumSize = new Size(0, 27);
            text_password.Name = "text_password";
            text_password.Size = new Size(322, 27);
            text_password.TabIndex = 24;
            text_password.UseSystemPasswordChar = true;
            // 
            // Back
            // 
            Back.BackColor = Color.RoyalBlue;
            Back.Cursor = Cursors.Hand;
            Back.FlatStyle = FlatStyle.Flat;
            Back.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.White;
            Back.Location = new Point(495, 458);
            Back.Name = "Back";
            Back.Size = new Size(106, 43);
            Back.TabIndex = 23;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(414, 425);
            label8.Name = "label8";
            label8.Size = new Size(55, 23);
            label8.TabIndex = 22;
            label8.Text = "Login";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonShadow;
            label7.Location = new Point(185, 425);
            label7.Name = "label7";
            label7.Size = new Size(223, 23);
            label7.TabIndex = 21;
            label7.Text = "Already Have an Account ?";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.DarkGray;
            button2.Location = new Point(185, 366);
            button2.Name = "button2";
            button2.Size = new Size(269, 44);
            button2.TabIndex = 20;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Register
            // 
            Register.BackColor = Color.Navy;
            Register.Cursor = Cursors.Hand;
            Register.FlatStyle = FlatStyle.Flat;
            Register.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Register.ForeColor = Color.White;
            Register.Location = new Point(185, 311);
            Register.Name = "Register";
            Register.Size = new Size(269, 49);
            Register.TabIndex = 18;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = false;
            Register.Click += Register_Click;
            // 
            // txt_email
            // 
            txt_email.BackColor = Color.Gainsboro;
            txt_email.BorderStyle = BorderStyle.None;
            txt_email.Location = new Point(237, 102);
            txt_email.Multiline = true;
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(322, 30);
            txt_email.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS UI Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(145, 11);
            label6.Name = "label6";
            label6.Size = new Size(300, 40);
            label6.TabIndex = 5;
            label6.Text = "REGISTRATION";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(405, 276);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(155, 27);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // N_age
            // 
            N_age.BackColor = Color.Gainsboro;
            N_age.Location = new Point(237, 174);
            N_age.Name = "N_age";
            N_age.Size = new Size(322, 30);
            N_age.TabIndex = 10;
            // 
            // txt_Username
            // 
            txt_Username.BackColor = Color.Gainsboro;
            txt_Username.BorderStyle = BorderStyle.None;
            txt_Username.Location = new Point(237, 64);
            txt_Username.Multiline = true;
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(322, 32);
            txt_Username.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 247);
            label5.Name = "label5";
            label5.Size = new Size(155, 23);
            label5.TabIndex = 4;
            label5.Text = "Confirm Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 102);
            label4.Name = "label4";
            label4.Size = new Size(54, 23);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 176);
            label3.Name = "label3";
            label3.Size = new Size(42, 23);
            label3.TabIndex = 2;
            label3.Text = "Age";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 210);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 64);
            label1.Name = "label1";
            label1.Size = new Size(92, 23);
            label1.TabIndex = 0;
            label1.Text = "UserName";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(116, 86, 174);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(889, 525);
            Controls.Add(panel1);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)N_age).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_Username;
        private CheckBox checkBox1;
        private NumericUpDown N_age;
        private TextBox txt_email;
        private TextBox txt_confirm;
        private TextBox text_password;
        private Button Register;
        private Label label8;
        private Label label7;
        private Button button2;
        private Button Back;
        private TextBox txt_address;
        private Label address;
    }
}