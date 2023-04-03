namespace Lap1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbbt_BC = new System.Windows.Forms.RadioButton();
            this.rbbt_UC = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.bt_Submit = new System.Windows.Forms.Button();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(117, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Controls.Add(this.rbbt_BC);
            this.groupBox2.Controls.Add(this.rbbt_UC);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(439, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 134);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn tìm";
            // 
            // rbbt_BC
            // 
            this.rbbt_BC.AutoSize = true;
            this.rbbt_BC.Location = new System.Drawing.Point(33, 80);
            this.rbbt_BC.Name = "rbbt_BC";
            this.rbbt_BC.Size = new System.Drawing.Size(73, 24);
            this.rbbt_BC.TabIndex = 5;
            this.rbbt_BC.Text = "BCNN";
            this.rbbt_BC.UseVisualStyleBackColor = true;
            // 
            // rbbt_UC
            // 
            this.rbbt_UC.AllowDrop = true;
            this.rbbt_UC.AutoSize = true;
            this.rbbt_UC.Location = new System.Drawing.Point(33, 39);
            this.rbbt_UC.Name = "rbbt_UC";
            this.rbbt_UC.Size = new System.Drawing.Size(70, 24);
            this.rbbt_UC.TabIndex = 4;
            this.rbbt_UC.Text = "UCLN";
            this.rbbt_UC.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox3.Controls.Add(this.bt_Exit);
            this.groupBox3.Controls.Add(this.bt_Clear);
            this.groupBox3.Controls.Add(this.bt_Submit);
            this.groupBox3.Controls.Add(this.txtKQ);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(43, 233);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(590, 102);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả";
            // 
            // bt_Exit
            // 
            this.bt_Exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_Exit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bt_Exit.Location = new System.Drawing.Point(429, 67);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_Exit.Size = new System.Drawing.Size(94, 29);
            this.bt_Exit.TabIndex = 3;
            this.bt_Exit.Text = "Thoát";
            this.bt_Exit.UseVisualStyleBackColor = false;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // bt_Clear
            // 
            this.bt_Clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_Clear.Location = new System.Drawing.Point(254, 67);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(94, 29);
            this.bt_Clear.TabIndex = 2;
            this.bt_Clear.Text = "Bỏ qua";
            this.bt_Clear.UseVisualStyleBackColor = false;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // bt_Submit
            // 
            this.bt_Submit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_Submit.Location = new System.Drawing.Point(74, 67);
            this.bt_Submit.Name = "bt_Submit";
            this.bt_Submit.Size = new System.Drawing.Size(94, 29);
            this.bt_Submit.TabIndex = 1;
            this.bt_Submit.Text = "Tìm";
            this.bt_Submit.UseVisualStyleBackColor = false;
            this.bt_Submit.Click += new System.EventHandler(this.bt_Submit_Click);
            // 
            // txtKQ
            // 
            this.txtKQ.BackColor = System.Drawing.SystemColors.Info;
            this.txtKQ.Location = new System.Drawing.Point(74, 26);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.ReadOnly = true;
            this.txtKQ.Size = new System.Drawing.Size(300, 27);
            this.txtKQ.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox4.Controls.Add(this.txtB);
            this.groupBox4.Controls.Add(this.txtA);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(43, 70);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(366, 134);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nhập";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(74, 82);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(218, 27);
            this.txtB.TabIndex = 3;
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(74, 39);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(218, 27);
            this.txtA.TabIndex = 2;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "B:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "A:";
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(716, 368);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label2;
        private Label label1;
        private Button bt_Exit;
        private Button bt_Clear;
        private Button bt_Submit;
        private TextBox txtKQ;
        private TextBox txtB;
        private TextBox txtA;
        private RadioButton rbbt_BC;
        private RadioButton rbbt_UC;
    }
}