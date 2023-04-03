namespace Lab2
{
    partial class FormGui
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
            this.text = new System.Windows.Forms.TextBox();
            this.bt_Send = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bài1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(310, 126);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(125, 27);
            this.text.TabIndex = 0;
            this.text.TextChanged += new System.EventHandler(this.text_TextChanged);
            // 
            // bt_Send
            // 
            this.bt_Send.Location = new System.Drawing.Point(324, 175);
            this.bt_Send.Name = "bt_Send";
            this.bt_Send.Size = new System.Drawing.Size(94, 29);
            this.bt_Send.TabIndex = 1;
            this.bt_Send.Text = "gửi";
            this.bt_Send.UseVisualStyleBackColor = true;
            this.bt_Send.Click += new System.EventHandler(this.bt_Send_Click);
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
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bài1ToolStripMenuItem
            // 
            this.bài1ToolStripMenuItem.Name = "bài1ToolStripMenuItem";
            this.bài1ToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.bài1ToolStripMenuItem.Text = "Bài 1";
            this.bài1ToolStripMenuItem.Click += new System.EventHandler(this.bài1ToolStripMenuItem_Click);
            // 
            // bài2ToolStripMenuItem
            // 
            this.bài2ToolStripMenuItem.Name = "bài2ToolStripMenuItem";
            this.bài2ToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.bài2ToolStripMenuItem.Text = "Bài 2";
            this.bài2ToolStripMenuItem.Click += new System.EventHandler(this.bài2ToolStripMenuItem_Click);
            // 
            // bài3ToolStripMenuItem
            // 
            this.bài3ToolStripMenuItem.Name = "bài3ToolStripMenuItem";
            this.bài3ToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.bài3ToolStripMenuItem.Text = "Bài 3";
            this.bài3ToolStripMenuItem.Click += new System.EventHandler(this.bài3ToolStripMenuItem_Click);
            // 
            // FormGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 653);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.bt_Send);
            this.Controls.Add(this.text);
            this.Name = "FormGui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGui";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox text;
        private Button bt_Send;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem bài1ToolStripMenuItem;
        private ToolStripMenuItem bài2ToolStripMenuItem;
        private ToolStripMenuItem bài3ToolStripMenuItem;
    }
}