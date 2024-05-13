namespace BaoCaoCuoiKy
{
    partial class ThongTinKH
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
            Lammoi = new Button();
            Them = new Button();
            label1 = new Label();
            Thoat = new Button();
            Xoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(696, 244);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Lammoi
            // 
            Lammoi.Location = new Point(12, 27);
            Lammoi.Name = "Lammoi";
            Lammoi.Size = new Size(75, 23);
            Lammoi.TabIndex = 1;
            Lammoi.Text = "Lam moi";
            Lammoi.UseVisualStyleBackColor = true;
            Lammoi.Click += button1_Click;
            // 
            // Them
            // 
            Them.Location = new Point(128, 27);
            Them.Name = "Them";
            Them.Size = new Size(75, 23);
            Them.TabIndex = 2;
            Them.Text = "Them";
            Them.UseVisualStyleBackColor = true;
            Them.Click += Them_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(257, 4);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 3;
            label1.Text = "danh sach khach hang";
            // 
            // Thoat
            // 
            Thoat.Location = new Point(603, 27);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(75, 23);
            Thoat.TabIndex = 4;
            Thoat.Text = "Thoat";
            Thoat.UseVisualStyleBackColor = true;
            Thoat.Click += Thoat_Click;
            // 
            // Xoa
            // 
            Xoa.Location = new Point(490, 27);
            Xoa.Name = "Xoa";
            Xoa.Size = new Size(75, 23);
            Xoa.TabIndex = 5;
            Xoa.Text = "Xoa";
            Xoa.UseVisualStyleBackColor = true;
            Xoa.Click += Xoa_Click;
            // 
            // ThongTinKH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(Xoa);
            Controls.Add(Thoat);
            Controls.Add(label1);
            Controls.Add(Them);
            Controls.Add(Lammoi);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ThongTinKH";
            Text = "ThongTinKH";
            Load += ThongTinKH_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Lammoi;
        private Button Them;
        private Label label1;
        private Button Thoat;
        private Button Xoa;
    }
}