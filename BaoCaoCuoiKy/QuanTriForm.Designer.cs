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
            menuStrip1 = new MenuStrip();
            ThemChuyenBayBtn = new ToolStripMenuItem();
            XoaChuyenBayBtn = new ToolStripMenuItem();
            TimChuyenBayBtn = new ToolStripMenuItem();
            Grid1 = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ThemChuyenBayBtn, XoaChuyenBayBtn, TimChuyenBayBtn });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1054, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // ThemChuyenBayBtn
            // 
            ThemChuyenBayBtn.Name = "ThemChuyenBayBtn";
            ThemChuyenBayBtn.Size = new Size(138, 24);
            ThemChuyenBayBtn.Text = "Thêm chuyến bay";
            ThemChuyenBayBtn.Click += ThemChuyenBayBtn_Click;
            // 
            // XoaChuyenBayBtn
            // 
            XoaChuyenBayBtn.Name = "XoaChuyenBayBtn";
            XoaChuyenBayBtn.Size = new Size(127, 24);
            XoaChuyenBayBtn.Text = "Xóa chuyến bay";
            // 
            // TimChuyenBayBtn
            // 
            TimChuyenBayBtn.Name = "TimChuyenBayBtn";
            TimChuyenBayBtn.Size = new Size(126, 24);
            TimChuyenBayBtn.Text = "Tìm chuyến bay";
            // 
            // Grid1
            // 
            Grid1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid1.Location = new Point(1, 48);
            Grid1.Name = "Grid1";
            Grid1.RowHeadersWidth = 51;
            Grid1.Size = new Size(1041, 537);
            Grid1.TabIndex = 3;
            Grid1.CellContentClick += Grid1_CellContentClick;
            // 
            // QuanTriForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 616);
            Controls.Add(Grid1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "QuanTriForm";
            Text = "QuanTriForm";
            Load += QuanTriForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Grid1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ThemChuyenBayBtn;
        private ToolStripMenuItem XoaChuyenBayBtn;
        private ToolStripMenuItem TimChuyenBayBtn;
        private Label label7;
        private Label label9;
        private Label label8;
        private TextBox textBox10;
        private DataGridView Grid1;
    }
}