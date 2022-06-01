using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CuoiKi.DAL;
namespace CuoiKi.BLL
{
    public class AccountBLL
    {
        private static AccountBLL instance;

        public static AccountBLL Instance
        {
            get { if (instance == null) instance = new AccountBLL(); return AccountBLL.instance; }
            private set { AccountBLL.instance = value; }
        }

        public bool Add_Account(Account acc)
        {
            return AccountDAL.Instance.Add_Account(acc);
        }

        public List<Account> Get_ListAccount()
        {
            return AccountDAL.Instance.ListAccount();
        }
        public DataTable Load_Data()
        {
            return AccountDAL.Instance.Load_Data();
        }
        public bool Delete_Account(string account)
        {
            return AccountDAL.Instance.Delete_Account(account);
        }
        public void Update_Employee(Account account, string name, string acc)
        {
            AccountDAL.Instance.Update_Employee(account, name, acc);
        }
        public void Update_Admin(Account account, string acc)
        {
            AccountDAL.Instance.Update_Admin(account, acc);
        }       
    }
}
