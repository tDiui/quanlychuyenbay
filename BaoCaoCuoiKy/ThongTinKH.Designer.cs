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
            lammoi = new Button();
            them = new Button();
            Xoa = new Button();
            thoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(805, 328);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lammoi
            // 
            lammoi.Location = new Point(14, 16);
            lammoi.Margin = new Padding(3, 4, 3, 4);
            lammoi.Name = "lammoi";
            lammoi.Size = new Size(86, 31);
            lammoi.TabIndex = 1;
            lammoi.Text = "lam moi";
            lammoi.UseVisualStyleBackColor = true;
            lammoi.Click += lammoi_Click;
            // 
            // them
            // 
            them.Location = new Point(154, 16);
            them.Margin = new Padding(3, 4, 3, 4);
            them.Name = "them";
            them.Size = new Size(86, 31);
            them.TabIndex = 2;
            them.Text = "them";
            them.UseVisualStyleBackColor = true;
            them.Click += them_Click;
            // 
            // Xoa
            // 
            Xoa.Location = new Point(526, 16);
            Xoa.Margin = new Padding(3, 4, 3, 4);
            Xoa.Name = "Xoa";
            Xoa.Size = new Size(86, 31);
            Xoa.TabIndex = 3;
            Xoa.Text = "Xoa";
            Xoa.UseVisualStyleBackColor = true;
            Xoa.Click += Xoa_Click;
            // 
            // thoat
            // 
            thoat.Location = new Point(686, 16);
            thoat.Margin = new Padding(3, 4, 3, 4);
            thoat.Name = "thoat";
            thoat.Size = new Size(86, 31);
            thoat.TabIndex = 4;
            thoat.Text = "Thoat";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click;
            // 
            // ThongTinKH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(thoat);
            Controls.Add(Xoa);
            Controls.Add(them);
            Controls.Add(lammoi);
            Controls.Add(dataGridView1);
            Name = "ThongTinKH";
            Text = "ThongTinKH";
            Load += ThongTinKH_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button lammoi;
        private Button them;
        private Button Xoa;
        private Button thoat;
    }
}