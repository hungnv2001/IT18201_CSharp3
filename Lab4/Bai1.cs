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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
            CreateDataSet();
        }
        void CreateDataSet()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Quanly;Persist Security Info=True;User ID=sa;Password=Matkhau1"))
            {
                connection.Open();
                string query = "select * from Users";
                SqlDataAdapter adapter= new SqlDataAdapter(query,connection );
                DataSet ds = new DataSet();
                adapter.Fill(ds,"Users");
                query = "select * from Groups";
                adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(ds, "Groups");
                DataTable Groups = ds.Tables["Groups"];
                DataTable Users = ds.Tables["Users"];
                DataRelation relation = new DataRelation("Group_User", Groups.Columns["GroupID"], Users.Columns["GroupID"]);
                ds.Relations.Add(relation);
                dataGridView1.DataSource = ds.Tables["Groups"];
                // dataGridView1.Columns[0].Visible=false;
                dataGridView1.Columns[0].Width = 70;
                dataGridView2.DataSource = ds.Tables["Users"]; ;
                dataGridView2.Columns[0].Visible = false;
            }
        }
    }
}
