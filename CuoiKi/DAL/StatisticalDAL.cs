using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CuoiKi.DAL
{
    public class StatisticalDAL
    {
        ManagementDFContext db = new ManagementDFContext();
        private static StatisticalDAL instance;

        internal static StatisticalDAL Instance
        {
            get { if (instance == null) instance = new StatisticalDAL(); return StatisticalDAL.instance; }
            private set { StatisticalDAL.instance = value; }
        }

        public DataTable Revenue_month(int year)
        {
            try
            {
                var result = from c in db.Orders
                             where c.order_date.Value.Year == year
                             group c by c.order_date.Value.Month;

                DataTable dt = new DataTable();
                DataColumn thang = new DataColumn("Thang");
                dt.Columns.Add(thang);
                DataColumn tong = new DataColumn("Total");
                dt.Columns.Add(tong);
                foreach (var key in result)
                {
                    var kq = key.Sum(c => c.total);
                    DataRow row = dt.NewRow();
                    row["Total"] = kq;
                    row["Thang"] = key.Key;
                    dt.Rows.Add(row);
                }
                return dt;
            }
            catch
            {
                return null;
            }

        }
        public DataTable Revenue_year()
        {
            try
            {
                var result = from c in db.Orders

                             group c by c.order_date.Value.Year;

                DataTable dt = new DataTable();
                DataColumn Year = new DataColumn("Year");
                dt.Columns.Add(Year);
                DataColumn Total = new DataColumn("Total");
                dt.Columns.Add(Total);
                foreach (var key in result)
                {
                    var kq = key.Sum(c => c.total);
                    DataRow row = dt.NewRow();
                    row["Total"] = kq;
                    row["Year"] = key.Key;
                    dt.Rows.Add(row);
                }
                return dt;
            }
            catch
            {
                return null;
            }
        } 
        public DataTable LineItem_in_year(int year)
        {
            try
            {
                DataTable dt = new DataTable();
                var kq = db.Doanhthu_thang(year).Select(c => c);
                DataColumn Ten = new DataColumn("Ten");
                dt.Columns.Add(Ten);
                DataColumn SL = new DataColumn("SL");
                dt.Columns.Add(SL);
                DataColumn doanhThu = new DataColumn("Doanh thu");
                dt.Columns.Add(doanhThu);

                foreach (var key in kq)
                {
                    DataRow row = dt.NewRow();
                    row["Ten"] = key.item_name;
                    row["SL"] = key.tong;
                    row["Doanh thu"] = key.doanhthu;
                    dt.Rows.Add(row);
                }
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public DataTable LineItem_in_month(int year,int month)
        {
            try
            {
                DataTable dt = new DataTable();
                var kq = db.Doanhthu_tung_thang(year, month).Select(c => c);
                DataColumn Ten = new DataColumn("Ten");
                dt.Columns.Add(Ten);
                DataColumn SL = new DataColumn("SL");
                dt.Columns.Add(SL);
                DataColumn doanhThu = new DataColumn("Doanh thu");
                dt.Columns.Add(doanhThu);

                foreach (var key in kq)
                {
                    DataRow row = dt.NewRow();
                    row["Ten"] = key.item_name;
                    row["SL"] = key.tong;
                    row["Doanh thu"] = key.doanhthu;
                    dt.Rows.Add(row);
                }
                return dt;
            }   
            catch
            {
                return null;
            }
        }
        public List<int> Load_year()
        {
            var result = db.Orders.GroupBy(c => c.order_date.Value.Year);
            List<int> nam = new List<int>();
            foreach(var i in result)
            {
                nam.Add(i.Key);
            }    
            return nam;
        }    
    }
}
