namespace Demo5
{
    partial class Test
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
            this.tx_name = new System.Windows.Forms.TextBox();
            this.dtgv_student = new System.Windows.Forms.DataGridView();
            this.bt_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_student)).BeginInit();
            this.SuspendLayout();
            // 
            // tx_name
            // 
            this.tx_name.Location = new System.Drawing.Point(62, 62);
            this.tx_name.Multiline = true;
            this.tx_name.Name = "tx_name";
            this.tx_name.Size = new System.Drawing.Size(243, 42);
            this.tx_name.TabIndex = 0;
            // 
            // dtgv_student
            // 
            this.dtgv_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_student.Location = new System.Drawing.Point(39, 163);
            this.dtgv_student.Name = "dtgv_student";
            this.dtgv_student.RowHeadersWidth = 51;
            this.dtgv_student.RowTemplate.Height = 24;
            this.dtgv_student.Size = new System.Drawing.Size(571, 235);
            this.dtgv_student.TabIndex = 1;
            // 
            // bt_Close
            // 
            this.bt_Close.Location = new System.Drawing.Point(665, 362);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(75, 36);
            this.bt_Close.TabIndex = 2;
            this.bt_Close.Text = "Đóng";
            this.bt_Close.UseVisualStyleBackColor = true;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.dtgv_student);
            this.Controls.Add(this.tx_name);
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_name;
        private System.Windows.Forms.DataGridView dtgv_student;
        private System.Windows.Forms.Button bt_Close;
    }
}