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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        ManagementDFContext db = new ManagementDFContext();       

        private void HoaDon_Load(object sender, EventArgs e)
        {
            var result = db.Items.Select(s => s.item_name);
            cbx_chon_item.DataSource = result.ToList();
            var item = db.Items.Select(s => s.item_id);
            cbx_id.DataSource = item.ToList(); 
        }
       

        private void cbx_chon_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbx_chon_item.SelectedItem != null)
            {
                var result = from c in db.Items where c.item_name == cbx_chon_item.SelectedItem.ToString() select new { Mã = c.item_id, Tên = c.item_name,Giá=c.item_price_out };
                result.ToList();
                lbl_id.Text = result.First().Mã.ToString();
                lbl_ten_item.Text = result.First().Tên;
                tb_sl.Text = "1";
                tb_dongia.Text = result.First().Giá.ToString();
            }
        }
        void Reset_Infor()
        {
            lbl_id.Text = "";
            lbl_ten_item.Text = "";
            tb_sl.Text = "";
            tb_dongia.Text = "";
        }
        private double TongTien = 0;
        private void btn_them_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem it in lv_item.Items)
            {
                if (it.Text == lbl_id.Text)
                {
                    double sl = Convert.ToDouble(tb_sl.Text);
                    double don_gia = Convert.ToDouble(tb_dongia.Text);

                    double new_sl = sl + Convert.ToDouble(it.SubItems[2].Text);
                    double new_Tong =new_sl * don_gia;
                    it.SubItems[2].Text = new_sl.ToString();//Update lại số lượng
                    it.SubItems[4].Text = new_Tong.ToString();//Update lại Tổng cộng
                    TongTien += sl * don_gia;//Update lại tổng tiền
                    lbl_TongCong.Text = TongTien.ToString();
                    Reset_Infor();
                    return;
                }
            }
            ListViewItem lvi = new ListViewItem(lbl_id.Text);
            lvi.SubItems.Add(lbl_ten_item.Text);
            lvi.SubItems.Add(tb_sl.Text);
            lvi.SubItems.Add(tb_dongia.Text);
            double tong = Convert.ToDouble(tb_sl.Text) * Convert.ToDouble(tb_dongia.Text);
            TongTien += tong;
            lvi.SubItems.Add(tong.ToString());
            lv_item.Items.Add(lvi);
            lbl_TongCong.Text = TongTien.ToString();
            Reset_Infor();
        }

        

        public event EventHandler TroVe;
        public bool isExit = true;
        private void btn_back_Click(object sender, EventArgs e)
        {
            isExit = false;
            TroVe(this, new EventArgs());
            this.Close();   
        }
        public delegate void Exit(bool exit);
        public Exit exit;
        private void HoaDon_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
            {                                                   
                 exit(true);
                 Application.Exit();                   
            }    
        }
        private void HoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(isExit)
            {
                if (MessageBox.Show("Bạn có muốn đóng form", "Thông báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }    
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (lv_item.SelectedItems.Count > 0)
            {
                lv_item.Items.Remove(lv_item.SelectedItems[0]);
            }
            else
                MessageBox.Show("Chon item de xoa!");
        }

        private void cbx_id_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
