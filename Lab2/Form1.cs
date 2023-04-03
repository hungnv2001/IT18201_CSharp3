namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cm_name.SelectedIndex = 0;
        }

        private void bt_Tinh_Click(object sender, EventArgs e)
        {
            if (cm_name.SelectedIndex <0)
            {
                MessageBox.Show("Chưa chọn tên " );
                return;
            }
            int soDien = int.Parse(txt_moi.Text) - int.Parse(txt_cu.Text);
            txt_dung.Text=soDien.ToString();
            if (soDien<=50)
            {
                txt_trong.Text = soDien.ToString();
                txt_tongTien.Text = (soDien*500).ToString();
            }
            else
            {
                txt_trong.Text = "50";
                txt_trong.Text = (soDien-50).ToString();
                txt_tongTien.Text = (50 * 500+(soDien-50)*1000).ToString();
            }
        }

        private void bt_In_Click(object sender, EventArgs e)
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
    }
}