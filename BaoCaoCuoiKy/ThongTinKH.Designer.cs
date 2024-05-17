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
            dataGridView1.Location = new Point(2, 97);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(704, 246);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lammoi
            // 
            lammoi.Location = new Point(12, 12);
            lammoi.Name = "lammoi";
            lammoi.Size = new Size(75, 23);
            lammoi.TabIndex = 1;
            lammoi.Text = "lam moi";
            lammoi.UseVisualStyleBackColor = true;
            lammoi.Click += lammoi_Click;
            // 
            // them
            // 
            them.Location = new Point(135, 12);
            them.Name = "them";
            them.Size = new Size(75, 23);
            them.TabIndex = 2;
            them.Text = "them";
            them.UseVisualStyleBackColor = true;
            them.Click += them_Click;
            // 
            // Xoa
            // 
            Xoa.Location = new Point(460, 12);
            Xoa.Name = "Xoa";
            Xoa.Size = new Size(75, 23);
            Xoa.TabIndex = 3;
            Xoa.Text = "Xoa";
            Xoa.UseVisualStyleBackColor = true;
            Xoa.Click += Xoa_Click;
            // 
            // thoat
            // 
            thoat.Location = new Point(600, 12);
            thoat.Name = "thoat";
            thoat.Size = new Size(75, 23);
            thoat.TabIndex = 4;
            thoat.Text = "Thoat";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click;
            // 
            // ThongTinKH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(thoat);
            Controls.Add(Xoa);
            Controls.Add(them);
            Controls.Add(lammoi);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ThongTinKH";
            Text = "ThongTinKH";
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