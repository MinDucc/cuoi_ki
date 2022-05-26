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
        private void Set_nameCol()
        {
            dgv_show.Columns[0].HeaderText = "Mã sản phẩm";
            dgv_show.Columns[1].HeaderText = "Tên sản phẩm";
            dgv_show.Columns[1].Width = 140;
            dgv_show.Columns[2].HeaderText = "Số lượng trong kho";
            dgv_show.Columns[3].HeaderText = "Giá nhập";
            dgv_show.Columns[4].HeaderText = "Giá bán";
            dgv_show.Columns[5].HeaderText = "Hạn sử dụng";
        }
        
        private void Load_Data()
        {
            var result = from c in db.Items
                         select new { 
                             Mã=c.item_id,
                             Tên = c.item_name,
                             Số_Lượng = c.quantity_in_stock,
                             Giá_nhập = c.item_price_in,
                             Giá_bán = c.item_price_out,
                             Hạn_sử_dụng = c.expiry
                         };
            dgv_show.DataSource = result.ToList();
            Set_nameCol();
        }
        private void Enable_button()
        {
            bt_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
        }
        private void HangHoa_Load(object sender, EventArgs e)
        {
            //Đưa vào ListView
            Enable_button();
            Load_Data();
        }
        private void dgv_show_SelectionChanged(object sender, EventArgs e)
                {
                    int i;
                    i = dgv_show.CurrentRow.Index;
                    tbx_mahang.Text = dgv_show.Rows[i].Cells[0].Value.ToString();
                    tbx_tenhang.Text = dgv_show.Rows[i].Cells[1].Value.ToString();
                    tbx_hangton.Text = dgv_show.Rows[i].Cells[2].Value.ToString();
                    tbx_giamua.Text = dgv_show.Rows[i].Cells[3].Value.ToString();
                    tbx_giaban.Text = dgv_show.Rows[i].Cells[4].Value.ToString();
                    dt_hsd.Value = Convert.ToDateTime( dgv_show.Rows[i].Cells[5].Value);
                }
        private void btn_hangton_Click(object sender, EventArgs e)
        {

            var result = from c in db.Items
                         where c.quantity_in_stock <= 10
                         select new
                         {
                             Mã = c.item_id,
                             Tên = c.item_name,
                             Số_Lượng = c.quantity_in_stock,
                             Giá_nhập = c.item_price_in,
                             Giá_bán = c.item_price_out,
                             Hạn_sử_dụng = c.expiry
                         };
            dgv_show.DataSource = result.ToList();
            Set_nameCol();
        }

        private void btn_hsd_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now.Date;// ngay hien tai
            var result = from c in db.Items
                         where DateTime.Compare(c.expiry.Value, now) < 0
                         select new 
                         {
                             Mã = c.item_id,
                             Tên = c.item_name,
                             Số_Lượng = c.quantity_in_stock,
                             Giá_nhập = c.item_price_in,
                             Giá_bán = c.item_price_out,
                             Hạn_sử_dụng = c.expiry
                         };
            dgv_show.DataSource = result.ToList();
            Set_nameCol();

        }
        private bool check_itemExit()
        {
            int id = int.Parse(tbx_mahang.Text);
            var result = db.Items.Select(c => c.item_id == id);
            return result.Count() > 0;
        }    
        private void bt_them_Click(object sender, EventArgs e)
        {
            if (tbx_tenhang.Text == "" || tbx_giamua.Text == "" || tbx_giaban.Text == "" || tbx_hangton.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }
            if(check_itemExit())
            {
                MessageBox.Show("Mặc hàng này đã có trong cửa hàng");
                return;
            }    
            db.Items.Add(new Item()
            {
                item_name = tbx_tenhang.Text,
                item_price_in = Convert.ToDouble(tbx_giamua.Text),
                item_price_out = Convert.ToDouble(tbx_giaban.Text),
                quantity_in_stock = int.Parse(tbx_hangton.Text),
                expiry = Convert.ToDateTime(dt_hsd.Value)
            });
            db.SaveChanges();
            Load_Data();
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            Load_Data();
        }
        private void xoa_thongtin()
        {
            tbx_mahang.Text = "";
            tbx_tenhang.Text = "";
            tbx_hangton.Text = "";
            tbx_giamua.Text = "";
            tbx_giaban.Text = "";
        }
        private void ckb_them_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_them.Checked == true)
            {
                if(ckb_xoa.Checked ==true || ckb_sua.Checked == true)
                {
                    ckb_them.Checked = false;
                    return;
                }
                xoa_thongtin();
                bt_them.Enabled = true;
            }
            else
            {
                bt_them.Enabled = false;
            }  
        }
        
        private void ckb_sua_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_sua.Checked == true)
            {
                if(ckb_them.Checked == true || ckb_xoa.Checked == true)
                {
                    ckb_sua.Checked = false;
                    return;
                }    
                btn_sua.Enabled = true;
            }
            else
            {
                btn_sua.Enabled = false;
            }
        }

        private void ckb_xoa_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_xoa.Checked == true)
            {
                if(ckb_sua.Checked == true || ckb_them.Checked == true)
                {
                    ckb_xoa.Checked = false;
                    return;
                }    
                btn_xoa.Enabled = true;
            }
            else
            {
                btn_xoa.Enabled = false;
            }


            //btn_xoa.Enabled = ckb_xoa.Checked == true ? true : false;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tbx_mahang.Text);
                var result = db.Items.Where(c => c.item_id == id);

                result.FirstOrDefault().item_name = tbx_tenhang.Text;
                result.FirstOrDefault().item_price_in = Convert.ToDouble(tbx_giamua.Text);
                result.FirstOrDefault().item_price_out = Convert.ToDouble(tbx_giaban.Text);
                result.FirstOrDefault().quantity_in_stock = int.Parse(tbx_hangton.Text);
                result.FirstOrDefault().expiry = dt_hsd.Value;

                db.SaveChanges();

                Load_Data();
            }
            catch
            {
                MessageBox.Show("Không sửa được");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbx_mahang.Text);
            try
            {
                Item it = db.Items.Where(c => c.item_id == id).SingleOrDefault();
                db.Items.Remove(it);
                db.SaveChanges();
                Load_Data();
            }
            catch
            {
                MessageBox.Show("Không xóa được");
            }
            
        }
    }
}
