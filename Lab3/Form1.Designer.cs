namespace Lab3
{
    partial class bt_delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bt_delete));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_class = new System.Windows.Forms.ComboBox();
            this.dt_DOB = new System.Windows.Forms.DateTimePicker();
            this.tx_id = new System.Windows.Forms.TextBox();
            this.tx_point = new System.Windows.Forms.TextBox();
            this.tx_adress = new System.Windows.Forms.TextBox();
            this.tx_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_Save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(105, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH HỌC SINH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_class);
            this.groupBox1.Controls.Add(this.dt_DOB);
            this.groupBox1.Controls.Add(this.tx_id);
            this.groupBox1.Controls.Add(this.tx_point);
            this.groupBox1.Controls.Add(this.tx_adress);
            this.groupBox1.Controls.Add(this.tx_name);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(57, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 291);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học sinh";
            // 
            // cb_class
            // 
            this.cb_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_class.FormattingEnabled = true;
            this.cb_class.Location = new System.Drawing.Point(208, 193);
            this.cb_class.Name = "cb_class";
            this.cb_class.Size = new System.Drawing.Size(297, 28);
            this.cb_class.TabIndex = 8;
            // 
            // dt_DOB
            // 
            this.dt_DOB.CustomFormat = "dd/MM/yyyy";
            this.dt_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_DOB.Location = new System.Drawing.Point(208, 122);
            this.dt_DOB.Name = "dt_DOB";
            this.dt_DOB.Size = new System.Drawing.Size(297, 27);
            this.dt_DOB.TabIndex = 7;
            // 
            // tx_id
            // 
            this.tx_id.Location = new System.Drawing.Point(208, 51);
            this.tx_id.Name = "tx_id";
            this.tx_id.Size = new System.Drawing.Size(297, 27);
            this.tx_id.TabIndex = 6;
            // 
            // tx_point
            // 
            this.tx_point.Location = new System.Drawing.Point(208, 227);
            this.tx_point.Name = "tx_point";
            this.tx_point.Size = new System.Drawing.Size(297, 27);
            this.tx_point.TabIndex = 5;
            // 
            // tx_adress
            // 
            this.tx_adress.Location = new System.Drawing.Point(208, 155);
            this.tx_adress.Name = "tx_adress";
            this.tx_adress.Size = new System.Drawing.Size(297, 27);
            this.tx_adress.TabIndex = 3;
            // 
            // tx_name
            // 
            this.tx_name.Location = new System.Drawing.Point(208, 84);
            this.tx_name.Name = "tx_name";
            this.tx_name.Size = new System.Drawing.Size(297, 27);
            this.tx_name.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(48, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Điểm TB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(48, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lớp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(48, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(48, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(48, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên học sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(48, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã học sinh";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(421, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Xoá";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Image = ((System.Drawing.Image)(resources.GetObject("bt_exit.Image")));
            this.bt_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_exit.Location = new System.Drawing.Point(545, 429);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(94, 51);
            this.bt_exit.TabIndex = 2;
            this.bt_exit.Text = "Thoát";
            this.bt_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_Save
            // 
            this.bt_Save.Image = ((System.Drawing.Image)(resources.GetObject("bt_Save.Image")));
            this.bt_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Save.Location = new System.Drawing.Point(295, 429);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(94, 51);
            this.bt_Save.TabIndex = 2;
            this.bt_Save.Text = "Lưu";
            this.bt_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // bt_delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 492);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "bt_delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH HỌC SINH";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.bt_delete_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cb_class;
        private DateTimePicker dt_DOB;
        private TextBox tx_id;
        private TextBox tx_point;
        private TextBox tx_adress;
        private TextBox tx_name;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private Button bt_exit;
        private Button bt_Save;
    }
}