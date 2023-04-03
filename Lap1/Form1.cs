namespace Lap1
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

      

      

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            if(!checkNull()) return;
            txtKQ.Text = (int.Parse(txtSoN.Text)+ int.Parse(txtSoM.Text)).ToString();
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            txtKQ.Text = (int.Parse(txtSoN.Text) - int.Parse(txtSoM.Text)).ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            txtKQ.Text = (int.Parse(txtSoN.Text) * int.Parse(txtSoM.Text)).ToString();
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            txtKQ.Text = (int.Parse(txtSoN.Text) / int.Parse(txtSoM.Text)).ToString();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            txtSoN.Text = "";
            txtSoM.Text = "";
            txtKQ.Text = "" ;
        }
        private bool checkNull()
        {
            if(txtSoN.Text.Trim().Length==0 || txtSoM.Text.Trim().Length == 0)
                return false;
            return true;
        }

        private void txtSoN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}