namespace Lap1
{
    partial class Bai1
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
            this.txtSoN = new System.Windows.Forms.TextBox();
            this.txtSoM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btTru = new System.Windows.Forms.Button();
            this.btNhan = new System.Windows.Forms.Button();
            this.btChia = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btCong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(181, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỰC HIỆN CÁC PHÉP TÍNH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(106, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số n";
            // 
            // txtSoN
            // 
            this.txtSoN.Location = new System.Drawing.Point(243, 128);
            this.txtSoN.Name = "txtSoN";
            this.txtSoN.Size = new System.Drawing.Size(229, 27);
            this.txtSoN.TabIndex = 2;
            this.txtSoN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoN_KeyPress);
            // 
            // txtSoM
            // 
            this.txtSoM.Location = new System.Drawing.Point(243, 182);
            this.txtSoM.Name = "txtSoM";
            this.txtSoM.Size = new System.Drawing.Size(229, 27);
            this.txtSoM.TabIndex = 4;
            this.txtSoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoM_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(106, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập số m";
            // 
            // txtKQ
            // 
            this.txtKQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtKQ.Location = new System.Drawing.Point(243, 233);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.ReadOnly = true;
            this.txtKQ.Size = new System.Drawing.Size(229, 27);
            this.txtKQ.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(106, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kết quả";
            // 
            // btTru
            // 
            this.btTru.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btTru.Location = new System.Drawing.Point(163, 297);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(59, 32);
            this.btTru.TabIndex = 7;
            this.btTru.Text = "-";
            this.btTru.UseVisualStyleBackColor = true;
            this.btTru.Click += new System.EventHandler(this.btTru_Click);
            // 
            // btNhan
            // 
            this.btNhan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btNhan.Location = new System.Drawing.Point(239, 297);
            this.btNhan.Name = "btNhan";
            this.btNhan.Size = new System.Drawing.Size(59, 32);
            this.btNhan.TabIndex = 8;
            this.btNhan.Text = "*";
            this.btNhan.UseVisualStyleBackColor = true;
            this.btNhan.Click += new System.EventHandler(this.btNhan_Click);
            // 
            // btChia
            // 
            this.btChia.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btChia.Location = new System.Drawing.Point(314, 297);
            this.btChia.Name = "btChia";
            this.btChia.Size = new System.Drawing.Size(59, 32);
            this.btChia.TabIndex = 9;
            this.btChia.Text = "/";
            this.btChia.UseVisualStyleBackColor = true;
            this.btChia.Click += new System.EventHandler(this.btChia_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btXoa.Location = new System.Drawing.Point(395, 297);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(59, 32);
            this.btXoa.TabIndex = 10;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btThoat.Location = new System.Drawing.Point(475, 297);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(65, 32);
            this.btThoat.TabIndex = 11;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btCong
            // 
            this.btCong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btCong.Location = new System.Drawing.Point(92, 297);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(59, 32);
            this.btCong.TabIndex = 12;
            this.btCong.Text = "+";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btChia);
            this.Controls.Add(this.btNhan);
            this.Controls.Add(this.btTru);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai1";
            this.Text = "TÍNH TOÁN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSoN;
        private TextBox txtSoM;
        private Label label3;
        private TextBox txtKQ;
        private Label label4;
        private Button btTru;
        private Button btNhan;
        private Button btChia;
        private Button btXoa;
        private Button btThoat;
        private Button btCong;
    }
}