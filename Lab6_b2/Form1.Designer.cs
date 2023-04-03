namespace Lab6_b2
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
            this.bt_cancel = new System.Windows.Forms.Button();
            this.Bt_delete = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.dtgv_book = new System.Windows.Forms.DataGridView();
            this.tx_amount = new System.Windows.Forms.TextBox();
            this.tx_price = new System.Windows.Forms.TextBox();
            this.tx_name = new System.Windows.Forms.TextBox();
            this.tx_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cm_catagory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_book)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_cancel
            // 
            this.bt_cancel.Enabled = false;
            this.bt_cancel.Location = new System.Drawing.Point(583, 443);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(91, 32);
            this.bt_cancel.TabIndex = 25;
            this.bt_cancel.Text = "Bỏ qua";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // Bt_delete
            // 
            this.Bt_delete.Enabled = false;
            this.Bt_delete.Location = new System.Drawing.Point(445, 443);
            this.Bt_delete.Name = "Bt_delete";
            this.Bt_delete.Size = new System.Drawing.Size(91, 32);
            this.Bt_delete.TabIndex = 24;
            this.Bt_delete.Text = "Xoá";
            this.Bt_delete.UseVisualStyleBackColor = true;
            this.Bt_delete.Click += new System.EventHandler(this.Bt_delete_Click);
            // 
            // bt_save
            // 
            this.bt_save.Enabled = false;
            this.bt_save.Location = new System.Drawing.Point(307, 443);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(91, 32);
            this.bt_save.TabIndex = 23;
            this.bt_save.Text = "Lưu";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_add
            // 
            this.bt_add.Enabled = false;
            this.bt_add.Location = new System.Drawing.Point(169, 443);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(91, 32);
            this.bt_add.TabIndex = 22;
            this.bt_add.Text = "Thêm mới";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // dtgv_book
            // 
            this.dtgv_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_book.Location = new System.Drawing.Point(36, 170);
            this.dtgv_book.Name = "dtgv_book";
            this.dtgv_book.RowHeadersWidth = 51;
            this.dtgv_book.RowTemplate.Height = 24;
            this.dtgv_book.Size = new System.Drawing.Size(761, 239);
            this.dtgv_book.TabIndex = 21;
            this.dtgv_book.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_book_CellClick);
            // 
            // tx_amount
            // 
            this.tx_amount.Location = new System.Drawing.Point(571, 116);
            this.tx_amount.Name = "tx_amount";
            this.tx_amount.ReadOnly = true;
            this.tx_amount.Size = new System.Drawing.Size(226, 22);
            this.tx_amount.TabIndex = 20;
            // 
            // tx_price
            // 
            this.tx_price.Location = new System.Drawing.Point(571, 76);
            this.tx_price.Name = "tx_price";
            this.tx_price.ReadOnly = true;
            this.tx_price.Size = new System.Drawing.Size(226, 22);
            this.tx_price.TabIndex = 19;
            // 
            // tx_name
            // 
            this.tx_name.Location = new System.Drawing.Point(119, 112);
            this.tx_name.Name = "tx_name";
            this.tx_name.ReadOnly = true;
            this.tx_name.Size = new System.Drawing.Size(255, 22);
            this.tx_name.TabIndex = 18;
            // 
            // tx_id
            // 
            this.tx_id.Location = new System.Drawing.Point(119, 69);
            this.tx_id.Name = "tx_id";
            this.tx_id.ReadOnly = true;
            this.tx_id.Size = new System.Drawing.Size(255, 22);
            this.tx_id.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tiêu đề";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã sách";
            // 
            // cm_catagory
            // 
            this.cm_catagory.Enabled = false;
            this.cm_catagory.FormattingEnabled = true;
            this.cm_catagory.Location = new System.Drawing.Point(119, 24);
            this.cm_catagory.Name = "cm_catagory";
            this.cm_catagory.Size = new System.Drawing.Size(255, 24);
            this.cm_catagory.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Loại sách";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 491);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cm_catagory);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.Bt_delete);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.dtgv_book);
            this.Controls.Add(this.tx_amount);
            this.Controls.Add(this.tx_price);
            this.Controls.Add(this.tx_name);
            this.Controls.Add(this.tx_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_book)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button Bt_delete;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.DataGridView dtgv_book;
        private System.Windows.Forms.TextBox tx_amount;
        private System.Windows.Forms.TextBox tx_price;
        private System.Windows.Forms.TextBox tx_name;
        private System.Windows.Forms.TextBox tx_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cm_catagory;
        private System.Windows.Forms.Label label5;
    }
}

