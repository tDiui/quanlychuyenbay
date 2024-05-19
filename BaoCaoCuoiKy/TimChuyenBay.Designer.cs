namespace BaoCaoCuoiKy
{
    partial class TimChuyenBay
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1177, 582);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellFormatting += Formating;
            // 
            // TimChuyenBayBtn
            // 
            TimChuyenBayBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TimChuyenBayBtn.Location = new Point(933, 42);
            TimChuyenBayBtn.Name = "TimChuyenBayBtn";
            TimChuyenBayBtn.Size = new Size(134, 41);
            TimChuyenBayBtn.TabIndex = 1;
            TimChuyenBayBtn.Text = "Tìm chuyến bay";
            TimChuyenBayBtn.UseVisualStyleBackColor = true;
            TimChuyenBayBtn.Click += TimChuyenBayBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 12);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 4;
            label1.Text = "Điểm đi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 12);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 4;
            label2.Text = "Điểm đến";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(366, 12);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 4;
            label3.Text = "Thời gian đi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(565, 12);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 4;
            label4.Text = "Thời gian về";
            // 
            // DiemDenPick
            // 
            DiemDenPick.FormattingEnabled = true;
            DiemDenPick.Location = new Point(181, 49);
            DiemDenPick.Name = "DiemDenPick";
            DiemDenPick.Size = new Size(132, 28);
            DiemDenPick.TabIndex = 6;
            // 
            // NgayVePick
            // 
            NgayVePick.Location = new Point(567, 50);
            NgayVePick.Name = "NgayVePick";
            NgayVePick.Size = new Size(150, 27);
            NgayVePick.TabIndex = 8;
            // 
            // NgayDiPick
            // 
            NgayDiPick.Location = new Point(366, 50);
            NgayDiPick.Name = "NgayDiPick";
            NgayDiPick.Size = new Size(150, 27);
            NgayDiPick.TabIndex = 8;
            // 
            // DiemDiPick
            // 
            DiemDiPick.FormattingEnabled = true;
            DiemDiPick.Location = new Point(12, 49);
            DiemDiPick.Name = "DiemDiPick";
            DiemDiPick.Size = new Size(132, 28);
            DiemDiPick.TabIndex = 6;
            // 
            // KhuHoiPick
            // 
            KhuHoiPick.FormattingEnabled = true;
            KhuHoiPick.Items.AddRange(new object[] { "True", "False" });
            KhuHoiPick.Location = new Point(786, 49);
            KhuHoiPick.Name = "KhuHoiPick";
            KhuHoiPick.Size = new Size(85, 28);
            KhuHoiPick.TabIndex = 9;
            KhuHoiPick.SelectedIndexChanged += KhuHoiPick_SelectedIndexChanged;
            // 
            // KhuHoiLb
            // 
            KhuHoiLb.AutoSize = true;
            KhuHoiLb.Location = new Point(786, 9);
            KhuHoiLb.Name = "KhuHoiLb";
            KhuHoiLb.Size = new Size(60, 20);
            KhuHoiLb.TabIndex = 10;
            KhuHoiLb.Text = "Khứ hồi";
            // 
            // DatChuyenBay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1180, 719);
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
        private Label KhuHoiLb;
    }
}