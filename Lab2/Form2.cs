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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            cm_name.SelectedIndex = 0;
            Bai1_name.SelectedIndex = 0;
            date.Text = DateTime.Now.ToString("dd/MM/yyyy");
            time.Text = DateTime.Now.ToString("H:m:ff");
        }



        private void bt_Tinh_Click_1(object sender, EventArgs e)
        {
            if (cm_name.SelectedIndex < 0)
            {
                MessageBox.Show("Chưa chọn tên ");
                return;
            }
            int soDien = int.Parse(txt_moi.Text) - int.Parse(txt_cu.Text);
            txt_dung.Text = soDien.ToString();
            if (soDien <= 50)
            {
                txt_trong.Text = soDien.ToString();
                txt_tongTien.Text = (soDien * 500).ToString();
            }
            else
            {
                txt_trong.Text = "50";
                txt_trong.Text = (soDien - 50).ToString();
                txt_tongTien.Text = (50 * 500 + (soDien - 50) * 1000).ToString();
            }
        }

        private void bt_In_Click_1(object sender, EventArgs e)
        {
            txt_HoaDon.Text = cm_name.Text + "\t\t\tSố giờ tiêu thụ: " + txt_dung.Text + "\t\tTổng tiền: " + txt_tongTien.Text;
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            var x = MessageBox.Show("Bạn muốn thoát", "Thoát", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                Close();
            }
        }
        // bài 2
        private void btNextAll_Click(object sender, EventArgs e)
        {
            listMon2.Items.AddRange(listMon1.Items);
            listMon1.Items.Clear();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            
                if (listMon1.SelectedIndex >= 0)
                {
                    listMon2.Items.Add(listMon1.SelectedItem);
                    listMon1.Items.Remove(listMon1.SelectedItem);
                }
           
        }

        private void btPrevAll_Click(object sender, EventArgs e)
        {
            listMon1.Items.AddRange(listMon2.Items);
            listMon2.Items.Clear();

        }

        private void bt_Prev_Click(object sender, EventArgs e)
        {
          
                if (listMon2.SelectedIndex >= 0)
                {
                    listMon1.Items.Add(listMon2.SelectedItem);
                    listMon2.Items.Remove(listMon2.SelectedItem);
                }
            
        }

        private void bt_SM_Bai2_Click(object sender, EventArgs e)
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

        private void btn_Reset_Bai2_Click(object sender, EventArgs e)
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

        private void btn_Exit_bai2_Click(object sender, EventArgs e)
        {
            var x = MessageBox.Show("Bạn muốn thoát", "Thoát", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                Close();
            }
        }

        private void bt_Send_Click(object sender, EventArgs e)
        {
            FormNhan frm = new FormNhan();
            SenndData senndData = frm.funData;
            senndData(text);
            frm.Show();
        }
    }
}
