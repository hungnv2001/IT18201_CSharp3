namespace Lap1
{
    partial class Bai3
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbt_pt2 = new System.Windows.Forms.RadioButton();
            this.rbt_pt1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.bt_Submit = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(128, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giải Phương Trình";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbt_pt2);
            this.groupBox1.Controls.Add(this.rbt_pt1);
            this.groupBox1.Location = new System.Drawing.Point(43, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 113);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bạn vui lòng chọn";
            // 
            // rbt_pt2
            // 
            this.rbt_pt2.AutoSize = true;
            this.rbt_pt2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbt_pt2.Location = new System.Drawing.Point(63, 73);
            this.rbt_pt2.Name = "rbt_pt2";
            this.rbt_pt2.Size = new System.Drawing.Size(195, 24);
            this.rbt_pt2.TabIndex = 1;
            this.rbt_pt2.TabStop = true;
            this.rbt_pt2.Text = "Giải phương trình bậc 2";
            this.rbt_pt2.UseVisualStyleBackColor = true;
            this.rbt_pt2.CheckedChanged += new System.EventHandler(this.rbt_pt2_CheckedChanged);
            // 
            // rbt_pt1
            // 
            this.rbt_pt1.AutoSize = true;
            this.rbt_pt1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbt_pt1.Location = new System.Drawing.Point(63, 34);
            this.rbt_pt1.Name = "rbt_pt1";
            this.rbt_pt1.Size = new System.Drawing.Size(195, 24);
            this.rbt_pt1.TabIndex = 0;
            this.rbt_pt1.TabStop = true;
            this.rbt_pt1.Text = "Giải phương trình bậc 1";
            this.rbt_pt1.UseVisualStyleBackColor = true;
            this.rbt_pt1.CheckedChanged += new System.EventHandler(this.rbt_pt1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(27, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhập b";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(27, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nhập c";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(27, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Kết quả";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(112, 254);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(125, 27);
            this.txtA.TabIndex = 7;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_KeyPress);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(112, 296);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(125, 27);
            this.txtB.TabIndex = 8;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(112, 343);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(125, 27);
            this.txtC.TabIndex = 9;
            // 
            // txtKQ
            // 
            this.txtKQ.Enabled = false;
            this.txtKQ.Location = new System.Drawing.Point(112, 384);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.ReadOnly = true;
            this.txtKQ.Size = new System.Drawing.Size(322, 27);
            this.txtKQ.TabIndex = 10;
            // 
            // bt_Submit
            // 
            this.bt_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_Submit.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Submit.Location = new System.Drawing.Point(308, 257);
            this.bt_Submit.Name = "bt_Submit";
            this.bt_Submit.Size = new System.Drawing.Size(94, 77);
            this.bt_Submit.TabIndex = 11;
            this.bt_Submit.Text = "Giải";
            this.bt_Submit.UseVisualStyleBackColor = false;
            this.bt_Submit.Click += new System.EventHandler(this.bt_Submit_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.Location = new System.Drawing.Point(308, 344);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(94, 29);
            this.bt_Exit.TabIndex = 12;
            this.bt_Exit.Text = "Thoát";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 446);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.bt_Submit);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rbt_pt2;
        private RadioButton rbt_pt1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private TextBox txtKQ;
        private Button bt_Submit;
        private Button bt_Exit;
    }
}