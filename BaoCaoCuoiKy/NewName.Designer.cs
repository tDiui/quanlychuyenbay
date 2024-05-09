namespace BaoCaoCuoiKy
{
    partial class NewName
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdChuyenBayBox, NoiKhoiHanhBox, NoiHaCanhBox, TGKhoiHanhBox, TGVeBox, GiaVeBox, TongChoNgoiBox, IdChuyenBayKhuHoiBox, LaChuyenBayKhuHoiBox });
            dataGridView1.Location = new Point(-2, -3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1187, 125);
            dataGridView1.TabIndex = 1;
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
            // NewName
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 771);
            Controls.Add(dataGridView1);
            Name = "NewName";
            Text = "Test";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IdChuyenBayBox;
        private DataGridViewTextBoxColumn NoiKhoiHanhBox;
        private DataGridViewTextBoxColumn NoiHaCanhBox;
        private DataGridViewTextBoxColumn TGKhoiHanhBox;
        private DataGridViewTextBoxColumn TGVeBox;
        private DataGridViewTextBoxColumn GiaVeBox;
        private DataGridViewTextBoxColumn TongChoNgoiBox;
        private DataGridViewTextBoxColumn IdChuyenBayKhuHoiBox;
        private DataGridViewTextBoxColumn LaChuyenBayKhuHoiBox;
    }
}