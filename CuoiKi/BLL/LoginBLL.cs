using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CuoiKi.DAL;
namespace CuoiKi.BLL
{
    public class LoginBLL
    {
        List<Account> listacc = new List<Account>();

        private static LoginBLL instance;

        public static LoginBLL Instance
        {
            get { if (instance == null) instance = new LoginBLL(); return LoginBLL.instance; }
            private set { LoginBLL.instance = value; }
        }
        public bool checkLogin(string acc, string pass)
        {            
            listacc = AccountDAL.Instance.ListAccount();

            foreach (var i in listacc)
            {
                if (i.Account1 == acc && i.Password == pass)
                    return true;
            }
            return false;
        }
        public int Get_Emloyee_id(string acc,string position)
        {
            if (position == "Employee")
                return LoginDAL.Instance.GetID(acc);
            return 1;
        }
        public string Get_Position(string acc)
        {
            listacc = AccountDAL.Instance.ListAccount();
            foreach (var i in listacc)
            {
                if (i.Account1 == acc)
                    return i.Position;
            }
            return "";
        }
    }
}
