using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lap1
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtKQ.Text = "";
            rbbt_BC.Checked = false;
            rbbt_UC.Checked = false;
        }

        private void bt_Submit_Click(object sender, EventArgs e)
        {
            if (!checkNull()) return;
            txtKQ.ForeColor = Color.Black;
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            if (rbbt_BC.Checked)
            {

                for (int i = Math.Max(a, b); i <= a * b; i += Math.Max(a, b))
                {
                    if (i % Math.Min(a, b) == 0)
                    {
                        txtKQ.Text = i.ToString();
                        return;
                    }
                }
            }
            if (a==0 || b==0 )
            {
                txtKQ.Text = (a+b).ToString();
                return;
            }
            while (a!=b)
            {
                if (a>b) a-=b;             
                else b -= a;      
            }
            txtKQ.Text = a.ToString();
        }

        public bool checkNull()
        {    
            if (txtA.Text.Trim().Length == 0 || txtB.Text.Trim().Length == 0 || (rbbt_BC.Checked == false && rbbt_UC.Checked == false))
            {
                txtKQ.ForeColor = Color.Red;
                txtKQ.Text= " Chưa điền đầy đủ";
                return false;
            }
            return true;
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ( (!char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar) ))
            {
                e.Handled = true;
            }            
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn thực sự muốn thoát?", "Thoát ...",  MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
