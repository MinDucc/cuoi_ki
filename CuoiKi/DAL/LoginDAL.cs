using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKi.DAL
{
    public class LoginDAL
    {
        private static LoginDAL instance;
        public static LoginDAL Instance
        {
            get { if (instance == null) instance = new LoginDAL(); return LoginDAL.instance; }
            private set { LoginDAL.instance = value; }
        }
        ManagementDFContext db = new ManagementDFContext();
        
        public int GetID(string acc)
        {
            var emloyee_id = from nv in db.Employees
                             where nv.employee_account == acc
                             select nv;
            return emloyee_id.FirstOrDefault().employee_id;
        }
        
    }
}
