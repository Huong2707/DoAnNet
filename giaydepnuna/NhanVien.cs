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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        Connect kn=new Connect();
        private void label5_Click(object sender, EventArgs e)
        {

        }
        public void getData()
        {
            string query = "select* from nhanvien";
            DataTable dt = kn.laydulieu(query);
            dgvnv.DataSource = dt;
        }
        public void ClearText()
        {
            txtid.Text = "";
            txtten.Text = "";
            txtdc.Text = "";
            txtsdt.Text = "";
            txtns.Text = "";
            txtcv.Text = "";
            txtnvl.Text = "";
            txttimkiem.Text = "";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string query = string.Format("insert into nhanvien values('{0}',N'{1}',N'{2}','{3}','{4}','{5}',N'{6}')",
               txtid.Text,
               txtten.Text,
               txtdc.Text,
               txtsdt.Text,
               txtns.Text,
               txtnvl.Text,
               txtcv.Text);
            bool r = kn.thucthi(query);
            if (r)
            {
                MessageBox.Show("Thêm thành công");
                btnlmmoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void btnlmmoi_Click(object sender, EventArgs e)
        {
            ClearText();
            getData();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string query = string.Format("update nhanvien set hoten=N'{1}',dchi=N'{2}',sdt='{3}',ngsinh='{4}',ngvl='{5}',chucvu=N'{6}' where idnv='{0}'",
              txtid.Text,
               txtten.Text,
               txtdc.Text,
               txtsdt.Text,
               txtns.Text,
               txtnvl.Text,
               txtcv.Text);
            bool r = kn.thucthi(query);
            if (r)
            {
                MessageBox.Show("Sửa thành công");
                btnlmmoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string query = string.Format("delete nhanvien where idnv='{0}'", txtid.Text);
            bool r = kn.thucthi(query);
            if (r)
            {
                MessageBox.Show("Xóa thành công");
                btnlmmoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvnv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtid.Text = dgvnv.Rows[r].Cells[0].Value.ToString();
                txtten.Text = dgvnv.Rows[r].Cells[1].Value.ToString();
                txtdc.Text = dgvnv.Rows[r].Cells[2].Value.ToString();
                txtsdt.Text = dgvnv.Rows[r].Cells[3].Value.ToString();
                txtns.Text = dgvnv.Rows[r].Cells[4].Value.ToString();
                txtnvl.Text = dgvnv.Rows[r].Cells[5].Value.ToString();
                txtcv.Text = dgvnv.Rows[r].Cells[6].Value.ToString();
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string query = string.Format("select* from nhanvien where hoten like N'%{0}%'", txttimkiem.Text);
            DataTable da = kn.laydulieu(query);
            dgvnv.DataSource = da;
            txttimkiem.Text = "";
        }
    }
    
}
