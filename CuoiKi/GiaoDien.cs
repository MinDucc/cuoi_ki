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
        public string position;
        public string name;
        public int id;
        public GiaoDien(string position,int id)
        {
            InitializeComponent();
            this.position = position;
            this.id = id;
        }
        
        public bool isExit=true;
        public event EventHandler DangXuat;
        private void formChild_Close(bool isClose)
        {
            isExit = false;
        }    
        private void btn_dx_Click(object sender, EventArgs e)
        {
            isExit = false;
            DangXuat(this, new EventArgs());
            this.Close();

        }
        private void GiaoDien_Load(object sender, EventArgs e)
        {
            if (position == "Employee")
            {
                btn_TaiKhoan.Enabled = false;
                btn_HoaDon.Enabled = false;
            }    
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
                {
                    e.Cancel = true;                   
                }    

        }
        /// <summary>
        /// Su kien nut nhan Vien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            NhanVien nhanvien = new NhanVien();
            nhanvien.exit = new NhanVien.Exit(formChild_Close);
            nhanvien.Show();
            this.Hide();
            nhanvien.TroVe += Nhanvien_TroVe;

        }

        private void Nhanvien_TroVe(object sender, EventArgs e)
        {
            this.Show();
            (sender as NhanVien).isExit = false;
            (sender as NhanVien).Close();
        }

        /// <summary>
        /// Su kien nut quan li
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_QLHoaDon_Click(object sender, EventArgs e)
        {
            QLHoaDon qLHoaDon = new QLHoaDon();
            qLHoaDon.exit = new QLHoaDon.Exit(formChild_Close);
            qLHoaDon.Show();
            this.Hide();
            qLHoaDon.TroVe += QLHoaDon_TroVe;
        }

        private void QLHoaDon_TroVe(object sender, EventArgs e)
        {
            this.Show();
            (sender as QLHoaDon).isExit = false;
            (sender as QLHoaDon).Close();
        }

        /// <summary>
        /// Su kien nut HangHoa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_HangHoa_Click(object sender, EventArgs e)
        {
            HangHoa hanghoa = new HangHoa();
            hanghoa.exit = new HangHoa.Exit(formChild_Close);
            hanghoa.Show();
            this.Hide();
            hanghoa.TroVe += Hanghoa_TroVe;
        }

        private void Hanghoa_TroVe(object sender, EventArgs e)
        {
            this.Show();
            (sender as HangHoa).isExit = false;
            (sender as HangHoa).Close();

        }

        /// <summary>
        /// Su kie nut TaiKhoan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {
            TaiKhoan taikhoan = new TaiKhoan();
            taikhoan.exit = new TaiKhoan.Exit(formChild_Close);
            taikhoan.Show();
            this.Hide();
            taikhoan.TroVe += Taikhoan_TroVe;

        }

        private void Taikhoan_TroVe(object sender, EventArgs e)
        {
            this.Show();
            (sender as TaiKhoan).isExit = false;
            (sender as TaiKhoan).Close();
        }

        /// <summary>
        /// Su kien nut Hoa Don
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            HoaDon hoadon = new HoaDon(id);
            hoadon.exit = new HoaDon.Exit(formChild_Close);
            hoadon.Show();
            this.Hide();
            hoadon.TroVe += Hoadon_TroVe;
        }

        private void Hoadon_TroVe(object sender, EventArgs e)
        {
            this.Show();
            (sender as HoaDon).isExit = false;
            (sender as HoaDon).Close();  
            
        }

        
    }
}
