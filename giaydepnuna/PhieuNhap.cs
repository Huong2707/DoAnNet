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
    public partial class PhieuNhap : Form
    {
        public PhieuNhap()
        {
            InitializeComponent();
        }
        Connect kn=new Connect();
        public void getData()
        {
            string query = "select*from CTPHIEUNHAPKHO";
            DataTable dt = kn.laydulieu(query);
            dgvpn.DataSource = dt;
        }
        public void Cleartext()
        {
            txtdongia.Text = "";
            txtncc.Text = "";
            txtpn.Text = "";
            txtsl.Text = "";
            txtsp.Text = "";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtpn.Text = dgvpn.Rows[r].Cells[0].Value.ToString();
                txtsp.Text = dgvpn.Rows[r].Cells[1].Value.ToString();
                txtsl.Text = dgvpn.Rows[r].Cells[2].Value.ToString();
                txtdongia.Text = dgvpn.Rows[r].Cells[3].Value.ToString();
                txtncc.Text = dgvpn.Rows[r].Cells[4].Value.ToString();
             
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = string.Format("insert into CTPHIEUNHAPKHO values ('{0}','{1}','{2}','{3}','{4}')",
               txtpn.Text,
               txtsp.Text,
               txtsl.Text,
               txtdongia.Text,
               txtncc.Text);
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

        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            getData();
            //string query = "SELECT PHIEUNHAPKHO.IDPNK, nglap,CTPHIEUNHAPKHO .soluong * CTPHIEUNHAPKHO.dongia AS thanhtien\r\nFROM PHIEUNHAPKHO,CTPHIEUNHAPKHO,giaydep\r\nwhere CTPHIEUNHAPKHO.IDPNK=PHIEUNHAPKHO.IDPNK\r\nand CTPHIEUNHAPKHO.IDSP = giaydep.IDSP ;";
            //DataTable dt = kn.laydulieu(query);
            //dgvnhap.DataSource = dt;

        }

        private void btnlmmoi_Click(object sender, EventArgs e)
        {
            getData();
            Cleartext();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string query = string.Format("insert into CTPHIEUNHAPKHO values ('{0}','{1}','{2}','{3}','{4}')",
              txtpn.Text,
              txtsp.Text,
              txtsl.Text,
              txtdongia.Text,
              txtncc.Text);
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }
}
