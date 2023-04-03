using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form2 : Form
    {
        public Form2()
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
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            cb_class.DisplayMember = "tenLop";
            cb_class.ValueMember = "maLop";
            cb_class.DataSource = ds;
            conn.Close();

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            dtgv_student.DataSource = ExcuteQuery();
            dtgv_student.Columns[0].HeaderText = "Mã học sinh";
            dtgv_student.Columns[1].HeaderText = "Tên học sinh";
            dtgv_student.Columns[2].HeaderText = "Ngày sinh";
            dtgv_student.Columns[3].HeaderText = "Địa chỉ";
            dtgv_student.Columns[4].HeaderText = "Điểm trung bình";
            dtgv_student.Columns[5].HeaderText = "Mã lớp";
           

        }

        DataTable ExcuteQuery()
        {
            string query = "Select * from hocsinh";
            DataTable data = new DataTable();
            using (
            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Lab3;User ID=sa;Password=Matkhau1"))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
                return data;
            }

        }
        int ExcuteNonQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Lab3;User ID=sa;Password=Matkhau1"))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                return cmd.ExecuteNonQuery();
            }
           ;
        }



        private void dtgv_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tx_id.Text = dtgv_student.SelectedCells[0].Value.ToString();
            tx_name.Text = dtgv_student.SelectedCells[1].Value.ToString();
            dt_dob.Text = dtgv_student.SelectedCells[2].Value.ToString();
            tx_adress.Text = dtgv_student.SelectedCells[3].Value.ToString();
            tx_point.Text = dtgv_student.SelectedCells[4].Value.ToString();
            cb_class.SelectedValue = dtgv_student.SelectedCells[5].Value.ToString();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {

            string query = $"update hocsinh set tenHS='{tx_name.Text}', ngaySinh='{dt_dob.Text}', diaChi='{tx_adress.Text}', DTB= {float.Parse(tx_point.Text)}, maLop='{cb_class.SelectedValue}' where maHS= '{tx_id.Text}'";
            ExcuteNonQuery(query);
            MessageBox.Show("Thành công " + ExcuteNonQuery(query));
            dtgv_student.DataSource = ExcuteQuery();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            string query = $"delete from hocsinh where maHS like '{tx_id.Text}'";
            ExcuteNonQuery(query);
            dtgv_student.DataSource = ExcuteQuery();
        }



        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Bạn thật sự muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtgv_student_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
