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
    public partial class QLHoaDon : Form
    {
        public QLHoaDon()
        {
            InitializeComponent();
        }
        public bool isExit = true;
        public event EventHandler TroVe;
        private void btn_back_Click(object sender, EventArgs e)
        {
            TroVe(this, new EventArgs());
            this.Close();
        }
        ManagementDFContext db = new ManagementDFContext();
        public delegate void Exit(bool exit);
        public Exit exit;
        private void QLHoaDon_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
            {
                exit(true);
                Application.Exit();
            }
        }

        private void QLHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn có muốn đóng form", "Thông báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void QLHoaDon_Load(object sender, EventArgs e)
        {
            
            var result = from o in db.Orders 
                         select new { Mã=o.order_id
                                    , Tên_Khách_Hàng=o.customer_name
                                    ,Tên_nhân_viên=o.Employee.employee_name
                                    ,Mã_nhân_viên=o.employee_id
                                    ,Tổng_tiền=o.total
                                    ,Ngày_mua=o.order_date};
            dgv_Order.DataSource = result.ToList();
        }
    }
}
