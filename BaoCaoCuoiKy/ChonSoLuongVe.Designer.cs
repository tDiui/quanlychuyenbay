namespace BaoCaoCuoiKy
{
    partial class ChonSoLuongVe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChonSoLuongVe));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SoLuongVeBox = new TextBox();
            BatDauChonGheBtn = new Button();
            LoaiVeBox = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(185, 354);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Underline);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(212, 23);
            label1.Name = "label1";
            label1.Size = new Size(299, 37);
            label1.TabIndex = 1;
            label1.Text = "Nhập thông tin đặt vé";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(193, 127);
            label2.Name = "label2";
            label2.Size = new Size(125, 28);
            label2.TabIndex = 2;
            label2.Text = "Số lượng vé";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(239, 192);
            label3.Name = "label3";
            label3.Size = new Size(79, 28);
            label3.TabIndex = 3;
            label3.Text = "Loại vé";
            // 
            // SoLuongVeBox
            // 
            SoLuongVeBox.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            SoLuongVeBox.ForeColor = SystemColors.MenuText;
            SoLuongVeBox.Location = new Point(340, 135);
            SoLuongVeBox.Name = "SoLuongVeBox";
            SoLuongVeBox.Size = new Size(146, 27);
            SoLuongVeBox.TabIndex = 4;
            // 
            // BatDauChonGheBtn
            // 
            BatDauChonGheBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BatDauChonGheBtn.Location = new Point(355, 269);
            BatDauChonGheBtn.Name = "BatDauChonGheBtn";
            BatDauChonGheBtn.Size = new Size(118, 35);
            BatDauChonGheBtn.TabIndex = 5;
            BatDauChonGheBtn.Text = "Chọn ghế";
            BatDauChonGheBtn.UseVisualStyleBackColor = true;
            BatDauChonGheBtn.Click += BatDauChonGheBtn_Click;
            // 
            // LoaiVeBox
            // 
            LoaiVeBox.FormattingEnabled = true;
            LoaiVeBox.Items.AddRange(new object[] { "Pho Thong", "Tiet Kiem", "Thuong Gia" });
            LoaiVeBox.Location = new Point(340, 192);
            LoaiVeBox.Name = "LoaiVeBox";
            LoaiVeBox.Size = new Size(144, 28);
            LoaiVeBox.TabIndex = 6;
            // 
            // ChonSoLuongVe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 357);
            Controls.Add(LoaiVeBox);
            Controls.Add(BatDauChonGheBtn);
            Controls.Add(SoLuongVeBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "ChonSoLuongVe";
            Text = "ChonSoLuongVe";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox SoLuongVeBox;
        private Button BatDauChonGheBtn;
        private ComboBox LoaiVeBox;
    }
}