namespace Lab3
{
    partial class Form2
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
            this.cb_class = new System.Windows.Forms.ComboBox();
            this.dt_dob = new System.Windows.Forms.DateTimePicker();
            this.tx_point = new System.Windows.Forms.TextBox();
            this.tx_adress = new System.Windows.Forms.TextBox();
            this.tx_name = new System.Windows.Forms.TextBox();
            this.tx_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgv_student = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_student)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_class);
            this.groupBox1.Controls.Add(this.dt_dob);
            this.groupBox1.Controls.Add(this.tx_point);
            this.groupBox1.Controls.Add(this.tx_adress);
            this.groupBox1.Controls.Add(this.tx_name);
            this.groupBox1.Controls.Add(this.tx_id);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(96, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(817, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học sinh";
            // 
            // cb_class
            // 
            this.cb_class.FormattingEnabled = true;
            this.cb_class.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cb_class.Location = new System.Drawing.Point(180, 149);
            this.cb_class.Name = "cb_class";
            this.cb_class.Size = new System.Drawing.Size(192, 28);
            this.cb_class.TabIndex = 12;
            // 
            // dt_dob
            // 
            this.dt_dob.CustomFormat = "";
            this.dt_dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_dob.Location = new System.Drawing.Point(180, 99);
            this.dt_dob.Name = "dt_dob";
            this.dt_dob.Size = new System.Drawing.Size(192, 27);
            this.dt_dob.TabIndex = 11;
            // 
            // tx_point
            // 
            this.tx_point.Location = new System.Drawing.Point(558, 152);
            this.tx_point.Name = "tx_point";
            this.tx_point.Size = new System.Drawing.Size(192, 27);
            this.tx_point.TabIndex = 10;
            // 
            // tx_adress
            // 
            this.tx_adress.Location = new System.Drawing.Point(558, 101);
            this.tx_adress.Name = "tx_adress";
            this.tx_adress.Size = new System.Drawing.Size(192, 27);
            this.tx_adress.TabIndex = 9;
            // 
            // tx_name
            // 
            this.tx_name.Location = new System.Drawing.Point(558, 51);
            this.tx_name.Name = "tx_name";
            this.tx_name.Size = new System.Drawing.Size(192, 27);
            this.tx_name.TabIndex = 8;
            // 
            // tx_id
            // 
            this.tx_id.Location = new System.Drawing.Point(180, 51);
            this.tx_id.Name = "tx_id";
            this.tx_id.ReadOnly = true;
            this.tx_id.Size = new System.Drawing.Size(192, 27);
            this.tx_id.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Điểm TB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(429, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tên học sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã học sinh";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgv_student);
            this.groupBox2.Location = new System.Drawing.Point(96, 412);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(817, 313);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách học sinh";
            // 
            // dtgv_student
            // 
            this.dtgv_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_student.Location = new System.Drawing.Point(0, 26);
            this.dtgv_student.Name = "dtgv_student";
            this.dtgv_student.ReadOnly = true;
            this.dtgv_student.RowHeadersWidth = 51;
            this.dtgv_student.RowTemplate.Height = 29;
            this.dtgv_student.Size = new System.Drawing.Size(811, 281);
            this.dtgv_student.TabIndex = 0;
            this.dtgv_student.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_student_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_save);
            this.groupBox3.Controls.Add(this.bt_Exit);
            this.groupBox3.Controls.Add(this.bt_delete);
            this.groupBox3.Location = new System.Drawing.Point(96, 330);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(817, 52);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(493, 17);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(94, 29);
            this.bt_save.TabIndex = 2;
            this.bt_save.Text = "Lưu";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.Location = new System.Drawing.Point(707, 17);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(94, 29);
            this.bt_Exit.TabIndex = 1;
            this.bt_Exit.Text = "Thoát";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(593, 17);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(94, 29);
            this.bt_delete.TabIndex = 0;
            this.bt_delete.Text = "Xoá";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(244, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH SÁCH HỌC SINH";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 823);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_student)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cb_class;
        private DateTimePicker dt_dob;
        private TextBox tx_point;
        private TextBox tx_adress;
        private TextBox tx_name;
        private TextBox tx_id;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private DataGridView dtgv_student;
        private GroupBox groupBox3;
        private Button bt_save;
        private Button bt_Exit;
        private Button bt_delete;
        private Label label1;
    }
}