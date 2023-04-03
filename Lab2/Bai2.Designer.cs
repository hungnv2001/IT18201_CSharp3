namespace Lab2
{
    partial class Bai2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Bai1_name = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.MaskedTextBox();
            this.listMon1 = new System.Windows.Forms.ListBox();
            this.listMon2 = new System.Windows.Forms.ListBox();
            this.bt_SM_Bai2 = new System.Windows.Forms.Button();
            this.btn_Reset_Bai2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btNextAll = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btPrevAll = new System.Windows.Forms.Button();
            this.bt_Prev = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.MaskedTextBox();
            this.btn_Exit_bai2 = new System.Windows.Forms.Button();
            this.rtb_bai2 = new System.Windows.Forms.RichTextBox();
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
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(155, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Thể Thao";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Danh sách các môn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Danh sách đã được chọn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kết quả";
            // 
            // Bai1_name
            // 
            this.Bai1_name.FormattingEnabled = true;
            this.Bai1_name.Items.AddRange(new object[] {
            "Nguyễn Văn A",
            "Nguyễn Việt Hưng",
            "Nguyễn Việt Trung",
            "Nguyễn Khác Phúc"});
            this.Bai1_name.Location = new System.Drawing.Point(224, 141);
            this.Bai1_name.Name = "Bai1_name";
            this.Bai1_name.Size = new System.Drawing.Size(151, 28);
            this.Bai1_name.TabIndex = 7;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(177, 176);
            this.date.Mask = "00/00/0000";
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(125, 27);
            this.date.TabIndex = 8;
            this.date.ValidatingType = typeof(System.DateTime);
            // 
            // listMon1
            // 
            this.listMon1.FormattingEnabled = true;
            this.listMon1.ItemHeight = 20;
            this.listMon1.Items.AddRange(new object[] {
            "Bóng đá",
            "Bóng Bàn",
            "Cầu lông",
            "Bắn bi",
            "Nhảy dù",
            "Bập Bênh"});
            this.listMon1.Location = new System.Drawing.Point(97, 266);
            this.listMon1.Name = "listMon1";
            this.listMon1.Size = new System.Drawing.Size(150, 144);
            this.listMon1.TabIndex = 10;
            // 
            // listMon2
            // 
            this.listMon2.FormattingEnabled = true;
            this.listMon2.ItemHeight = 20;
            this.listMon2.Location = new System.Drawing.Point(350, 266);
            this.listMon2.Name = "listMon2";
            this.listMon2.Size = new System.Drawing.Size(150, 144);
            this.listMon2.TabIndex = 11;
            // 
            // bt_SM_Bai2
            // 
            this.bt_SM_Bai2.Location = new System.Drawing.Point(376, 478);
            this.bt_SM_Bai2.Name = "bt_SM_Bai2";
            this.bt_SM_Bai2.Size = new System.Drawing.Size(94, 29);
            this.bt_SM_Bai2.TabIndex = 13;
            this.bt_SM_Bai2.Text = "Nhập";
            this.bt_SM_Bai2.UseVisualStyleBackColor = true;
            this.bt_SM_Bai2.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Reset_Bai2
            // 
            this.btn_Reset_Bai2.Location = new System.Drawing.Point(376, 530);
            this.btn_Reset_Bai2.Name = "btn_Reset_Bai2";
            this.btn_Reset_Bai2.Size = new System.Drawing.Size(94, 29);
            this.btn_Reset_Bai2.TabIndex = 14;
            this.btn_Reset_Bai2.Text = "Reset";
            this.btn_Reset_Bai2.UseVisualStyleBackColor = true;
            this.btn_Reset_Bai2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(390, 551);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(8, 8);
            this.button3.TabIndex = 15;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btNextAll
            // 
            this.btNextAll.Location = new System.Drawing.Point(271, 266);
            this.btNextAll.Name = "btNextAll";
            this.btNextAll.Size = new System.Drawing.Size(40, 28);
            this.btNextAll.TabIndex = 16;
            this.btNextAll.Text = ">>";
            this.btNextAll.UseVisualStyleBackColor = true;
            this.btNextAll.Click += new System.EventHandler(this.button4_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(271, 304);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(40, 28);
            this.btNext.TabIndex = 17;
            this.btNext.Text = ">";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.button5_Click);
            // 
            // btPrevAll
            // 
            this.btPrevAll.Location = new System.Drawing.Point(271, 342);
            this.btPrevAll.Name = "btPrevAll";
            this.btPrevAll.Size = new System.Drawing.Size(40, 28);
            this.btPrevAll.TabIndex = 18;
            this.btPrevAll.Text = "<<";
            this.btPrevAll.UseVisualStyleBackColor = true;
            this.btPrevAll.Click += new System.EventHandler(this.button6_Click);
            // 
            // bt_Prev
            // 
            this.bt_Prev.Location = new System.Drawing.Point(270, 380);
            this.bt_Prev.Name = "bt_Prev";
            this.bt_Prev.Size = new System.Drawing.Size(40, 28);
            this.bt_Prev.TabIndex = 20;
            this.bt_Prev.Text = "<";
            this.bt_Prev.UseVisualStyleBackColor = true;
            this.bt_Prev.Click += new System.EventHandler(this.button8_Click);
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(383, 176);
            this.time.Mask = "00:00:00";
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(125, 27);
            this.time.TabIndex = 21;
            this.time.ValidatingType = typeof(System.DateTime);
            // 
            // btn_Exit_bai2
            // 
            this.btn_Exit_bai2.Location = new System.Drawing.Point(376, 578);
            this.btn_Exit_bai2.Name = "btn_Exit_bai2";
            this.btn_Exit_bai2.Size = new System.Drawing.Size(94, 29);
            this.btn_Exit_bai2.TabIndex = 23;
            this.btn_Exit_bai2.Text = "Thoát";
            this.btn_Exit_bai2.UseVisualStyleBackColor = true;
            this.btn_Exit_bai2.Click += new System.EventHandler(this.button7_Click);
            // 
            // rtb_bai2
            // 
            this.rtb_bai2.Location = new System.Drawing.Point(94, 479);
            this.rtb_bai2.Name = "rtb_bai2";
            this.rtb_bai2.Size = new System.Drawing.Size(203, 120);
            this.rtb_bai2.TabIndex = 24;
            this.rtb_bai2.Text = "";
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
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // bài1ToolStripMenuItem
            // 
            this.bài1ToolStripMenuItem.Name = "bài1ToolStripMenuItem";
            this.bài1ToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.bài1ToolStripMenuItem.Text = "Bài 1";
            this.bài1ToolStripMenuItem.Click += new System.EventHandler(this.bài1ToolStripMenuItem_Click_1);
            // 
            // bài2ToolStripMenuItem
            // 
            this.bài2ToolStripMenuItem.Name = "bài2ToolStripMenuItem";
            this.bài2ToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.bài2ToolStripMenuItem.Text = "Bài 2";
            this.bài2ToolStripMenuItem.Click += new System.EventHandler(this.bài2ToolStripMenuItem_Click_1);
            // 
            // bài3ToolStripMenuItem
            // 
            this.bài3ToolStripMenuItem.Name = "bài3ToolStripMenuItem";
            this.bài3ToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.bài3ToolStripMenuItem.Text = "Bài 3";
            this.bài3ToolStripMenuItem.Click += new System.EventHandler(this.bài3ToolStripMenuItem_Click_1);
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 653);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.rtb_bai2);
            this.Controls.Add(this.btn_Exit_bai2);
            this.Controls.Add(this.time);
            this.Controls.Add(this.bt_Prev);
            this.Controls.Add(this.btPrevAll);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btNextAll);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_Reset_Bai2);
            this.Controls.Add(this.bt_SM_Bai2);
            this.Controls.Add(this.listMon2);
            this.Controls.Add(this.listMon1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.Bai1_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai2";
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
        private ComboBox Bai1_name;
        private MaskedTextBox date;
        private ListBox listMon1;
        private ListBox listMon2;
        private Button bt_SM_Bai2;
        private Button btn_Reset_Bai2;
        private Button button3;
        private Button btNextAll;
        private Button btNext;
        private Button btPrevAll;
        private Button bt_Prev;
        private System.Windows.Forms.Timer timer1;
        private MaskedTextBox time;
        private Button btn_Exit_bai2;
        private RichTextBox rtb_bai2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem bài1ToolStripMenuItem;
        private ToolStripMenuItem bài2ToolStripMenuItem;
        private ToolStripMenuItem bài3ToolStripMenuItem;
    }
}