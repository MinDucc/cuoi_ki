using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CuoiKi.DAL;

namespace CuoiKi.BLL
{
    public class ManagementOrderBLL
    {
        private static ManagementOrderBLL instance;
        public static ManagementOrderBLL Instance
        {
            get { if (instance == null) instance = new ManagementOrderBLL(); return ManagementOrderBLL.instance; }
            private set { ManagementOrderBLL.instance = value; }
        }
        public DataTable Load_Data()
        {
            return ManagementOrderDAL.Instance.Load_Data();
        }

        public DataTable Search_by_date(DateTime now_day)
        {
            return ManagementOrderDAL.Instance.Search_by_Date(now_day);
        } 
        public DataTable Search_by_id(int id)
        {
            return ManagementOrderDAL.Instance.Search_by_id(id);
        }
        public DataTable Search_by_customer_name(string name)
        {
            return ManagementOrderDAL.Instance.Search_by_customer_name(name);
        }
    }

}
