using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lap1
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void rbt_pt2_CheckedChanged(object sender, EventArgs e)
        {
            txtC.Enabled = true;
        }

        private void rbt_pt1_CheckedChanged(object sender, EventArgs e)
        {
            txtC.Enabled = false;
            txtC.Text = "";
        }

        private void bt_Submit_Click(object sender, EventArgs e)
        {
            if (!checkNull()) return;
            if (rbt_pt1.Checked)
            {
                txtKQ.Text= Giaibac1(int.Parse(txtA.Text), int.Parse(txtB.Text));
                return;
            }
            txtKQ.Text= Giaibac2(int.Parse(txtA.Text), int.Parse(txtB.Text), int.Parse(txtC.Text));

        }
        private bool checkNull()
        {
            if (txtA.Text.Trim().Length == 0 || txtB.Text.Trim().Length == 0 ||( txtC.Text.Trim().Length == 0&& rbt_pt2.Checked==true))
            {
                MessageBox.Show("Nhập thiếu dữ liệu");
                return false;
            }
            return true;
        }

        private string Giaibac1(int a,int b)
        {
            if (a==0 && b==0)
            {
                return "Phuơng trình có vô số nghiệm";
            }
            if (a==0)
            {
                return "Phuơng trình vô nghiệm";
            }
            return $"Phương trình có nghiệm: {Math.Round((double)-b /a,2)}";
        }
        private string Giaibac2(int a, int b,int c)
        {            
            if (a == 0)
            {
                return Giaibac1(b,c);
            }
            double delta=(double)((b*b)-4*a*c);
            if (delta<0)
            {
                return "Phuơng trình vô nghiệm";
            }
            if (delta == 0)
            {
                return $"Phuơng trình có nghiệm kép: {-b/(2*a)}";
            }
            return $"Phương trình có 2 nghiệm: x1: {Math.Round(-b + Math.Sqrt(delta) / (2 * a),2)}, x2:  {Math.Round(-b - Math.Sqrt(delta) / (2 * a), 2)}";
        }

        private void input_KeyPress(object sender, KeyPressEventArgs e)
        {         
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            var result= MessageBox.Show("Bạn thật sự muốn thoát?","Thoát..",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result==DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
