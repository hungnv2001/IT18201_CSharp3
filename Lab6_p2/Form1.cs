using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_p2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bt_add.Enabled = true;
        }

        private void Bt_delete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn thực sự muốn xoá", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (var bm = new BookManergerContext())
                {

                    var book = bm.BookManers.Where(x => x.ID == tx_id.Text).FirstOrDefault();
                    bm.BookManers.Remove(book);
                    bm.SaveChanges();
                    GetData();
                    MessageBox.Show("Đã xoá");
                    Clear();
                }
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            Clear();
            bt_save.Enabled = false;
            bt_cancel.Enabled = false;
            Bt_delete.Enabled = false;
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            string check = Check();
            if (check != null)
            {
                MessageBox.Show($"Lỗi: {check}");
                return;
            }
            BookManerger bm = new BookManerger();
            bm.ID = tx_id.Text;
            bm.Name = tx_name.Text;
            bm.Price = int.Parse(tx_price.Text);
            bm.Amount = int.Parse(tx_amount.Text);
            bm.CatagolyID = (int)cm_catagory.SelectedValue;
            Add(bm);
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            Clear();
            cm_catagory.Enabled = true;
            tx_id.ReadOnly = false;
            tx_name.ReadOnly = false;
            tx_amount.ReadOnly = false;
            tx_price.ReadOnly = false;
            bt_save.Enabled = true;
            bt_cancel.Enabled = true;
        }
        private void Clear()
        {
            tx_id.Text = "";
            tx_name.Text = "";
            tx_price.Text = "";
            tx_amount.Text = "";
            tx_id.ReadOnly = true;
            tx_name.ReadOnly = true;
            tx_amount.ReadOnly = true;
            tx_price.ReadOnly = true;
            cm_catagory.Enabled = false;
            dtgv_book.ClearSelection();
            cm_catagory.SelectedIndex = -1;
        }
        private List<BookManerger> GetData()
        {
            using (var bm = new BookManergerContext())
            {
                bm.Database.CreateIfNotExists();
                dtgv_book.DataSource = bm.BookManers.ToList();
                            
                cm_catagory.DataSource = bm.Catagolies.ToList();
                cm_catagory.DisplayMember = "CatagolyName";
                cm_catagory.ValueMember = "CatagolyID";
                return bm.BookManers.ToList();
            }
        }
        private void Add(BookManerger bm)
        {
            using (var bmc = new BookManergerContext())
            {
                bmc.BookManers.Add(bm);
                bmc.SaveChanges();
                GetData();
            }

        }
        private string Check()
        {
            if (tx_id.Text.Trim().Length == 0 || tx_name.Text.Trim().Length == 0 || tx_amount.Text.Trim().Length == 0 || tx_price.Text.Trim().Length == 0)
            {
                return "Có trường đang để trống";
            }
            try
            {
                int.Parse(tx_amount.Text);
                int.Parse(tx_price.Text);
            }
            catch (Exception)
            {
                return "Trường số lượng và giá phải là số";
            }
            using (var bmc = new BookManergerContext())
            {
                if (bmc.BookManers.Where(x => x.ID == tx_id.Text).FirstOrDefault() != null)
                {
                    return "ID đã tồn tại";
                }
            }
            return null;

        }

        private void dtgv_book_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tx_id.Text != dtgv_book.SelectedCells[0].Value.ToString())
            {
                cm_catagory.Enabled = true;
                Bt_delete.Enabled = true;
                tx_id.Text = dtgv_book.SelectedCells[0].Value.ToString();
                tx_name.Text = dtgv_book.SelectedCells[1].Value.ToString();
                cm_catagory.SelectedValue = int.Parse(dtgv_book.SelectedCells[2].Value.ToString());
                tx_price.Text = dtgv_book.SelectedCells[3].Value.ToString();
                tx_amount.Text = dtgv_book.SelectedCells[4].Value.ToString();
            }
            else
            {
                Clear();
                tx_id.ReadOnly = true;
                tx_name.ReadOnly = true;
                tx_amount.ReadOnly = true;
                tx_price.ReadOnly = true;
                bt_add.Enabled = true;
                bt_add.Enabled = true;
                bt_save.Enabled = false;
                bt_cancel.Enabled = false;
                Bt_delete.Enabled = false;
                cm_catagory.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var bm = new BookManergerContext())
            {
                bm.Database.CreateIfNotExists();
            }
            GetData();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Bạn thực sự muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
