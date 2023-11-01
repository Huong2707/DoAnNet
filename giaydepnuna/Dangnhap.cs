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
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }
        Connect kn=new Connect();
        private void button1_Click(object sender, EventArgs e)
        {
            string truyvan = string.Format(" SELECT* from nguoidung where ACCOUNT='{0}'and PASSWORK='{1}'",
             txttk.Text,
             txtmk.Text);
            DataTable dt = kn.laydulieu(truyvan);
            if (rdql.Checked)
            {
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    HeThong frm = new HeThong();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!");
                }
            }
            if (rdnv.Checked)
            {
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    HeThongNV frm = new HeThongNV();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
