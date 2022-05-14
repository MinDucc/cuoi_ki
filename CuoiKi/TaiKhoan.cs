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
    public partial class TaiKhoan : Form
    {
        public TaiKhoan()
        {
            InitializeComponent();
        }
        ManagementDFContext db = new ManagementDFContext();
        public bool isExit = true;
        public event EventHandler TroVe;
        private void btn_back_Click(object sender, EventArgs e)
        {
            TroVe(this, new EventArgs());
            this.Close();
        }
        public delegate void Exit(bool exit);
        public Exit exit;
        private void Account_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
            {
                exit(true);
                Application.Exit();
            }
        }

        private void TaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn có muốn đóng form", "Thông báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            var result = from acc in db.Accounts
                         select new { Tên=acc.Name
                                     ,Account=acc.Account1
                                     ,Password = acc.Password
                                     ,Chức_vụ=acc.Position };

            dgv_account.DataSource = result.ToList();
        }
        private void Load_infor(int i)
        {
            tbx_ten.Text = dgv_account.Rows[i].Cells[0].Value.ToString();
            tbx_tk.Text = dgv_account.Rows[i].Cells[1].Value.ToString();
            tbx_mk.Text = dgv_account.Rows[i].Cells[2].Value.ToString();
            cbx_cv.Text = dgv_account.Rows[i].Cells[3].Value.ToString();
        }
        

        private void dgv_account_SelectionChanged(object sender, EventArgs e)
        {
            int i;
            i = dgv_account.CurrentCell.RowIndex;
            Load_infor(i);
        }
    }
}
