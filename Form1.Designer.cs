namespace WinFormsApp1
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
            label1 = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnlogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(313, 69);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(546, 115);
            label1.TabIndex = 0;
            label1.Text = "Hệ thống quản lý sinh viên";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(501, 272);
            txt_username.Margin = new Padding(4, 5, 4, 5);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(358, 31);
            txt_username.TabIndex = 1;
            txt_username.TextChanged += textBox1_TextChanged;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(501, 333);
            txt_password.Margin = new Padding(4, 5, 4, 5);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(358, 31);
            txt_password.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(284, 263);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(209, 42);
            label2.TabIndex = 3;
            label2.Text = "Tên đăng nhập";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(284, 324);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(149, 42);
            label3.TabIndex = 4;
            label3.Text = "Mật khẩu";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = SystemColors.HotTrack;
            btnlogin.DialogResult = DialogResult.TryAgain;
            btnlogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnlogin.ForeColor = Color.Snow;
            btnlogin.Location = new Point(501, 410);
            btnlogin.Margin = new Padding(4, 5, 4, 5);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(150, 73);
            btnlogin.TabIndex = 5;
            btnlogin.Text = "Đăng nhập";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1143, 750);
            Controls.Add(btnlogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "LoginForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_username;
        private TextBox txt_password;
        private Label label2;
        private Label label3;
        private Button btnlogin;
    }
}