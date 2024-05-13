namespace BaoCaoCuoiKy
{
    partial class TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            label2 = new Label();
            label1 = new Label();
            MatKhauBox = new TextBox();
            TaiKhoanBox = new TextBox();
            ThoatBtn = new Button();
            DatChuyenBayBtn = new Button();
            DangNhapBtn = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.AppWorkspace;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(260, 79);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 5;
            label2.Text = "Mật khẩu:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.AppWorkspace;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(259, 27);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 4;
            label1.Text = "Tài khoản:";
            // 
            // MatKhauBox
            // 
            MatKhauBox.BackColor = SystemColors.AppWorkspace;
            MatKhauBox.Location = new Point(259, 96);
            MatKhauBox.Margin = new Padding(3, 2, 3, 2);
            MatKhauBox.Name = "MatKhauBox";
            MatKhauBox.Size = new Size(147, 23);
            MatKhauBox.TabIndex = 3;
            MatKhauBox.TextChanged += textBox2_TextChanged;
            // 
            // TaiKhoanBox
            // 
            TaiKhoanBox.BackColor = SystemColors.AppWorkspace;
            TaiKhoanBox.Location = new Point(259, 44);
            TaiKhoanBox.Margin = new Padding(3, 2, 3, 2);
            TaiKhoanBox.Name = "TaiKhoanBox";
            TaiKhoanBox.Size = new Size(148, 23);
            TaiKhoanBox.TabIndex = 2;
            // 
            // ThoatBtn
            // 
            ThoatBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ThoatBtn.Location = new Point(260, 296);
            ThoatBtn.Margin = new Padding(3, 2, 3, 2);
            ThoatBtn.Name = "ThoatBtn";
            ThoatBtn.Size = new Size(162, 31);
            ThoatBtn.TabIndex = 1;
            ThoatBtn.Text = "Thoát";
            ThoatBtn.UseVisualStyleBackColor = true;
            ThoatBtn.Click += ThoatBtn_Click;
            // 
            // DatChuyenBayBtn
            // 
            DatChuyenBayBtn.BackColor = SystemColors.AppWorkspace;
            DatChuyenBayBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DatChuyenBayBtn.Location = new Point(260, 257);
            DatChuyenBayBtn.Margin = new Padding(3, 2, 3, 2);
            DatChuyenBayBtn.Name = "DatChuyenBayBtn";
            DatChuyenBayBtn.Size = new Size(162, 31);
            DatChuyenBayBtn.TabIndex = 1;
            DatChuyenBayBtn.Text = "Đặt chuyến bay";
            DatChuyenBayBtn.UseVisualStyleBackColor = false;
            DatChuyenBayBtn.Click += DatChuyenBayBtn_Click;
            // 
            // DangNhapBtn
            // 
            DangNhapBtn.BackColor = SystemColors.AppWorkspace;
            DangNhapBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DangNhapBtn.Location = new Point(289, 137);
            DangNhapBtn.Margin = new Padding(3, 2, 3, 2);
            DangNhapBtn.Name = "DangNhapBtn";
            DangNhapBtn.Size = new Size(88, 22);
            DangNhapBtn.TabIndex = 1;
            DangNhapBtn.Text = "Đăng nhập";
            DangNhapBtn.UseCompatibleTextRendering = true;
            DangNhapBtn.UseVisualStyleBackColor = false;
            DangNhapBtn.Click += DangNhapBtn_Click;
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(ThoatBtn);
            Controls.Add(label2);
            Controls.Add(DatChuyenBayBtn);
            Controls.Add(MatKhauBox);
            Controls.Add(DangNhapBtn);
            Controls.Add(label1);
            Controls.Add(TaiKhoanBox);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "TrangChu";
            Text = "Đăng nhập hệ thống";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ThoatBtn;
        private Button DatChuyenBayBtn;
        private Button DangNhapBtn;
        private Label label2;
        private Label label1;
        private TextBox MatKhauBox;
        private TextBox TaiKhoanBox;
    }
}