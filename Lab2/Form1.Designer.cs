namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_ngoai = new System.Windows.Forms.TextBox();
            this.txt_cu = new System.Windows.Forms.TextBox();
            this.txt_moi = new System.Windows.Forms.TextBox();
            this.txt_dung = new System.Windows.Forms.TextBox();
            this.txt_trong = new System.Windows.Forms.TextBox();
            this.txt_tongTien = new System.Windows.Forms.TextBox();
            this.bt_Tinh = new System.Windows.Forms.Button();
            this.bt_In = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.txt_HoaDon = new System.Windows.Forms.TextBox();
            this.cm_name = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bài1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(155, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bảng Tính Tiền Điện";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chỉ số cũ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chỉ số mới:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số kw tiêu thụ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tổng tiền phải trả:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số kw trong định mức:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(307, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số kw vượt định mức:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Định mức là 50kw";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(307, 380);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(198, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Trong định mức là 500đ/1kw";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(307, 414);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Trong định mức là 500đ/1kw";
            // 
            // txt_ngoai
            // 
            this.txt_ngoai.Location = new System.Drawing.Point(472, 287);
            this.txt_ngoai.Name = "txt_ngoai";
            this.txt_ngoai.ReadOnly = true;
            this.txt_ngoai.Size = new System.Drawing.Size(40, 27);
            this.txt_ngoai.TabIndex = 11;
            // 
            // txt_cu
            // 
            this.txt_cu.Location = new System.Drawing.Point(206, 243);
            this.txt_cu.Name = "txt_cu";
            this.txt_cu.Size = new System.Drawing.Size(44, 27);
            this.txt_cu.TabIndex = 12;
            // 
            // txt_moi
            // 
            this.txt_moi.Location = new System.Drawing.Point(206, 284);
            this.txt_moi.Name = "txt_moi";
            this.txt_moi.Size = new System.Drawing.Size(44, 27);
            this.txt_moi.TabIndex = 13;
            // 
            // txt_dung
            // 
            this.txt_dung.Location = new System.Drawing.Point(206, 320);
            this.txt_dung.Name = "txt_dung";
            this.txt_dung.ReadOnly = true;
            this.txt_dung.Size = new System.Drawing.Size(44, 27);
            this.txt_dung.TabIndex = 14;
            // 
            // txt_trong
            // 
            this.txt_trong.Location = new System.Drawing.Point(470, 240);
            this.txt_trong.Name = "txt_trong";
            this.txt_trong.ReadOnly = true;
            this.txt_trong.Size = new System.Drawing.Size(42, 27);
            this.txt_trong.TabIndex = 15;
            // 
            // txt_tongTien
            // 
            this.txt_tongTien.Location = new System.Drawing.Point(67, 424);
            this.txt_tongTien.Name = "txt_tongTien";
            this.txt_tongTien.Size = new System.Drawing.Size(183, 27);
            this.txt_tongTien.TabIndex = 16;
            // 
            // bt_Tinh
            // 
            this.bt_Tinh.Location = new System.Drawing.Point(67, 466);
            this.bt_Tinh.Name = "bt_Tinh";
            this.bt_Tinh.Size = new System.Drawing.Size(78, 30);
            this.bt_Tinh.TabIndex = 17;
            this.bt_Tinh.Text = "Tính";
            this.bt_Tinh.UseVisualStyleBackColor = true;
            this.bt_Tinh.Click += new System.EventHandler(this.bt_Tinh_Click);
            // 
            // bt_In
            // 
            this.bt_In.Location = new System.Drawing.Point(181, 466);
            this.bt_In.Name = "bt_In";
            this.bt_In.Size = new System.Drawing.Size(78, 30);
            this.bt_In.TabIndex = 18;
            this.bt_In.Text = "In";
            this.bt_In.UseVisualStyleBackColor = true;
            this.bt_In.Click += new System.EventHandler(this.bt_In_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.Location = new System.Drawing.Point(136, 522);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(78, 30);
            this.bt_Exit.TabIndex = 19;
            this.bt_Exit.Text = "Thoát";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // txt_HoaDon
            // 
            this.txt_HoaDon.Location = new System.Drawing.Point(286, 461);
            this.txt_HoaDon.Multiline = true;
            this.txt_HoaDon.Name = "txt_HoaDon";
            this.txt_HoaDon.Size = new System.Drawing.Size(226, 91);
            this.txt_HoaDon.TabIndex = 20;
            // 
            // cm_name
            // 
            this.cm_name.FormattingEnabled = true;
            this.cm_name.Items.AddRange(new object[] {
            "Nguyễn Văn A",
            "Nguyễn Việt Hưng",
            "Nguyễn Việt Trung",
            "Nguyễn Khác Phúc"});
            this.cm_name.Location = new System.Drawing.Point(220, 189);
            this.cm_name.Name = "cm_name";
            this.cm_name.Size = new System.Drawing.Size(244, 28);
            this.cm_name.TabIndex = 21;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bài1ToolStripMenuItem,
            this.bài2ToolStripMenuItem,
            this.bài3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 28);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bài1ToolStripMenuItem
            // 
            this.bài1ToolStripMenuItem.Name = "bài1ToolStripMenuItem";
            this.bài1ToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.bài1ToolStripMenuItem.Text = "Bài 1";
            this.bài1ToolStripMenuItem.Click += new System.EventHandler(this.bài1ToolStripMenuItem_Click);
            // 
            // bài2ToolStripMenuItem
            // 
            this.bài2ToolStripMenuItem.Name = "bài2ToolStripMenuItem";
            this.bài2ToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.bài2ToolStripMenuItem.Text = "Bài 2";
            this.bài2ToolStripMenuItem.Click += new System.EventHandler(this.bài2ToolStripMenuItem_Click);
            // 
            // bài3ToolStripMenuItem
            // 
            this.bài3ToolStripMenuItem.Name = "bài3ToolStripMenuItem";
            this.bài3ToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.bài3ToolStripMenuItem.Text = "Bài 3";
            this.bài3ToolStripMenuItem.Click += new System.EventHandler(this.bài3ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(582, 653);
            this.Controls.Add(this.cm_name);
            this.Controls.Add(this.txt_HoaDon);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.bt_In);
            this.Controls.Add(this.bt_Tinh);
            this.Controls.Add(this.txt_tongTien);
            this.Controls.Add(this.txt_trong);
            this.Controls.Add(this.txt_dung);
            this.Controls.Add(this.txt_moi);
            this.Controls.Add(this.txt_cu);
            this.Controls.Add(this.txt_ngoai);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txt_ngoai;
        private TextBox txt_cu;
        private TextBox txt_moi;
        private TextBox txt_dung;
        private TextBox txt_trong;
        private TextBox txt_tongTien;
        private Button bt_Tinh;
        private Button bt_In;
        private Button bt_Exit;
        private TextBox txt_HoaDon;
        private ComboBox cm_name;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem bài1ToolStripMenuItem;
        private ToolStripMenuItem bài2ToolStripMenuItem;
        private ToolStripMenuItem bài3ToolStripMenuItem;
    }
}