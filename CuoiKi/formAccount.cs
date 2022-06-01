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
    public partial class formAccount : Form
    {
        public formAccount()
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

        private bool check()
        {
            if (tbx_mk.Text.Trim() == "" || tbx_ten.Text.Trim() == "" || tbx_tk.Text.Trim() == "" || cbx_cv.Text.Trim() == "")
                return false;
            return true;
        }

        private void Reset_form()
        {
            tbx_ten.Text = "";
            tbx_tk.Text = "";
            cbx_cv.Text = "Admin";
            tbx_mk.Text = "";
        }


        private void Load_data()
        {          
            dgv_account.DataSource = AccountBLL.Instance.Load_Data();
            cbx_cv.Text = "Admin";
            cbx_cv.Enabled = false;
            dgv_account.Columns[0].Width = 150;          
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            Load_data();
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
            if (dgv_account.SelectedRows.Count > 0)
            {
                int i = dgv_account.CurrentCell.RowIndex;
                tbx_ten.Text = dgv_account.Rows[i].Cells[0].Value.ToString();
                tbx_tk.Text = dgv_account.Rows[i].Cells[1].Value.ToString();
                tbx_mk.Text = dgv_account.Rows[i].Cells[2].Value.ToString();
                cbx_cv.Text = dgv_account.Rows[i].Cells[3].Value.ToString();
            }
            if (cbx_cv.Text == "Employee")
            {
                tbx_ten.Enabled = false;
            }
            else
            {
                tbx_ten.Enabled = true;
            }
        }

        

        private void update_employee(string name, string tmp)
        {
            var employee = from u in db.Employees where u.employee_name == name select u;
            employee.FirstOrDefault().employee_account = tmp;
            db.SaveChanges();

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (check())
                {
                    DialogResult f = MessageBox.Show("Ban co chac muon them tai khoan nay khong", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (f == DialogResult.Yes)
                    {
                        if (cbx_cv.Text == "Admin")
                        {
                            Account acc = new Account()
                            {
                                Name = tbx_ten.Text,
                                Account1 = tbx_tk.Text,
                                Password = tbx_mk.Text,
                                Position = "Admin",

                            };
                            bool status = AccountBLL.Instance.Add_Account(acc);
                            if(status)
                            {
                                MessageBox.Show("Thêm thành công");
                            }
                            else
                            {
                                MessageBox.Show("Thêm thất bại");
                            }    
                        }
                        else
                            MessageBox.Show("Vui lòng thêm thông tin cho nhân viên!!");
                    }
                    Reset_form();
                    Load_data();
                }
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!");
            }
            catch
            {
                MessageBox.Show("Thông tin không hợp lệ!!");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (check())
                {
                    if (dgv_account.SelectedRows.Count > 0)
                    {
                        DialogResult f = MessageBox.Show("Ban co chac muon xoa tai khoan nay khong", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (f == DialogResult.Yes)
                        {
                            if (cbx_cv.Text == "Admin")
                            {
                                int i = dgv_account.CurrentCell.RowIndex;
                                string account = dgv_account.Rows[i].Cells[1].Value.ToString();
                                bool status = AccountBLL.Instance.Delete_Account(account);
                                if (status)
                                    MessageBox.Show("Xóa thành công");
                                else
                                    MessageBox.Show("Xóa thất bại");
                            }
                            else
                                MessageBox.Show("Vui lòng xóa thông tin nhân viên");
                        }
                        Reset_form();
                        Load_data();
                    }
                    else
                        MessageBox.Show("Vui lòng chọn hàng muốn xóa!!");
                }
                else
                    MessageBox.Show("vui lòng nhập đầy đủ thông tin");
            }
            catch
            {
                MessageBox.Show("Thông tin không hợp lệ!!");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (check())
                {
                    if (dgv_account.SelectedRows.Count > 0)
                    {
                        DialogResult f = MessageBox.Show("Ban co chac muon sua tai khoan nay khong", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (f == DialogResult.Yes)
                        {
                            int i = dgv_account.CurrentCell.RowIndex;
                            string acc = dgv_account.Rows[i].Cells[1].Value.ToString();
                            string name = dgv_account.Rows[i].Cells[0].Value.ToString();

                            if (cbx_cv.Text == "Employee")
                            {                               
                                Account account = new Account()
                                {
                                    Name = tbx_ten.Text,
                                    Account1 = tbx_tk.Text.Trim(),
                                    Password = tbx_mk.Text,
                                    Position = "Employee",
                                };
                                AccountBLL.Instance.Update_Employee(account, name, acc);                                                        
                            }
                            else if (cbx_cv.Text == "Admin")
                            {                               
                                Account account = new Account()
                                {
                                    Name = tbx_ten.Text,
                                    Account1 = tbx_tk.Text.Trim(),
                                    Password = tbx_mk.Text,
                                    Position = "Admin",
                                };
                                AccountBLL.Instance.Update_Admin(account, acc);
                            }
                        }                     
                        Reset_form();
                        Load_data();
                    }
                    else
                        MessageBox.Show("Vui long chon hang muon chinh sua!!");
                }
                else
                    MessageBox.Show("Vui long nhap day du thong tin!!");
            }
            catch
            {
                MessageBox.Show("Thong tin khong hop le!!");
            }
        }

        
    }
}
