using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CuoiKi.DAL;
namespace CuoiKi.BLL
{
    public class StatisticalBLL
    {
        private static StatisticalBLL instance;

        internal static StatisticalBLL Instance
        {
            get { if (instance == null) instance = new StatisticalBLL(); return StatisticalBLL.instance; }
            private set { StatisticalBLL.instance = value; }
        }

        public DataTable Revenue_month(int year)
        {
            return StatisticalDAL.Instance.Revenue_month(year);
        }
        public DataTable Revenue_year()
        {
            return StatisticalDAL.Instance.Revenue_year();
        }
        public DataTable LineItem_in_year(int year)
        {
            return StatisticalDAL.Instance.LineItem_in_year(year);
        }
        public DataTable LineItem_in_month(int year,int month)
        {
            return StatisticalDAL.Instance.LineItem_in_month(year, month);
        }
        public List<int> Load_year()
        {
            return StatisticalDAL.Instance.Load_year();
        }
    }
}
