namespace Lab4
{
    partial class Lab4_hungnv
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_insert = new System.Windows.Forms.Button();
            this.bt_get = new System.Windows.Forms.Button();
            this.bt_Sort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(457, 510);
            this.dataGridView1.TabIndex = 11;
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(494, 228);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(94, 44);
            this.bt_delete.TabIndex = 10;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(494, 163);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(94, 44);
            this.bt_update.TabIndex = 9;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_insert
            // 
            this.bt_insert.Location = new System.Drawing.Point(494, 98);
            this.bt_insert.Name = "bt_insert";
            this.bt_insert.Size = new System.Drawing.Size(94, 44);
            this.bt_insert.TabIndex = 8;
            this.bt_insert.Text = "Insert";
            this.bt_insert.UseVisualStyleBackColor = true;
            this.bt_insert.Click += new System.EventHandler(this.bt_insert_Click);
            // 
            // bt_get
            // 
            this.bt_get.Location = new System.Drawing.Point(494, 33);
            this.bt_get.Name = "bt_get";
            this.bt_get.Size = new System.Drawing.Size(94, 44);
            this.bt_get.TabIndex = 7;
            this.bt_get.Text = "GetData";
            this.bt_get.UseVisualStyleBackColor = true;
            this.bt_get.Click += new System.EventHandler(this.bt_get_Click);
            // 
            // bt_Sort
            // 
            this.bt_Sort.Location = new System.Drawing.Point(494, 290);
            this.bt_Sort.Name = "bt_Sort";
            this.bt_Sort.Size = new System.Drawing.Size(94, 46);
            this.bt_Sort.TabIndex = 12;
            this.bt_Sort.Text = "Sort";
            this.bt_Sort.UseVisualStyleBackColor = true;
            this.bt_Sort.Click += new System.EventHandler(this.bt_Sort_Click);
            // 
            // Lab4_hungnv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 565);
            this.Controls.Add(this.bt_Sort);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_insert);
            this.Controls.Add(this.bt_get);
            this.Name = "Lab4_hungnv";
            this.Text = "Lab4_hungnv";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button bt_delete;
        private Button bt_update;
        private Button bt_insert;
        private Button bt_get;
        private Button bt_Sort;
    }
}