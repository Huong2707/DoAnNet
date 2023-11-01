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
    public partial class HeThong : Form
    {
        public HeThong()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }
        private Form currentFormChild;
        private void OpendChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelbody.Controls.Add(childForm);
            panelbody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }


        private void HeThong_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnnv_Click(object sender, EventArgs e)
        {
            OpendChildForm(new NhanVien());
            trangchu.Text = btnnv.Text;
        }

        private void btnncc_Click(object sender, EventArgs e)
        {
            OpendChildForm(new NCC());
            trangchu.Text = btnncc.Text;

        }

        private void btnnhap_Click(object sender, EventArgs e)
        {
            OpendChildForm(new PhieuNhap());
            trangchu.Text = btnnhap.Text;
        }

        private void btnsp_Click(object sender, EventArgs e)
        {
            OpendChildForm(new SanPham());
            trangchu.Text = btnsp.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpendChildForm(new HoaDon());
            trangchu.Text = btnhoadon.Text;
        }

        private void btncaidat_Click(object sender, EventArgs e)
        {
            OpendChildForm(new CaiDat());
            trangchu.Text = btncaidat.Text;
        }

        private void btnluong_Click(object sender, EventArgs e)
        {
            OpendChildForm(new Luong());
            trangchu.Text = btnluong.Text;
        }
    }
}
