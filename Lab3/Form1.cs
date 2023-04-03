using System.Data;
using System.Data.SqlClient;

namespace Lab3
{
    public partial class bt_delete : Form
    {
        public bt_delete()
        {
            InitializeComponent();
            Lop();
        }

        void Lop()
        {
            
            string query = "select malop, tenLop from lop";
            SqlConnection conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Lab3;Persist Security Info=True;User ID=sa;Password=Matkhau1");
            conn.Open();            
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds,"Lop");
            cb_class.DisplayMember = "tenLop";
            cb_class.ValueMember = "maLop";
            cb_class.DataSource = ds.Tables["Lop"];
            conn.Close();
            
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            string id = tx_id.Text;
            string name = tx_name.Text;
            string dOB = dt_DOB.Text;
            string adress = tx_adress.Text;
            string _class = cb_class.SelectedValue.ToString();
            float point = float.Parse(tx_point.Text);

            SqlConnection connection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Lab3;User ID=sa;Password=Matkhau1");
            try
            {
                connection.Open();
                string query = $"Insert into hocsinh values" +
                   $" ('{id}',N'{name}','{dOB}',N'{adress}',{point},'{_class}') ";
                SqlCommand cmd = new SqlCommand(query, connection);
                var result=cmd.ExecuteNonQuery();
                MessageBox.Show("Thành công " + result);
            }
            catch (Exception  )
            {
                MessageBox.Show("Lỗi");
               
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tx_id.Text="";
            tx_name.Text = "";            
             tx_adress.Text = "";
            cb_class.SelectedIndex=-1;
           
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_delete_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}