﻿namespace BaoCaoCuoiKy
{
    partial class QuanTriForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanTriForm));
            menuStrip1 = new MenuStrip();
            ThemChuyenBayBtn = new ToolStripMenuItem();
            XoaChuyenBayBtn = new ToolStripMenuItem();
            TimChuyenBayBtn = new ToolStripMenuItem();
            panel1 = new Panel();
            TimChuyenBayLb = new Label();
            XoaChuyenBayLb = new Label();
            ThemChuyenBayLb = new Label();
            ThoatBtn = new Button();
            TimChuyenBay = new Button();
            ThucHienBtn = new Button();
            ResetBtn = new Button();
            pictureBox1 = new PictureBox();
            ThemChuyenBayPanel = new Panel();
            LaChuyenBayKhuHoiBox = new TextBox();
            IdChuyenBayKhuHoiBox = new TextBox();
            GiaVeBox = new TextBox();
            TGDenNoiBox = new TextBox();
            TongChoNgoiBox = new TextBox();
            TGKhoiHanhBox = new TextBox();
            NoiHaCanhBox = new TextBox();
            NoiCatCanhBox = new TextBox();
            IdChuyenBayBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            thongtinKHbtn = new Button();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ThemChuyenBayPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ThemChuyenBayBtn, XoaChuyenBayBtn, TimChuyenBayBtn });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(922, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // ThemChuyenBayBtn
            // 
            ThemChuyenBayBtn.Name = "ThemChuyenBayBtn";
            ThemChuyenBayBtn.Size = new Size(113, 20);
            ThemChuyenBayBtn.Text = "Thêm chuyến bay";
            ThemChuyenBayBtn.Click += ThemChuyenBayBtn_Click;
            // 
            // XoaChuyenBayBtn
            // 
            XoaChuyenBayBtn.Name = "XoaChuyenBayBtn";
            XoaChuyenBayBtn.Size = new Size(103, 20);
            XoaChuyenBayBtn.Text = "Xóa chuyến bay";
            XoaChuyenBayBtn.Click += XoaChuyenBayBtn_Click;
            // 
            // TimChuyenBayBtn
            // 
            TimChuyenBayBtn.Name = "TimChuyenBayBtn";
            TimChuyenBayBtn.Size = new Size(103, 20);
            TimChuyenBayBtn.Text = "Tìm chuyến bay";
            TimChuyenBayBtn.Click += TimChuyenBayBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(thongtinKHbtn);
            panel1.Controls.Add(TimChuyenBayLb);
            panel1.Controls.Add(XoaChuyenBayLb);
            panel1.Controls.Add(ThemChuyenBayLb);
            panel1.Controls.Add(ThoatBtn);
            panel1.Controls.Add(TimChuyenBay);
            panel1.Controls.Add(ThucHienBtn);
            panel1.Controls.Add(ResetBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 38);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(169, 407);
            panel1.TabIndex = 3;
            // 
            // TimChuyenBayLb
            // 
            TimChuyenBayLb.AutoSize = true;
            TimChuyenBayLb.BorderStyle = BorderStyle.Fixed3D;
            TimChuyenBayLb.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TimChuyenBayLb.ForeColor = Color.Red;
            TimChuyenBayLb.Location = new Point(12, 100);
            TimChuyenBayLb.Name = "TimChuyenBayLb";
            TimChuyenBayLb.RightToLeft = RightToLeft.Yes;
            TimChuyenBayLb.Size = new Size(133, 23);
            TimChuyenBayLb.TabIndex = 4;
            TimChuyenBayLb.Text = "Tìm chuyến bay";
            TimChuyenBayLb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // XoaChuyenBayLb
            // 
            XoaChuyenBayLb.AutoSize = true;
            XoaChuyenBayLb.BorderStyle = BorderStyle.Fixed3D;
            XoaChuyenBayLb.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            XoaChuyenBayLb.ForeColor = Color.Red;
            XoaChuyenBayLb.Location = new Point(12, 100);
            XoaChuyenBayLb.Name = "XoaChuyenBayLb";
            XoaChuyenBayLb.RightToLeft = RightToLeft.Yes;
            XoaChuyenBayLb.Size = new Size(133, 23);
            XoaChuyenBayLb.TabIndex = 3;
            XoaChuyenBayLb.Text = "Xóa chuyến bay";
            XoaChuyenBayLb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ThemChuyenBayLb
            // 
            ThemChuyenBayLb.AutoSize = true;
            ThemChuyenBayLb.BorderStyle = BorderStyle.Fixed3D;
            ThemChuyenBayLb.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ThemChuyenBayLb.ForeColor = Color.Red;
            ThemChuyenBayLb.Location = new Point(3, 100);
            ThemChuyenBayLb.Name = "ThemChuyenBayLb";
            ThemChuyenBayLb.RightToLeft = RightToLeft.Yes;
            ThemChuyenBayLb.Size = new Size(147, 23);
            ThemChuyenBayLb.TabIndex = 2;
            ThemChuyenBayLb.Text = "Thêm chuyến bay";
            ThemChuyenBayLb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ThoatBtn
            // 
            ThoatBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ThoatBtn.Location = new Point(3, 364);
            ThoatBtn.Margin = new Padding(3, 2, 3, 2);
            ThoatBtn.Name = "ThoatBtn";
            ThoatBtn.Size = new Size(162, 31);
            ThoatBtn.TabIndex = 1;
            ThoatBtn.Text = "Thoát";
            ThoatBtn.UseVisualStyleBackColor = true;
            ThoatBtn.Click += ThoatBtn_Click;
            // 
            // TimChuyenBay
            // 
            TimChuyenBay.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TimChuyenBay.Location = new Point(4, 260);
            TimChuyenBay.Margin = new Padding(3, 2, 3, 2);
            TimChuyenBay.Name = "TimChuyenBay";
            TimChuyenBay.Size = new Size(162, 31);
            TimChuyenBay.TabIndex = 1;
            TimChuyenBay.Text = "Tìm chuyến bay";
            TimChuyenBay.UseVisualStyleBackColor = true;
            TimChuyenBay.Click += TimChuyenBay_Click;
            // 
            // ThucHienBtn
            // 
            ThucHienBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ThucHienBtn.Location = new Point(4, 214);
            ThucHienBtn.Margin = new Padding(3, 2, 3, 2);
            ThucHienBtn.Name = "ThucHienBtn";
            ThucHienBtn.Size = new Size(162, 31);
            ThucHienBtn.TabIndex = 1;
            ThucHienBtn.Text = "Thực hiện";
            ThucHienBtn.UseVisualStyleBackColor = true;
            ThucHienBtn.Click += ThucHienBtn_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ResetBtn.Location = new Point(4, 167);
            ResetBtn.Margin = new Padding(3, 2, 3, 2);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(162, 31);
            ResetBtn.TabIndex = 1;
            ResetBtn.Text = "Reset ô nhập";
            ResetBtn.UseCompatibleTextRendering = true;
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ThemChuyenBayPanel
            // 
            ThemChuyenBayPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ThemChuyenBayPanel.Controls.Add(LaChuyenBayKhuHoiBox);
            ThemChuyenBayPanel.Controls.Add(IdChuyenBayKhuHoiBox);
            ThemChuyenBayPanel.Controls.Add(GiaVeBox);
            ThemChuyenBayPanel.Controls.Add(TGDenNoiBox);
            ThemChuyenBayPanel.Controls.Add(TongChoNgoiBox);
            ThemChuyenBayPanel.Controls.Add(TGKhoiHanhBox);
            ThemChuyenBayPanel.Controls.Add(NoiHaCanhBox);
            ThemChuyenBayPanel.Controls.Add(NoiCatCanhBox);
            ThemChuyenBayPanel.Controls.Add(IdChuyenBayBox);
            ThemChuyenBayPanel.Controls.Add(label1);
            ThemChuyenBayPanel.Controls.Add(label2);
            ThemChuyenBayPanel.Controls.Add(label3);
            ThemChuyenBayPanel.Controls.Add(label4);
            ThemChuyenBayPanel.Controls.Add(label5);
            ThemChuyenBayPanel.Controls.Add(label10);
            ThemChuyenBayPanel.Controls.Add(label11);
            ThemChuyenBayPanel.Controls.Add(label12);
            ThemChuyenBayPanel.Controls.Add(label13);
            ThemChuyenBayPanel.Location = new Point(172, 38);
            ThemChuyenBayPanel.Margin = new Padding(3, 2, 3, 2);
            ThemChuyenBayPanel.Name = "ThemChuyenBayPanel";
            ThemChuyenBayPanel.Size = new Size(746, 407);
            ThemChuyenBayPanel.TabIndex = 18;
            // 
            // LaChuyenBayKhuHoiBox
            // 
            LaChuyenBayKhuHoiBox.Location = new Point(164, 372);
            LaChuyenBayKhuHoiBox.Margin = new Padding(3, 2, 3, 2);
            LaChuyenBayKhuHoiBox.Name = "LaChuyenBayKhuHoiBox";
            LaChuyenBayKhuHoiBox.Size = new Size(312, 23);
            LaChuyenBayKhuHoiBox.TabIndex = 16;
            // 
            // IdChuyenBayKhuHoiBox
            // 
            IdChuyenBayKhuHoiBox.Location = new Point(164, 326);
            IdChuyenBayKhuHoiBox.Margin = new Padding(3, 2, 3, 2);
            IdChuyenBayKhuHoiBox.Name = "IdChuyenBayKhuHoiBox";
            IdChuyenBayKhuHoiBox.Size = new Size(312, 23);
            IdChuyenBayKhuHoiBox.TabIndex = 15;
            // 
            // GiaVeBox
            // 
            GiaVeBox.Location = new Point(164, 235);
            GiaVeBox.Margin = new Padding(3, 2, 3, 2);
            GiaVeBox.Name = "GiaVeBox";
            GiaVeBox.Size = new Size(312, 23);
            GiaVeBox.TabIndex = 14;
            // 
            // TGDenNoiBox
            // 
            TGDenNoiBox.Location = new Point(164, 189);
            TGDenNoiBox.Margin = new Padding(3, 2, 3, 2);
            TGDenNoiBox.Name = "TGDenNoiBox";
            TGDenNoiBox.Size = new Size(312, 23);
            TGDenNoiBox.TabIndex = 13;
            // 
            // TongChoNgoiBox
            // 
            TongChoNgoiBox.Location = new Point(164, 280);
            TongChoNgoiBox.Margin = new Padding(3, 2, 3, 2);
            TongChoNgoiBox.Name = "TongChoNgoiBox";
            TongChoNgoiBox.Size = new Size(312, 23);
            TongChoNgoiBox.TabIndex = 13;
            // 
            // TGKhoiHanhBox
            // 
            TGKhoiHanhBox.Location = new Point(164, 143);
            TGKhoiHanhBox.Margin = new Padding(3, 2, 3, 2);
            TGKhoiHanhBox.Name = "TGKhoiHanhBox";
            TGKhoiHanhBox.Size = new Size(312, 23);
            TGKhoiHanhBox.TabIndex = 12;
            // 
            // NoiHaCanhBox
            // 
            NoiHaCanhBox.Location = new Point(164, 98);
            NoiHaCanhBox.Margin = new Padding(3, 2, 3, 2);
            NoiHaCanhBox.Name = "NoiHaCanhBox";
            NoiHaCanhBox.Size = new Size(312, 23);
            NoiHaCanhBox.TabIndex = 11;
            // 
            // NoiCatCanhBox
            // 
            NoiCatCanhBox.Location = new Point(164, 52);
            NoiCatCanhBox.Margin = new Padding(3, 2, 3, 2);
            NoiCatCanhBox.Name = "NoiCatCanhBox";
            NoiCatCanhBox.Size = new Size(312, 23);
            NoiCatCanhBox.TabIndex = 10;
            // 
            // IdChuyenBayBox
            // 
            IdChuyenBayBox.Location = new Point(164, 6);
            IdChuyenBayBox.Margin = new Padding(3, 2, 3, 2);
            IdChuyenBayBox.Name = "IdChuyenBayBox";
            IdChuyenBayBox.Size = new Size(312, 23);
            IdChuyenBayBox.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 329);
            label1.Margin = new Padding(4, 0, 0, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(124, 15);
            label1.TabIndex = 8;
            label1.Text = "Id chuyến bay khứ hồi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 375);
            label2.Margin = new Padding(4, 0, 0, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(126, 15);
            label2.TabIndex = 7;
            label2.Text = "Là chuyến bay khứ hồi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 192);
            label3.Margin = new Padding(4, 0, 0, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(99, 15);
            label3.TabIndex = 6;
            label3.Text = "Thời gian đến nơi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(108, 238);
            label4.Margin = new Padding(4, 0, 0, 0);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(39, 15);
            label4.TabIndex = 5;
            label4.Text = "Giá vé";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 284);
            label5.Margin = new Padding(4, 0, 0, 0);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(84, 15);
            label5.TabIndex = 4;
            label5.Text = "Tổng chỗ ngồi";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(30, 146);
            label10.Margin = new Padding(4, 0, 0, 0);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.No;
            label10.Size = new Size(112, 15);
            label10.TabIndex = 3;
            label10.Text = "Thời gian khởi hành";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(74, 100);
            label11.Margin = new Padding(4, 0, 0, 0);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.No;
            label11.Size = new Size(71, 15);
            label11.TabIndex = 2;
            label11.Text = "Nơi hạ cánh";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(71, 55);
            label12.Margin = new Padding(4, 0, 0, 0);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.No;
            label12.Size = new Size(74, 15);
            label12.TabIndex = 1;
            label12.Text = "Nơi cất cánh";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Location = new Point(64, 9);
            label13.Margin = new Padding(4, 0, 0, 0);
            label13.Name = "label13";
            label13.RightToLeft = RightToLeft.No;
            label13.Size = new Size(81, 15);
            label13.TabIndex = 0;
            label13.Text = "Id chuyến bay";
            // 
            // thongtinKHbtn
            // 
            thongtinKHbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            thongtinKHbtn.Location = new Point(3, 304);
            thongtinKHbtn.Margin = new Padding(3, 2, 3, 2);
            thongtinKHbtn.Name = "thongtinKHbtn";
            thongtinKHbtn.Size = new Size(162, 31);
            thongtinKHbtn.TabIndex = 5;
            thongtinKHbtn.Text = "ThongtinKH";
            thongtinKHbtn.UseVisualStyleBackColor = true;
            thongtinKHbtn.Click += thongtinKHbtn_Click;
            // 
            // QuanTriForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 462);
            Controls.Add(ThemChuyenBayPanel);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "QuanTriForm";
            Text = "QuanTriForm";
            Load += QuanTriForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ThemChuyenBayPanel.ResumeLayout(false);
            ThemChuyenBayPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ThemChuyenBayBtn;
        private ToolStripMenuItem XoaChuyenBayBtn;
        private ToolStripMenuItem TimChuyenBayBtn;
        private Panel panel1;
        private Button ThoatBtn;
        private Button ThucHienBtn;
        private Button ResetBtn;
        private PictureBox pictureBox1;
        private Label label7;
        private Label XoaChuyenBayLb;
        private Label label9;
        private Label label8;
        private TextBox textBox10;
        private Button TimChuyenBay;
        private Panel ThemChuyenBayPanel;
        private TextBox LaChuyenBayKhuHoiBox;
        private TextBox IdChuyenBayKhuHoiBox;
        private TextBox GiaVeBox;
        private TextBox TGDenNoiBox;
        private TextBox TongChoNgoiBox;
        private TextBox TGKhoiHanhBox;
        private TextBox NoiHaCanhBox;
        private TextBox NoiCatCanhBox;
        private TextBox IdChuyenBayBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label ThemChuyenBayLb;
        private Label TimChuyenBayLb;
        private Button thongtinKHbtn;
    }
}