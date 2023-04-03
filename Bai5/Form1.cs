using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb_id.Hide();
            GetStudent();
            Clear();
        }

        public void GetStudent()
        {
            using (var ctx = new StudentInformationEntities())
            {
                List<StudentInformation> studentList = new List<StudentInformation>();
                studentList = ctx.StudentDetails.Select(x => new StudentInformation
                {
                    ID  = x.ID,
                    Name = x.Name,
                    Age = x.Age,
                    City = x.City,
                    Gender = x.Gender
                }).ToList();

                dtgv_student.DataSource = studentList;
                dtgv_student.Columns[0].Visible = false;
            }
        }

        public bool SaveStudentDetails(StudentDetail student)
        {
            bool result = false;
            using (StudentInformationEntities entity = new StudentInformationEntities())
            {
                entity.StudentDetails.Add(student);
                entity.SaveChanges();
                result = true;
            }
            return result;
        }

        void Show(bool result, string str)
        {
            if (result)
            {
                MessageBox.Show($"{str} Sucessfully", str, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Lỗi ở đâu đó", str, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void Clear()
        {
            tx_age.Text = "";
            tx_name.Text = "";
            tx_city.Text = "";
            cb_gender.SelectedIndex = -1;
            lb_id.Text = "-1";
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            StudentDetail student = new StudentDetail();
            student.Name = tx_name.Text;
            student.Age = int.Parse(tx_age.Text);
            student.Gender = cb_gender.Text;
            student.City = tx_city.Text;
            Show(SaveStudentDetails(student), "Save");
            GetStudent();
            Clear();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            if (lb_id.Text != "-1")
            {
                StudentDetail student = new StudentDetail();
                student.ID = int.Parse(lb_id.Text);
                student.Name = tx_name.Text;
                student.Age = int.Parse(tx_age.Text);
                student.Gender = cb_gender.Text;
                student.City = tx_city.Text;
                Show(Update(student), "Update");
                GetStudent();
            }
        }

        bool Update(StudentDetail student)
        {
            var result = false;
            using (StudentInformationEntities entity = new StudentInformationEntities())
            {
                StudentDetail studentDetail = entity.StudentDetails.Where(p => p.ID == student.ID).FirstOrDefault();
                studentDetail.Name = student.Name;
                studentDetail.Gender = student.Gender;
                studentDetail.Age = student.Age;
                studentDetail.City = student.City;
                entity.SaveChanges();
                result = true;
            }
            return result;
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (lb_id.Text != "-1")
            {
                StudentDetail student = new StudentDetail();
                student.ID = int.Parse(lb_id.Text);
                student.Name = tx_name.Text;
                student.Age = int.Parse(tx_age.Text);
                student.Gender = cb_gender.Text;
                student.City = tx_city.Text;
                Show(Delete(student), "Delete");
                GetStudent();
                Clear();
            }
        }

        bool Delete(StudentDetail student)
        {

            var result = false;
            using (StudentInformationEntities entity = new StudentInformationEntities())
            {
                StudentDetail studentDetail = entity.StudentDetails.Where(p => p.ID == student.ID).FirstOrDefault();
                entity.StudentDetails.Remove(studentDetail);
                entity.SaveChanges();
                result = true;
            }
            return result;

        }

        private void dtgv_student_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lb_id.Text != dtgv_student.SelectedCells[0].Value.ToString())
            {
                lb_id.Text = dtgv_student.SelectedCells[0].Value.ToString();
                tx_name.Text = dtgv_student.SelectedCells[1].Value.ToString();
                tx_age.Text = dtgv_student.SelectedCells[2].Value.ToString();
                tx_city.Text = dtgv_student.SelectedCells[3].Value.ToString();
                cb_gender.Text = dtgv_student.SelectedCells[4].Value.ToString();
            }
            else
            {

                Clear();

            }
        }
    }
}
