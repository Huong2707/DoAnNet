using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giaydepnuna
{
    public partial class NCC : Form
    {
        public NCC()
        {
            InitializeComponent();
        }
        Connect kn=new Connect();
        public void getdata()
        {
            string query = "select*from nhacungcap";
            DataTable dt = kn.laydulieu(query);
            dgvncc.DataSource = dt;
        }
        public void clearText()
        {
            txtid.Text = "";
            txtten.Text = "";
            txtdc.Text = "";
            txtsdt.Text = "";
            txtgc.Text = "";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = string.Format(" insert into nhacungcap values('{0}',N'{1}',N'{2}','{3}',N'{4}')",
               txtid.Text,
               txtten.Text,
               txtdc.Text,
               txtsdt.Text,
               txtgc.Text);
            bool r = kn.thucthi(query);
            if (r)
            {
                MessageBox.Show("Thêm thành công");
                btnlammoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string query = string.Format("select* from nhacungcap where tenncc like N'%{0}%'", txttk.Text);
            DataTable da = kn.laydulieu(query);
            dgvncc.DataSource = da;
            txttk.Text = "";
        }

        private void NCC_Load(object sender, EventArgs e)
        {
            getdata();
        }

        private void dgvncc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtid.Text = dgvncc.Rows[r].Cells[0].Value.ToString();
                txtten.Text = dgvncc.Rows[r].Cells[1].Value.ToString();
                txtdc.Text = dgvncc.Rows[r].Cells[2].Value.ToString();
                txtsdt.Text = dgvncc.Rows[r].Cells[3].Value.ToString();
                txtgc.Text = dgvncc.Rows[r].Cells[4].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            getdata();
            clearText();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string query = string.Format("update nhacungcap set  tenncc=N'{1}', dchi=N'{2}',sdt='{3}',ghichu=N'{4}' where idncc='{0}'",
                txtid.Text,
                txtten.Text,
                txtdc.Text,
                txtsdt.Text,
                txtgc.Text);
            bool r = kn.thucthi(query);
            if (r)
            {
                MessageBox.Show("Sửa thành công");
                btnlammoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string query = string.Format("delete nhacungcap where idncc='{0}'", txtid.Text);
            bool r = kn.thucthi(query);
            if (r)
            {
                MessageBox.Show("Xóa thành công");
                btnlammoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void txttk_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
