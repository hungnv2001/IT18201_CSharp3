using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Lab4_hungnv : Form
    {
        public Lab4_hungnv()
        {
            InitializeComponent();
           
        }

        private void bt_get_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=QuanLy;User ID=sa;Password=Matkhau1"))
                {
                    string query = "select * from Users";
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataSet ds = new DataSet();
                    DataTable data = new DataTable("Users");
                    adapter.Fill(data);
                    ds.Tables.Add(data);
                    connection.Close();
                    dataGridView1.DataSource = data;
                    dataGridView1.Columns[0].Visible = false;
                }
            }
            catch (Exception )
            {


            }
        }

        private void bt_insert_Click(object sender, EventArgs e)
        {
            string user = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            int id = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            string query = $"insert into Users values(N'{user}',{id})";
            ExcuteNonQuery(query);
            bt_get_Click(sender, e);
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            string user = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            int id = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            int idUser = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string query = $"update Users set username='{user}',groupid={id} where userid={idUser}";
            ExcuteNonQuery(query);
            bt_get_Click(sender, e);
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string query = $"Delete from Users where UserID={id}";
            ExcuteNonQuery(query);
            bt_get_Click(sender, e);
        }

        void ExcuteNonQuery(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=QuanLy;User ID=sa;Password=Matkhau1"))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                  
                }
                MessageBox.Show("Thành công");
            }
            catch (Exception )
            {
                MessageBox.Show("đã chạy đc");
            }
        }

        private void bt_Sort_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=QuanLy;User ID=sa;Password=Matkhau1"))
                {
                    string query = "select * from Users";
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataSet ds = new DataSet();                  
                    adapter.Fill(ds,"Users");
                    DataView dv= ds.Tables["Users"].DefaultView;
                    dv.Sort = "UserName DESC";
                    dataGridView1.DataSource = dv;
                    connection.Close();
                 
                   
                }
            }
            catch (Exception ex)
            {


            }
        }
    }
}
