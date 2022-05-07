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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbx_chon_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbx_chon_item.SelectedItem != null)
            {
                lbl_ten_item.Text = cbx_chon_item.SelectedItem.ToString(); 
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(lbl_ten_item.Text);
            lv_item.Items.Add(lvi);
        }
    }
}
