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
                         select new { Mã_Hóa_Đơn = o.order_id
                                    , Mã_Khách_Hàng = o.customer_id
                                    , Tên_Khách_Hàng = o.Customer.customer_name.ToString()
                                    ,Tên_nhân_viên=o.Employee.employee_name
                                    ,Mã_nhân_viên=o.employee_id
                                    ,Tổng_tiền=o.total
                                    ,Ngày_mua=o.order_date};
            dgv_Order.DataSource = result.ToList();
        }

        private string yeu_cau = "";
        private void Enable_All()
        {
            dt_ngaymua.Enabled = false;
            tbx_ma.Enabled = false;
            tbx_ten.Enabled = false;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbx_yeucau.SelectedItem != null)
            {
                yeu_cau = cbx_yeucau.SelectedItem.ToString();               
            }
            if (yeu_cau=="Xem hóa đơn theo ngày")
            {
                Enable_All();
                dt_ngaymua.Enabled = true;
            }
            else if(yeu_cau == "Xem hóa đơn theo mã hóa đơn")
            {
                Enable_All();
                tbx_ma.Enabled = true;
            }
            else
            {
                Enable_All();
                tbx_ten.Enabled = true;
            }    
        }
private void button1_Click(object sender, EventArgs e)
        {

        }
        private void btn_tim_Click(object sender, EventArgs e)
        {
            if (yeu_cau == "Xem hóa đơn theo ngày")
            {
                DateTime now_day = Convert.ToDateTime(dt_ngaymua.Value.ToString());
                
                var result = from o in db.Orders
                             
                             select o;
                result.ToList();
                var date = from c in result 
                           where c.order_date.Value.Year == now_day.Year &&
                                 c.order_date.Value.Month == now_day.Month &&
                                 c.order_date.Value.Day == now_day.Day
                           select new { Mã_Hóa_Đơn = c.order_id
                                    , Mã_Khách_Hàng = c.customer_id
                                    , Tên_Khách_Hàng = c.Customer.customer_name.ToString()
                                    ,Tên_nhân_viên=c.Employee.employee_name
                                    ,Mã_nhân_viên=c.employee_id
                                    ,Tổng_tiền=c.total
                                    ,Ngày_mua=c.order_date};
                 dgv_Order.DataSource = date.ToList();
                
            }
            else if (yeu_cau == "Xem hóa đơn theo mã hóa đơn")
            {
                if(tbx_ma.Text=="")
                {
                    MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm");
                    return;
                }
                int or_id = int.Parse(tbx_ma.Text);
                var result = from c in db.Orders
                             where c.order_id==or_id
                             select new { Mã_Hóa_Đơn = c.order_id
                                    , Mã_Khách_Hàng = c.customer_id
                                    , Tên_Khách_Hàng = c.Customer.customer_name.ToString()
                                    ,Tên_nhân_viên=c.Employee.employee_name
                                    ,Mã_nhân_viên=c.employee_id
                                    ,Tổng_tiền=c.total
                                    ,Ngày_mua=c.order_date};

                dgv_Order.DataSource = result.ToList();

              
            }
            else
            {
                
            }
        }

        
    }
}
