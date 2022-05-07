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
    public partial class GiaoDien : Form
    {
        public GiaoDien()
        {
            InitializeComponent();
        }
        public bool isExit=true;
        public event EventHandler DangXuat;
        private void btn_dx_Click(object sender, EventArgs e)
        {
            isExit = false;
            DangXuat(this, new EventArgs());
            this.Close();

        }
        /// <summary>
        /// Đóng Form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GiaoDien_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
                Application.Exit();
        }
        private void GiaoDien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
                if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
        }
        /// <summary>
        /// Su kien nut nhan Vien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            NhanVien nhanvien = new NhanVien();
            nhanvien.Show();
            this.Hide();
            nhanvien.TroVe += Nhanvien_TroVe;

        }

        private void Nhanvien_TroVe(object sender, EventArgs e)
        {
            this.Show();
        }

        /// <summary>
        /// Su kien nut quan li
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_QLHoaDon_Click(object sender, EventArgs e)
        {
            QLHoaDon qLHoaDon = new QLHoaDon();
            qLHoaDon.Show();
            this.Hide();
            qLHoaDon.TroVe += QLHoaDon_TroVe;
        }

        private void QLHoaDon_TroVe(object sender, EventArgs e)
        {
            this.Show();
        }

        /// <summary>
        /// Su kien nut HangHoa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_HangHoa_Click(object sender, EventArgs e)
        {
            HangHoa hanghoa = new HangHoa();
            hanghoa.Show();
            this.Hide();
            hanghoa.TroVe += Hanghoa_TroVe;
        }

        private void Hanghoa_TroVe(object sender, EventArgs e)
        {
            this.Show();
            
        }

        /// <summary>
        /// Su kie nut Account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {
            Account taikhoan = new Account();
            taikhoan.Show();
            this.Hide();
            taikhoan.TroVe += Taikhoan_TroVe;

        }

        private void Taikhoan_TroVe(object sender, EventArgs e)
        {
            this.Show();
        }

        /// <summary>
        /// Su kien nut Hoa Don
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            HoaDon hoadon = new HoaDon();
            hoadon.Show();
            this.Hide();
            hoadon.TroVe += Hoadon_TroVe;
        }

        private void Hoadon_TroVe(object sender, EventArgs e)
        {
            this.Show();
            
        }

        
    }
}
