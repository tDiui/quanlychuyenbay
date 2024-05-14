namespace BaoCaoCuoiKy
{
    partial class Register
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
            Dangkigrbox = new GroupBox();
            label4 = new Label();
            Dangnhap_button = new Button();
            Dangkitaikhoan_button = new Button();
            password_TextBox = new TextBox();
            account_TextBox = new TextBox();
            nhapvaohovaten_textbox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            XacnhanMatKhau_textbox = new TextBox();
            Dangkigrbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Dangkigrbox
            // 
            Dangkigrbox.Controls.Add(XacnhanMatKhau_textbox);
            Dangkigrbox.Controls.Add(label5);
            Dangkigrbox.Controls.Add(label4);
            Dangkigrbox.Controls.Add(Dangnhap_button);
            Dangkigrbox.Controls.Add(Dangkitaikhoan_button);
            Dangkigrbox.Controls.Add(password_TextBox);
            Dangkigrbox.Controls.Add(account_TextBox);
            Dangkigrbox.Controls.Add(nhapvaohovaten_textbox);
            Dangkigrbox.Controls.Add(label2);
            Dangkigrbox.Controls.Add(label1);
            Dangkigrbox.Controls.Add(label3);
            Dangkigrbox.Location = new Point(288, 12);
            Dangkigrbox.Name = "Dangkigrbox";
            Dangkigrbox.Size = new Size(500, 277);
            Dangkigrbox.TabIndex = 0;
            Dangkigrbox.TabStop = false;
            Dangkigrbox.Text = "Đăng kí";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Image = Properties.Resources.passworrd;
            label4.Location = new Point(398, 131);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 8;
            // 
            // Dangnhap_button
            // 
            Dangnhap_button.Image = Properties.Resources.login;
            Dangnhap_button.ImageAlign = ContentAlignment.MiddleLeft;
            Dangnhap_button.Location = new Point(260, 221);
            Dangnhap_button.Name = "Dangnhap_button";
            Dangnhap_button.Size = new Size(138, 35);
            Dangnhap_button.TabIndex = 7;
            Dangnhap_button.Text = "Đăng nhập";
            Dangnhap_button.TextAlign = ContentAlignment.MiddleRight;
            Dangnhap_button.UseVisualStyleBackColor = true;
            Dangnhap_button.Click += Dangnhap_button_Click;
            // 
            // Dangkitaikhoan_button
            // 
            Dangkitaikhoan_button.Image = Properties.Resources.register;
            Dangkitaikhoan_button.ImageAlign = ContentAlignment.MiddleLeft;
            Dangkitaikhoan_button.Location = new Point(61, 221);
            Dangkitaikhoan_button.Name = "Dangkitaikhoan_button";
            Dangkitaikhoan_button.Size = new Size(164, 35);
            Dangkitaikhoan_button.TabIndex = 6;
            Dangkitaikhoan_button.Text = "Đăng kí tài khoản";
            Dangkitaikhoan_button.TextAlign = ContentAlignment.MiddleRight;
            Dangkitaikhoan_button.UseVisualStyleBackColor = true;
            Dangkitaikhoan_button.Click += Dangkitaikhoan_button_Click;
            // 
            // password_TextBox
            // 
            password_TextBox.Location = new Point(209, 128);
            password_TextBox.Name = "password_TextBox";
            password_TextBox.Size = new Size(203, 27);
            password_TextBox.TabIndex = 5;
            password_TextBox.TextChanged += passwordtextbox;
            // 
            // account_TextBox
            // 
            account_TextBox.Location = new Point(209, 92);
            account_TextBox.Name = "account_TextBox";
            account_TextBox.Size = new Size(203, 27);
            account_TextBox.TabIndex = 4;
            account_TextBox.TextChanged += accounttextbox;
            // 
            // nhapvaohovaten_textbox
            // 
            nhapvaohovaten_textbox.Location = new Point(209, 50);
            nhapvaohovaten_textbox.Name = "nhapvaohovaten_textbox";
            nhapvaohovaten_textbox.Size = new Size(203, 27);
            nhapvaohovaten_textbox.TabIndex = 3;
            nhapvaohovaten_textbox.TextChanged += Nhaphovatentextbox;
            // 
            // label2
            // 
            label2.Image = Properties.Resources.pw1__2_;
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(20, 135);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.Image = Properties.Resources.avt__3_;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(20, 92);
            label1.Name = "label1";
            label1.Size = new Size(103, 23);
            label1.TabIndex = 1;
            label1.Text = "Tài khoản";
            // 
            // label3
            // 
            label3.Image = Properties.Resources.ghihoten;
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(20, 50);
            label3.Name = "label3";
            label3.Size = new Size(172, 25);
            label3.TabIndex = 0;
            label3.Text = "Nhập vào Họ và Tên";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 277);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.Image = Properties.Resources.pw1__2_;
            label5.ImageAlign = ContentAlignment.MiddleRight;
            label5.Location = new Point(20, 177);
            label5.Name = "label5";
            label5.Size = new Size(172, 20);
            label5.TabIndex = 9;
            label5.Text = "Xác nhận mật khẩu";
            // 
            // XacnhanMatKhau_textbox
            // 
            XacnhanMatKhau_textbox.Location = new Point(209, 170);
            XacnhanMatKhau_textbox.Name = "XacnhanMatKhau_textbox";
            XacnhanMatKhau_textbox.Size = new Size(203, 27);
            XacnhanMatKhau_textbox.TabIndex = 10;
            XacnhanMatKhau_textbox.TextChanged += XacnhanMatKhau_textbox_TextChanged;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(Dangkigrbox);
            Name = "Register";
            Text = "Register";
            Dangkigrbox.ResumeLayout(false);
            Dangkigrbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Dangkigrbox;
        private Button Dangnhap_button;
        private Button Dangkitaikhoan_button;
        private TextBox password_TextBox;
        private TextBox account_TextBox;
        private TextBox nhapvaohovaten_textbox;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private TextBox XacnhanMatKhau_textbox;
        private Label label5;
    }
}