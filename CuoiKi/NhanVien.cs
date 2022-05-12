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
    public partial class NhanVien : Form
    {
        public bool isExit = true;
        public event EventHandler TroVe;
        ManagementDFContext db = new ManagementDFContext();
        public NhanVien()
        {
            InitializeComponent();
        }
       
        private void btn_back_Click(object sender, EventArgs e)
        {
            TroVe(this, new EventArgs());
            this.Close();
        }

        public delegate void Exit(bool exit);
        public Exit exit;
        private void NhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
            {
                exit(true);
                Application.Exit();
            }
        }

        private void NhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn có muốn đóng form", "Thông báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            //Đưa vào ListView
            foreach(var row in db.Employees)
            {
                ListViewItem lvi = new ListViewItem(row.employee_id.ToString());
                lvi.SubItems.Add(row.employee_name);
                lvi.SubItems.Add(row.phone);
                lvi.SubItems.Add(row.address);
                lvi.SubItems.Add(row.birth.ToString());
                lvi.SubItems.Add(row.shift);
                lvi.SubItems.Add(row.salary.ToString());
                lv_nhanvien.Items.Add(lvi);
            }    


        }

        private void lv_nhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
