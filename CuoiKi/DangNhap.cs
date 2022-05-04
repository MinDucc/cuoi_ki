using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuoiKi
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_DN_Click(object sender, EventArgs e)
        {
            GiaoDien giaoDien = new GiaoDien();
            giaoDien.Show();
            this.Hide();
            giaoDien.DangXuat += GiaoDien_DangXuat;

        }

        private void GiaoDien_DangXuat(object sender, EventArgs e)
        {
            this.Show();
            (sender as GiaoDien).isExit = false;
            (sender as GiaoDien).Close();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
