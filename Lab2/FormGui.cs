using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public delegate void SenndData(TextBox str);
    public partial class FormGui : Form
    {
        public FormGui()
        {
            InitializeComponent();
        }

        private void bt_Send_Click(object sender, EventArgs e)
        {
            FormNhan frm= new FormNhan();
            SenndData senndData = frm.funData ;
            senndData(text);
            frm.Show();
        }

        private void bài1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            Close();
        }

        private void bài2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai2 bai2 = new Bai2();
            bai2.ShowDialog();
            this.Close();
        }

        private void bài3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGui form = new FormGui();
            form.ShowDialog();
            this.Close();
        }

        private void text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
