using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuoiKi.BLL;
namespace CuoiKi
{
    public partial class formManagementOrder : Form
    {
        public formManagementOrder()
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

        private void Load_Data()
        {
            dgv_Order.DataSource = ManagementOrderBLL.Instance.Load_Data();
            
        }
        private void QLHoaDon_Load(object sender, EventArgs e)
        {


            Load_Data();
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
        private void btn_tim_Click(object sender, EventArgs e)
        {
            if (yeu_cau == "Xem hóa đơn theo ngày")
            {
                DateTime now_day = Convert.ToDateTime(dt_ngaymua.Value.ToString());

                dgv_Order.DataSource = ManagementOrderBLL.Instance.Search_by_date(now_day);
                
            }
            else if (yeu_cau == "Xem hóa đơn theo mã hóa đơn")
            {
                if(tbx_ma.Text=="")
                {
                    MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm");
                    return;
                }
                try
                {
                    int or_id = int.Parse(tbx_ma.Text);
                    dgv_Order.DataSource = ManagementOrderBLL.Instance.Search_by_id(or_id);
                } 
                catch
                {
                    MessageBox.Show("Thông tin nhập không hợp lệ!!!");
                }     
            }
            else
            {
                string customer_name = tbx_ten.Text;
                dgv_Order.DataSource = ManagementOrderBLL.Instance.Search_by_customer_name(customer_name);
            }
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            Load_Data();
        }
    }
}
