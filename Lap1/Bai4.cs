using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lap1
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
            gia1.Text = "$" + 20;
        }

        private void bt_Total_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn chưa nhập tên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }          
            txt_total.Text = Total();
            list_KH.Items.Add(txt_name.Text+" - "+txt_total.Text);
            WriteFile();
        }

        
        private void WriteFile()
        {
            File.Delete("ls_KH.txt");
            foreach (var item in list_KH.Items)
            {
                File.AppendAllText("ls_KH.txt","\n"+ item.ToString());
            }
        }
        private void ReadFile()
        {
            var x = File.ReadAllLines("ls_KH.txt");
            list_KH.Items.Clear();
            for (int i = 1; i < x.Length; i++)
            {
                list_KH.Items.Add(x[i]);
            }
        }
        private string Total()
        {
            int total = 0;
            if (check_Cao.Checked)
            {
                total += 100000;
            }
            if (check_Tay.Checked)
            {
                total += 1200000;
            }
            if (Check_Chup.Checked)
            {
                total += 200000;
            }
            total += 80000 * int.Parse(num_Tram.Text);
            return total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadFile();
        }
    }
}
