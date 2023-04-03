using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_b1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (var cpct = new CompanyContext())
            {
                cpct.Database.CreateIfNotExists();
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            try
            {
                Company company = new Company();
                company.CompanyId = tx_id.Text;
                company.Name = tx_name.Text;
                CompanyContext companyContext = new CompanyContext();
                companyContext.Companys.Add(company);
                companyContext.SaveChanges();
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception)
            {

                MessageBox.Show($"Lỗi rồi nhé!");
            }
        }
    }
}
