namespace BaoCaoCuoiKy
{
    partial class ChonGhe
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
            STKBox = new TextBox();
            fdfdf = new Label();
            dfdfdf = new Label();
            MatKhauBox = new TextBox();
            IdKHBox = new TextBox();
            IdKHBoxdfdfdf = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(67, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(678, 394);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // STKBox
            // 
            STKBox.Location = new Point(185, 64);
            STKBox.Name = "STKBox";
            STKBox.Size = new Size(129, 27);
            STKBox.TabIndex = 1;
            // 
            // fdfdf
            // 
            fdfdf.AutoSize = true;
            fdfdf.Location = new Point(76, 71);
            fdfdf.Name = "fdfdf";
            fdfdf.Size = new Size(91, 20);
            fdfdf.TabIndex = 2;
            fdfdf.Text = "Số tài khoản";
            // 
            // dfdfdf
            // 
            dfdfdf.AutoSize = true;
            dfdfdf.Location = new Point(97, 111);
            dfdfdf.Name = "dfdfdf";
            dfdfdf.Size = new Size(70, 20);
            dfdfdf.TabIndex = 2;
            dfdfdf.Text = "Mật khẩu";
            // 
            // MatKhauBox
            // 
            MatKhauBox.Location = new Point(185, 104);
            MatKhauBox.Name = "MatKhauBox";
            MatKhauBox.Size = new Size(129, 27);
            MatKhauBox.TabIndex = 1;
            // 
            // IdKHBox
            // 
            IdKHBox.Location = new Point(185, 16);
            IdKHBox.Name = "IdKHBox";
            IdKHBox.Size = new Size(129, 27);
            IdKHBox.TabIndex = 1;
            // 
            // IdKHBoxdfdfdf
            // 
            IdKHBoxdfdfdf.AutoSize = true;
            IdKHBoxdfdfdf.Location = new Point(76, 23);
            IdKHBoxdfdfdf.Name = "IdKHBoxdfdfdf";
            IdKHBoxdfdfdf.Size = new Size(101, 20);
            IdKHBoxdfdfdf.TabIndex = 2;
            IdKHBoxdfdfdf.Text = "Id khách hàng";
            // 
            // ChonGhe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 570);
            Controls.Add(dfdfdf);
            Controls.Add(IdKHBoxdfdfdf);
            Controls.Add(fdfdf);
            Controls.Add(MatKhauBox);
            Controls.Add(IdKHBox);
            Controls.Add(STKBox);
            Controls.Add(dataGridView1);
            Name = "ChonGhe";
            Text = "ChonGhe";
            Load += ChonGhe_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox STKBox;
        private Label fdfdf;
        private Label dfdfdf;
        private TextBox MatKhauBox;
        private TextBox IdKHBox;
        private Label IdKHBoxdfdfdf;
    }
}