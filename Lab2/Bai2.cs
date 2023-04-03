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
   

    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
            Bai1_name.SelectedIndex = 0;
            date.Text = DateTime.Now.ToString("dd/MM/yyyy");
            time.Text = DateTime.Now.ToString("H:m:ff");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listMon2.Items.AddRange(listMon1.Items);
            listMon1.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listMon1.Items.AddRange(listMon2.Items);
            listMon2.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listMon1.SelectedIndex>=0)
            {
                listMon2.Items.Add(listMon1.SelectedItem);
                listMon1.Items.Remove(listMon1.SelectedItem);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (listMon2.SelectedIndex >= 0)
            {
                listMon1.Items.Add(listMon2.SelectedItem);
                listMon2.Items.Remove(listMon2.SelectedItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            rtb_bai2.Text = "";
            rtb_bai2.AppendText(Bai1_name.Text + "\n");
            rtb_bai2.AppendText(date.Text + " ");
            rtb_bai2.AppendText(time.Text + "\n");
            rtb_bai2.AppendText("Môn chọn: \n");
            foreach (var item in listMon2.Items)
            {
                rtb_bai2.AppendText(item.ToString() + " ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listMon2.Items.Clear();
            listMon1.Items.AddRange(new object[] {
            "Bóng đá",
            "Bóng Bàn",
            "Cầu lông",
            "Bắn bi",
            "Nhảy dù",
            "Bập Bênh"});
            rtb_bai2.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var x = MessageBox.Show("Bạn muốn thoát", "Thoát", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                Close();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

     

        private void bài2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Bai2 bai2 = new Bai2();
            bai2.ShowDialog();
            this.Close();
        }

        private void bài1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            Close();
        }

        private void bài3ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormGui form = new FormGui();
            form.ShowDialog();
            this.Close();
        }
    }
}
