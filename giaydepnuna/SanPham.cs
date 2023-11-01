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
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
        }
        Connect kn=new Connect();
        public void getData()
        {
            string query = "select*from giaydep";
            DataTable dt = kn.laydulieu(query);
            dgvsp.DataSource = dt;
        }
        public void ClearText()
        {
            txtsp.Text = "";
            txttensp.Text = "";
            txtsl.Text = "";
            txtloai.Text = "";
            txtkichco.Text = "";
            txtghichu.Text = "";
            txtgia.Text = "";
        }
        public void getidncc()
        {
            string query = "select*from nhacungcap";
            DataTable dt = kn.laydulieu(query);
            idncc.DataSource = dt;
            idncc.DisplayMember = "IDNCC";
            idncc.ValueMember = "IDNCC";

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtsp.Text = dgvsp.Rows[r].Cells[0].Value.ToString();
                txttensp.Text = dgvsp.Rows[r].Cells[1].Value.ToString();
                txtsl.Text = dgvsp.Rows[r].Cells[2].Value.ToString();
                txtloai.Text = dgvsp.Rows[r].Cells[3].Value.ToString();
                txtkichco.Text = dgvsp.Rows[r].Cells[4].Value.ToString();
                txtghichu.Text = dgvsp.Rows[r].Cells[5].Value.ToString();
                txtgia.Text = dgvsp.Rows[r].Cells[6].Value.ToString();
                idncc.SelectedValue = dgvsp.Rows[r].Cells[7].Value.ToString();

            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string query = string.Format("insert into giaydep values('{0}', N'{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
               txtsp.Text,
               txttensp.Text,
               txtsl.Text,
               txtloai.Text,
               txtkichco.Text,
               txtghichu.Text,
               txtgia.Text,
               idncc.SelectedValue);
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

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            ClearText();
            getData();
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            getData();
            getidncc();

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string query = string.Format("update giaydep set tensp='{1}',soluong='{2}',loai='{3}',kichco='{4}',ghichu='{5}',gia='{6}',idncc='{7}' where idsp='{0}'",
               txtsp.Text,
               txttensp.Text,
               txtsl.Text,
               txtloai.Text,
               txtkichco.Text,
               txtghichu.Text,
               txtgia.Text,
               idncc.SelectedValue);
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

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string query = string.Format("delete giaydep where idsp='{0}'", txtsp.Text);
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

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string query = string.Format("select *from giaydep where tensp  like '%{0}%'", txttk.Text);
            DataTable da = kn.laydulieu(query);
            dgvsp.DataSource = da;
        }
    }
}
