namespace BaoCaoCuoiKy
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
            Grid1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            idChuyenBayBox = new TextBox();
            noiKhoiHanhCb = new ComboBox();
            noiHaCanhCb = new ComboBox();
            giaVeBox = new TextBox();
            locBtn = new Button();
            tatCaBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)Grid1).BeginInit();
            SuspendLayout();
            // 
            // Grid1
            // 
            Grid1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid1.Location = new Point(1, 90);
            Grid1.Name = "Grid1";
            Grid1.RowHeadersWidth = 51;
            Grid1.Size = new Size(1041, 495);
            Grid1.TabIndex = 3;
            Grid1.CellContentClick += Grid1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 4;
            label1.Text = "Id chuyến bay";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 9);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 4;
            label2.Text = "Nơi khởi hành";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(458, 9);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 4;
            label3.Text = "Nơi hạ cánh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(676, 9);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 4;
            label4.Text = "Giá vé";
            // 
            // idChuyenBayBox
            // 
            idChuyenBayBox.Location = new Point(22, 36);
            idChuyenBayBox.Name = "idChuyenBayBox";
            idChuyenBayBox.Size = new Size(123, 27);
            idChuyenBayBox.TabIndex = 5;
            // 
            // noiKhoiHanhCb
            // 
            noiKhoiHanhCb.FormattingEnabled = true;
            noiKhoiHanhCb.Location = new Point(240, 36);
            noiKhoiHanhCb.Name = "noiKhoiHanhCb";
            noiKhoiHanhCb.Size = new Size(123, 28);
            noiKhoiHanhCb.TabIndex = 6;
            // 
            // noiHaCanhCb
            // 
            noiHaCanhCb.FormattingEnabled = true;
            noiHaCanhCb.Location = new Point(458, 36);
            noiHaCanhCb.Name = "noiHaCanhCb";
            noiHaCanhCb.Size = new Size(123, 28);
            noiHaCanhCb.TabIndex = 7;
            // 
            // giaVeBox
            // 
            giaVeBox.Location = new Point(676, 36);
            giaVeBox.Name = "giaVeBox";
            giaVeBox.Size = new Size(123, 27);
            giaVeBox.TabIndex = 5;
            // 
            // locBtn
            // 
            locBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            locBtn.Location = new Point(843, 28);
            locBtn.Name = "locBtn";
            locBtn.Size = new Size(76, 35);
            locBtn.TabIndex = 8;
            locBtn.Text = "Lọc";
            locBtn.UseVisualStyleBackColor = true;
            locBtn.Click += button1_Click;
            // 
            // tatCaBtn
            // 
            tatCaBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tatCaBtn.Location = new Point(950, 28);
            tatCaBtn.Name = "tatCaBtn";
            tatCaBtn.Size = new Size(76, 35);
            tatCaBtn.TabIndex = 8;
            tatCaBtn.Text = "Tất cả";
            tatCaBtn.UseVisualStyleBackColor = true;
            tatCaBtn.Click += button2_Click;
            // 
            // QuanTriForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 616);
            Controls.Add(tatCaBtn);
            Controls.Add(locBtn);
            Controls.Add(noiHaCanhCb);
            Controls.Add(noiKhoiHanhCb);
            Controls.Add(giaVeBox);
            Controls.Add(idChuyenBayBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Grid1);
            Name = "QuanTriForm";
            Text = "QuanTriForm";
            Load += QuanTriForm_Load;
            ((System.ComponentModel.ISupportInitialize)Grid1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private Label label9;
        private Label label8;
        private TextBox textBox10;
        private DataGridView Grid1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox idChuyenBayBox;
        private ComboBox noiKhoiHanhCb;
        private ComboBox noiHaCanhCb;
        private TextBox giaVeBox;
        private Button locBtn;
        private Button tatCaBtn;
    }
}