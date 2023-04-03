namespace Bai5
{
    partial class Form1
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
            this.dtgv_student = new System.Windows.Forms.DataGridView();
            this.lb_name = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_name = new System.Windows.Forms.TextBox();
            this.tx_age = new System.Windows.Forms.TextBox();
            this.tx_city = new System.Windows.Forms.TextBox();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_student)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_student
            // 
            this.dtgv_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_student.Location = new System.Drawing.Point(25, 359);
            this.dtgv_student.Name = "dtgv_student";
            this.dtgv_student.RowHeadersWidth = 51;
            this.dtgv_student.RowTemplate.Height = 24;
            this.dtgv_student.Size = new System.Drawing.Size(571, 214);
            this.dtgv_student.TabIndex = 4;
            this.dtgv_student.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_student_CellClick);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(73, 126);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(44, 16);
            this.lb_name.TabIndex = 5;
            this.lb_name.Text = "Name";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(85, 177);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(32, 16);
            this.l2.TabIndex = 6;
            this.l2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gender";
            // 
            // tx_name
            // 
            this.tx_name.Location = new System.Drawing.Point(160, 120);
            this.tx_name.Name = "tx_name";
            this.tx_name.Size = new System.Drawing.Size(166, 22);
            this.tx_name.TabIndex = 9;
            // 
            // tx_age
            // 
            this.tx_age.Location = new System.Drawing.Point(160, 169);
            this.tx_age.Name = "tx_age";
            this.tx_age.Size = new System.Drawing.Size(166, 22);
            this.tx_age.TabIndex = 10;
            // 
            // tx_city
            // 
            this.tx_city.Location = new System.Drawing.Point(160, 227);
            this.tx_city.Name = "tx_city";
            this.tx_city.Size = new System.Drawing.Size(166, 22);
            this.tx_city.TabIndex = 11;
            // 
            // cb_gender
            // 
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_gender.Location = new System.Drawing.Point(160, 272);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(166, 24);
            this.cb_gender.TabIndex = 12;
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.Green;
            this.bt_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_save.Location = new System.Drawing.Point(467, 140);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 28);
            this.bt_save.TabIndex = 13;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = false;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_update
            // 
            this.bt_update.BackColor = System.Drawing.Color.Green;
            this.bt_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_update.Location = new System.Drawing.Point(467, 194);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(75, 28);
            this.bt_update.TabIndex = 13;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = false;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.Color.Green;
            this.bt_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_delete.Location = new System.Drawing.Point(467, 248);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(75, 28);
            this.bt_delete.TabIndex = 13;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(755, 67);
            this.label1.TabIndex = 14;
            this.label1.Text = "       Student Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(485, 28);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(44, 16);
            this.lb_id.TabIndex = 15;
            this.lb_id.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 631);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.cb_gender);
            this.Controls.Add(this.tx_city);
            this.Controls.Add(this.tx_age);
            this.Controls.Add(this.tx_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.dtgv_student);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgv_student;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_name;
        private System.Windows.Forms.TextBox tx_age;
        private System.Windows.Forms.TextBox tx_city;
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_id;
    }
}

