﻿namespace BaoCaoCuoiKy
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 9);
            label1.Name = "label1";
            label1.Size = new Size(242, 15);
            label1.TabIndex = 0;
            label1.Text = "Nguoi dung nhap thong tin ca nhan vao day";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 49);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 0;
            label2.Text = "ten khach hang";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 86);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 0;
            label3.Text = "Tuoi";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(156, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(156, 78);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(244, 23);
            textBox2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 121);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Dia chi";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(156, 113);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(244, 23);
            textBox3.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 155);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 5;
            label5.Text = "Thong tin lien lac";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(156, 147);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(244, 23);
            textBox4.TabIndex = 6;
            // 
            // ThongTinKH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ThongTinKH";
            Text = "ThongTinKH";
            Load += ThongTinKH_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
    }
}