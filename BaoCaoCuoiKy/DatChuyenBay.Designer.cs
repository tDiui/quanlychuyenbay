namespace BaoCaoCuoiKy
{
    partial class DatChuyenBay
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
            dataGridView1 = new DataGridView();
            IdChuyenBayBox = new DataGridViewTextBoxColumn();
            NoiKhoiHanhBox = new DataGridViewTextBoxColumn();
            NoiHaCanhBox = new DataGridViewTextBoxColumn();
            TGKhoiHanhBox = new DataGridViewTextBoxColumn();
            TGVeBox = new DataGridViewTextBoxColumn();
            GiaVeBox = new DataGridViewTextBoxColumn();
            TongChoNgoiBox = new DataGridViewTextBoxColumn();
            IdChuyenBayKhuHoiBox = new DataGridViewTextBoxColumn();
            LaChuyenBayKhuHoiBox = new DataGridViewTextBoxColumn();
            TimChuyenBayBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            DiemDenPick = new ComboBox();
            NgayVePick = new DateTimePicker();
            NgayDiPick = new DateTimePicker();
            DiemDiPick = new ComboBox();
            KhuHoiPick = new ComboBox();
            KhuHoiLb = new Label();
            Thoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdChuyenBayBox, NoiKhoiHanhBox, NoiHaCanhBox, TGKhoiHanhBox, TGVeBox, GiaVeBox, TongChoNgoiBox, IdChuyenBayKhuHoiBox, LaChuyenBayKhuHoiBox });
            dataGridView1.Location = new Point(1, 100);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1030, 436);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // IdChuyenBayBox
            // 
            IdChuyenBayBox.HeaderText = "Id chuyến bay";
            IdChuyenBayBox.MinimumWidth = 6;
            IdChuyenBayBox.Name = "IdChuyenBayBox";
            IdChuyenBayBox.Width = 125;
            // 
            // NoiKhoiHanhBox
            // 
            NoiKhoiHanhBox.HeaderText = "Nơi khởi hành";
            NoiKhoiHanhBox.MinimumWidth = 6;
            NoiKhoiHanhBox.Name = "NoiKhoiHanhBox";
            NoiKhoiHanhBox.Width = 125;
            // 
            // NoiHaCanhBox
            // 
            NoiHaCanhBox.HeaderText = "Nơi hạ cánh";
            NoiHaCanhBox.MinimumWidth = 6;
            NoiHaCanhBox.Name = "NoiHaCanhBox";
            NoiHaCanhBox.Width = 125;
            // 
            // TGKhoiHanhBox
            // 
            TGKhoiHanhBox.HeaderText = "Thời gian khởi hành";
            TGKhoiHanhBox.MinimumWidth = 6;
            TGKhoiHanhBox.Name = "TGKhoiHanhBox";
            TGKhoiHanhBox.Width = 125;
            // 
            // TGVeBox
            // 
            TGVeBox.HeaderText = "Thời gian về";
            TGVeBox.MinimumWidth = 6;
            TGVeBox.Name = "TGVeBox";
            TGVeBox.Width = 125;
            // 
            // GiaVeBox
            // 
            GiaVeBox.HeaderText = "Giá vé";
            GiaVeBox.MinimumWidth = 6;
            GiaVeBox.Name = "GiaVeBox";
            GiaVeBox.Width = 125;
            // 
            // TongChoNgoiBox
            // 
            TongChoNgoiBox.HeaderText = "Tổng chỗ ngồi";
            TongChoNgoiBox.MinimumWidth = 6;
            TongChoNgoiBox.Name = "TongChoNgoiBox";
            TongChoNgoiBox.Width = 125;
            // 
            // IdChuyenBayKhuHoiBox
            // 
            IdChuyenBayKhuHoiBox.HeaderText = "Id chuyến bay khứ hồi";
            IdChuyenBayKhuHoiBox.MinimumWidth = 6;
            IdChuyenBayKhuHoiBox.Name = "IdChuyenBayKhuHoiBox";
            IdChuyenBayKhuHoiBox.Width = 125;
            // 
            // LaChuyenBayKhuHoiBox
            // 
            LaChuyenBayKhuHoiBox.HeaderText = "Là chuyến bay khứ hồi";
            LaChuyenBayKhuHoiBox.MinimumWidth = 6;
            LaChuyenBayKhuHoiBox.Name = "LaChuyenBayKhuHoiBox";
            LaChuyenBayKhuHoiBox.Width = 125;
            // 
            // TimChuyenBayBtn
            // 
            TimChuyenBayBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TimChuyenBayBtn.Location = new Point(853, 11);
            TimChuyenBayBtn.Margin = new Padding(3, 2, 3, 2);
            TimChuyenBayBtn.Name = "TimChuyenBayBtn";
            TimChuyenBayBtn.Size = new Size(117, 31);
            TimChuyenBayBtn.TabIndex = 1;
            TimChuyenBayBtn.Text = "Tìm chuyến bay";
            TimChuyenBayBtn.UseVisualStyleBackColor = true;
            TimChuyenBayBtn.Click += TimChuyenBayBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 9);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 4;
            label1.Text = "Điểm đi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 9);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 4;
            label2.Text = "Điểm đến";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(320, 9);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 4;
            label3.Text = "Thời gian đi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(494, 9);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 4;
            label4.Text = "Thời gian về";
            // 
            // DiemDenPick
            // 
            DiemDenPick.FormattingEnabled = true;
            DiemDenPick.Location = new Point(158, 37);
            DiemDenPick.Margin = new Padding(3, 2, 3, 2);
            DiemDenPick.Name = "DiemDenPick";
            DiemDenPick.Size = new Size(116, 23);
            DiemDenPick.TabIndex = 6;
            // 
            // NgayVePick
            // 
            NgayVePick.Location = new Point(496, 38);
            NgayVePick.Margin = new Padding(3, 2, 3, 2);
            NgayVePick.Name = "NgayVePick";
            NgayVePick.Size = new Size(132, 23);
            NgayVePick.TabIndex = 8;
            // 
            // NgayDiPick
            // 
            NgayDiPick.Location = new Point(320, 38);
            NgayDiPick.Margin = new Padding(3, 2, 3, 2);
            NgayDiPick.Name = "NgayDiPick";
            NgayDiPick.Size = new Size(132, 23);
            NgayDiPick.TabIndex = 8;
            // 
            // DiemDiPick
            // 
            DiemDiPick.FormattingEnabled = true;
            DiemDiPick.Location = new Point(10, 37);
            DiemDiPick.Margin = new Padding(3, 2, 3, 2);
            DiemDiPick.Name = "DiemDiPick";
            DiemDiPick.Size = new Size(116, 23);
            DiemDiPick.TabIndex = 6;
            DiemDiPick.SelectedIndexChanged += DiemDiPick_SelectedIndexChanged;
            // 
            // KhuHoiPick
            // 
            KhuHoiPick.FormattingEnabled = true;
            KhuHoiPick.Items.AddRange(new object[] { "True", "False" });
            KhuHoiPick.Location = new Point(688, 37);
            KhuHoiPick.Margin = new Padding(3, 2, 3, 2);
            KhuHoiPick.Name = "KhuHoiPick";
            KhuHoiPick.Size = new Size(75, 23);
            KhuHoiPick.TabIndex = 9;
            // 
            // KhuHoiLb
            // 
            KhuHoiLb.AutoSize = true;
            KhuHoiLb.Location = new Point(688, 7);
            KhuHoiLb.Name = "KhuHoiLb";
            KhuHoiLb.Size = new Size(48, 15);
            KhuHoiLb.TabIndex = 10;
            KhuHoiLb.Text = "Khứ hồi";
            // 
            // Thoat
            // 
            Thoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Thoat.Location = new Point(853, 47);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(117, 31);
            Thoat.TabIndex = 11;
            Thoat.Text = "Thoat";
            Thoat.UseVisualStyleBackColor = true;
            Thoat.Click += button1_Click;
            // 
            // DatChuyenBay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1032, 539);
            Controls.Add(Thoat);
            Controls.Add(KhuHoiLb);
            Controls.Add(KhuHoiPick);
            Controls.Add(NgayDiPick);
            Controls.Add(NgayVePick);
            Controls.Add(DiemDiPick);
            Controls.Add(DiemDenPick);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TimChuyenBayBtn);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "DatChuyenBay";
            Text = "DatChuyenBay";
            Load += DatChuyenBay_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button TimChuyenBayBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox KhuHoiPick;
        private ComboBox DiemDenPick;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker NgayVePick;
        private DateTimePicker NgayDiPick;
        private ComboBox DiemDiPick;
        private DataGridViewTextBoxColumn IdChuyenBayBox;
        private DataGridViewTextBoxColumn NoiKhoiHanhBox;
        private DataGridViewTextBoxColumn NoiHaCanhBox;
        private DataGridViewTextBoxColumn TGKhoiHanhBox;
        private DataGridViewTextBoxColumn TGVeBox;
        private DataGridViewTextBoxColumn GiaVeBox;
        private DataGridViewTextBoxColumn TongChoNgoiBox;
        private DataGridViewTextBoxColumn IdChuyenBayKhuHoiBox;
        private DataGridViewTextBoxColumn LaChuyenBayKhuHoiBox;
        private Label KhuHoiLb;
        private Button Thoat;
    }
}