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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        ManagementDFContext db = new ManagementDFContext();
        private string position;
        public bool CheckAccount()
        {
            var listAcc = from acc in db.Accounts 
                          where acc.Account1 == tb_account.Text
                          select acc;
            listAcc.ToList();
            if (listAcc.Count()!=0)
            {
                if (listAcc.First().Password == tb_password.Text)
                {
                    position = listAcc.First().Position;
                    return true;
                }    
            }    
            return false;
            
        }
        private void btn_DN_Click(object sender, EventArgs e)
        {
            if (tb_account.Text == "" || tb_password.Text == "")
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu chưa nhập!");
                return;
            }
            
            if(CheckAccount()==false)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                tb_account.Focus();
                return;
            }    
            GiaoDien giaoDien = new GiaoDien(position);
            giaoDien.Show();
            this.Hide();
            giaoDien.DangXuat += GiaoDien_DangXuat;

        }

        private void GiaoDien_DangXuat(object sender, EventArgs e)
        {
            this.Show();
            (sender as GiaoDien).isExit = false;
            (sender as GiaoDien).Close();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
