
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CuoiKi.DAL
{
    public class AccountDAL
    {
        ManagementDFContext db = new ManagementDFContext();
        private static AccountDAL instance;

        public static AccountDAL Instance
        {
            get { if (instance == null) instance = new AccountDAL(); return AccountDAL.instance; }
            private set { AccountDAL.instance = value; }
        }
        public List<Account> ListAccount()
        {
            try
            {
                List<Account> lstacc = new List<Account>();
                var result = from acc in db.Accounts
                             select acc;
                foreach (var i in result)
                {
                    Account acc = new Account();
                    acc.Account1 = i.Account1;
                    acc.Password = i.Password;
                    acc.Position = i.Position;
                    acc.Name = i.Name;
                    lstacc.Add(acc);
                }
                return lstacc;
            }
            catch
            {
                return null;
            }
        }
        private DataTable Create_Table()
        {
            DataTable dt = new DataTable();
            DataColumn[] data = new DataColumn[]
                {new DataColumn("Tên"),
                  new DataColumn("Account"),
                  new DataColumn("Password"),
                  new DataColumn("Chức vụ"),                 
                };
            dt.Columns.AddRange(data);
            return dt;
        }
        public DataTable Load_Data()
        {
            try
            {
                var result = from acc in db.Accounts
                             select new
                             {
                                 Tên = acc.Name
                                         ,
                                 Account = acc.Account1
                                         ,
                                 Password = acc.Password
                                         ,
                                 Chức_vụ = acc.Position
                             };
                DataTable dt = Create_Table();
                foreach(var it in result)
                {
                    DataRow row = dt.NewRow();
                    row["Tên"] = it.Tên;
                    row["Account"] = it.Account;
                    row["Password"] = it.Password;
                    row["Chức vụ"] = it.Chức_vụ;
                    dt.Rows.Add(row);
                }
                return dt;

            }
            catch
            {
                return null;
            }
        }
        public bool Add_Account(Account acc)
        {
            try
            {
                db.Accounts.Add(acc);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete_Account(string account)
        {
            try
            {
                var acc = db.Accounts.Find(account);
                db.Accounts.Remove(acc);
                db.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }
        public void Update_Employee(Account account,string name,string acc)
        {
            try
            {
                var employee = from u in db.Employees where u.employee_name == name select u;
                employee.FirstOrDefault().employee_account = null;

                var acc1 = db.Accounts.Find(acc);
                db.Accounts.Remove(acc1);
                db.Accounts.Add(account);
                db.SaveChanges();
                string tmp = account.Account1;
                var employee1 = from u in db.Employees where u.employee_name == name select u;
                employee1.FirstOrDefault().employee_account = tmp;
                db.SaveChanges();
                return;
            }
            catch
            {
                return;
            }
        }
        public void Update_Admin(Account account,string acc)
        {
            try
            {
                var acc1 = db.Accounts.Find(acc);
                db.Accounts.Remove(acc1);                
                db.Accounts.Add(account);
                db.SaveChanges();
            }
            catch
            {
                return;
            }
        }
    }
}
