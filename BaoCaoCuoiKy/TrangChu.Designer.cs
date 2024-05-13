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
            components = new System.ComponentModel.Container();
            label2 = new Label();
            label1 = new Label();
            MatKhauBox = new TextBox();
            TaiKhoanBox = new TextBox();
            ThoatBtn = new Button();
            DatChuyenBayBtn = new Button();
            DangNhapBtn = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(222, 230);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 5;
            label2.Text = "Mật khẩu:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(222, 182);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 4;
            label1.Text = "Tài khoản:";
            // 
            // MatKhauBox
            // 
            MatKhauBox.Location = new Point(338, 227);
            MatKhauBox.Name = "MatKhauBox";
            MatKhauBox.Size = new Size(309, 27);
            MatKhauBox.TabIndex = 3;
            MatKhauBox.TextChanged += textBox2_TextChanged;
            // 
            // TaiKhoanBox
            // 
            TaiKhoanBox.Location = new Point(338, 175);
            TaiKhoanBox.Name = "TaiKhoanBox";
            TaiKhoanBox.Size = new Size(309, 27);
            TaiKhoanBox.TabIndex = 2;
            // 
            // ThoatBtn
            // 
            ThoatBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ThoatBtn.Location = new Point(490, 304);
            ThoatBtn.Name = "ThoatBtn";
            ThoatBtn.Size = new Size(100, 30);
            ThoatBtn.TabIndex = 1;
            ThoatBtn.Text = "Thoát";
            ThoatBtn.UseVisualStyleBackColor = true;
            ThoatBtn.Click += ThoatBtn_Click;
            // 
            // DatChuyenBayBtn
            // 
            DatChuyenBayBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DatChuyenBayBtn.Location = new Point(625, 304);
            DatChuyenBayBtn.Name = "DatChuyenBayBtn";
            DatChuyenBayBtn.Size = new Size(100, 30);
            DatChuyenBayBtn.TabIndex = 1;
            DatChuyenBayBtn.Text = "Đặt chuyến bay";
            DatChuyenBayBtn.UseVisualStyleBackColor = true;
            // 
            // DangNhapBtn
            // 
            DangNhapBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DangNhapBtn.Location = new Point(212, 304);
            DangNhapBtn.Name = "DangNhapBtn";
            DangNhapBtn.Size = new Size(100, 30);
            DangNhapBtn.TabIndex = 1;
            DangNhapBtn.Text = "Đăng nhập";
            DangNhapBtn.UseCompatibleTextRendering = true;
            DangNhapBtn.UseVisualStyleBackColor = true;
            DangNhapBtn.Click += DangNhapBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.anh_may_bay_dang_bay;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(-3, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(803, 449);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(350, 304);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 7;
            button1.Text = "Đăng kí";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(ThoatBtn);
            Controls.Add(MatKhauBox);
            Controls.Add(DatChuyenBayBtn);
            Controls.Add(label2);
            Controls.Add(DangNhapBtn);
            Controls.Add(label1);
            Controls.Add(TaiKhoanBox);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "TrangChu";
            Text = "Đăng nhập hệ thống";
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}