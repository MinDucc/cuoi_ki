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
    public partial class formMenu : Form
    {
        public string position;
        public string name;
        public int id;
        public formMenu(string position,int id)
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
                btn_TaiKhoan.Enabled = false;           
            else
                btn_HoaDon.Enabled = false;
            lb_position.Text = position;
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
            formEmployee nhanvien = new formEmployee();
            nhanvien.exit = new formEmployee.Exit(formChild_Close);
            nhanvien.Show();
            this.Hide();
            nhanvien.TroVe += Nhanvien_TroVe;

        }

        private void Nhanvien_TroVe(object sender, EventArgs e)
        {
            this.Show();
            (sender as formEmployee).isExit = false;
            (sender as formEmployee).Close();
        }

        /// <summary>
        /// Su kien nut quan li
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_QLHoaDon_Click(object sender, EventArgs e)
        {
            formManagementOrder qLHoaDon = new formManagementOrder();
            qLHoaDon.exit = new formManagementOrder.Exit(formChild_Close);
            qLHoaDon.Show();
            this.Hide();
            qLHoaDon.TroVe += QLHoaDon_TroVe;
        }

        private void QLHoaDon_TroVe(object sender, EventArgs e)
        {
            this.Show();
            (sender as formManagementOrder).isExit = false;
            (sender as formManagementOrder).Close();
        }

        /// <summary>
        /// Su kien nut HangHoa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_HangHoa_Click(object sender, EventArgs e)
        {
            formItem hanghoa = new formItem();
            hanghoa.exit = new formItem.Exit(formChild_Close);
            hanghoa.Show();
            this.Hide();
            hanghoa.TroVe += Hanghoa_TroVe;
        }

        private void Hanghoa_TroVe(object sender, EventArgs e)
        {
            this.Show();
            (sender as formItem).isExit = false;
            (sender as formItem).Close();

        }

        /// <summary>
        /// Su kie nut TaiKhoan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {
            formAccount taikhoan = new formAccount();
            taikhoan.exit = new formAccount.Exit(formChild_Close);
            taikhoan.Show();
            this.Hide();
            taikhoan.TroVe += Taikhoan_TroVe;

        }

        private void Taikhoan_TroVe(object sender, EventArgs e)
        {
            this.Show();
            (sender as formAccount).isExit = false;
            (sender as formAccount).Close();
        }

        /// <summary>
        /// Su kien nut Hoa Don
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            formOrder hoadon = new formOrder(id);
            hoadon.exit = new formOrder.Exit(formChild_Close);
            hoadon.Show();
            this.Hide();
            hoadon.TroVe += Hoadon_TroVe;
        }

        private void Hoadon_TroVe(object sender, EventArgs e)
        {
            this.Show();
            (sender as formOrder).isExit = false;
            (sender as formOrder).Close();  
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            formStatistical thongke = new formStatistical();
            thongke.exit = new formStatistical.Exit(formChild_Close);
            thongke.Show();
            this.Hide();
            thongke.TroVe += Thongke_TroVe;
        }

        private void Thongke_TroVe(object sender, EventArgs e)
        {
            this.Show();
            (sender as formStatistical).isExit = false;
            (sender as formStatistical).Close();
        }
    }
}
