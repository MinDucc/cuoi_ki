using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuoiKi.Class;

namespace CuoiKi
{
    public partial class HangHoa : Form
    {
        public bool isExit = true;
        public event EventHandler TroVe;
        ManagementDFContext db = new ManagementDFContext();
        //List<C_Item> ListItem= new List<C_Item>();
        public HangHoa()
        {
            InitializeComponent();
        }
        /*
        private void DowListItem()
        {
            ListItem = new List<C_Item>();
            foreach (var item in db.Items)
            {
                C_Item it = new C_Item(item.item_id, item.item_name,
                                       Convert.ToInt32(item.quantity_in_stock),
                                        Convert.ToDouble(item.item_price_in),
                                        Convert.ToDouble(item.item_price_out),
                                        item.expiry.ToString());
            }    
        }
        */
        private void btn_back_Click(object sender, EventArgs e)
        {
            TroVe(this, new EventArgs());
            this.Close();
        }
        public delegate void Exit(bool exit);
        public Exit exit;
        private void HangHoa_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
            {
                exit(true);
                Application.Exit();
            }
        }

        private void HangHoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn có muốn đóng form", "Thông báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }

        }

        private void HangHoa_Load(object sender, EventArgs e)
        {
            //Đưa vào ListView
            foreach (var item in db.Items)
            {
                ListViewItem lvi = new ListViewItem(item.item_id.ToString());
                lvi.SubItems.Add(item.item_name);
                lvi.SubItems.Add(item.quantity_in_stock.ToString());
                lvi.SubItems.Add(item.item_price_out.ToString());
                lvi.SubItems.Add(item.item_price_in.ToString());
                lvi.SubItems.Add(item.expiry.ToString());
                lv_hanghoa.Items.Add(lvi);
            }
        }
    }
}
