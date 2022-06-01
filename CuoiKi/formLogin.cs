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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
            AcceptButton = btn_DN;
        }                      
        private void btn_DN_Click(object sender, EventArgs e)
        {
            if (tb_account.Text == "" || tb_password.Text == "")
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu chưa nhập!","Thông báo!", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

           

            if(LoginBLL.Instance.checkLogin(tb_account.Text,tb_password.Text)==false)
            {
                
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_account.Focus();
                return;
            }
            string position = LoginBLL.Instance.Get_Position(tb_account.Text);
            int employee_id = LoginBLL.Instance.Get_Emloyee_id(tb_account.Text,position);          
            formMenu giaoDien = new formMenu(position,employee_id);
            giaoDien.Show();
            this.Hide();
            giaoDien.DangXuat += GiaoDien_DangXuat;

        }

        private void GiaoDien_DangXuat(object sender, EventArgs e)
        {
            this.Show();
            (sender as formMenu).isExit = false;
            (sender as formMenu).Close();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
