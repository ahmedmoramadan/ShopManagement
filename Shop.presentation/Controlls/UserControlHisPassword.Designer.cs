namespace Shop.presentation.Controlls
{
    partial class UserControlHisPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlHisPassword));
            panel1 = new Panel();
            ShowPass = new CheckBox();
            button1 = new Button();
            text_new = new TextBox();
            text_Confirm = new TextBox();
            text_OLD = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lblOldPass = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(ShowPass);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(text_new);
            panel1.Controls.Add(text_Confirm);
            panel1.Controls.Add(text_OLD);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblOldPass);
            panel1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(154, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(381, 367);
            panel1.TabIndex = 0;
            // 
            // ShowPass
            // 
            ShowPass.AutoSize = true;
            ShowPass.BackColor = Color.Transparent;
            ShowPass.Location = new Point(191, 200);
            ShowPass.Name = "ShowPass";
            ShowPass.Size = new Size(160, 29);
            ShowPass.TabIndex = 7;
            ShowPass.Text = "ShowPassword";
            ShowPass.UseVisualStyleBackColor = false;
            ShowPass.CheckedChanged += ShowPass_CheckedChanged;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(154, 271);
            button1.Name = "button1";
            button1.Padding = new Padding(5);
            button1.Size = new Size(94, 44);
            button1.TabIndex = 6;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // text_new
            // 
            text_new.Location = new Point(170, 104);
            text_new.Name = "text_new";
            text_new.Size = new Size(181, 31);
            text_new.TabIndex = 5;
            text_new.UseSystemPasswordChar = true;
            // 
            // text_Confirm
            // 
            text_Confirm.Location = new Point(170, 163);
            text_Confirm.Name = "text_Confirm";
            text_Confirm.Size = new Size(181, 31);
            text_Confirm.TabIndex = 4;
            text_Confirm.UseSystemPasswordChar = true;
            // 
            // text_OLD
            // 
            text_OLD.Location = new Point(170, 42);
            text_OLD.Name = "text_OLD";
            text_OLD.Size = new Size(181, 31);
            text_OLD.TabIndex = 3;
            text_OLD.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 169);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 2;
            label2.Text = "Confirm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(29, 107);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 1;
            label1.Text = "New Password";
            // 
            // lblOldPass
            // 
            lblOldPass.AutoSize = true;
            lblOldPass.BackColor = Color.Transparent;
            lblOldPass.ForeColor = Color.White;
            lblOldPass.Location = new Point(29, 42);
            lblOldPass.Name = "lblOldPass";
            lblOldPass.Size = new Size(127, 25);
            lblOldPass.TabIndex = 0;
            lblOldPass.Text = "Old Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lucida Handwriting", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(154, 16);
            label3.Name = "label3";
            label3.Size = new Size(363, 36);
            label3.TabIndex = 1;
            label3.Text = "Change UR Password";
            // 
            // UserControlHisPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "UserControlHisPassword";
            Size = new Size(711, 466);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblOldPass;
        private CheckBox ShowPass;
        private Button button1;
        private TextBox text_new;
        private TextBox text_Confirm;
        private TextBox text_OLD;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}
