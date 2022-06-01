using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CuoiKi.DAL
{
    public class ManagementOrderDAL
    {
        ManagementDFContext db = new ManagementDFContext();
        private static ManagementOrderDAL instance;
        public static ManagementOrderDAL Instance
        {
            get { if (instance == null) instance = new ManagementOrderDAL(); return ManagementOrderDAL.instance; }
            private set { ManagementOrderDAL.instance = value; }
        }
        private DataTable Create_Table()
        {
            DataTable dt = new DataTable();
            DataColumn[] data = new DataColumn[]
                {new DataColumn("order_id"),
                  new DataColumn("customer_id"),
                  new DataColumn("customer_name"),
                  new DataColumn("employee_name"),
                  new DataColumn("employee_id"),
                  new DataColumn("total"),
                  new DataColumn("order_date")

                };
            dt.Columns.AddRange(data);
            return dt;
        }
        public DataTable Load_Data()
        {
            try
            {
                var result = from o in db.Orders
                             select new
                             {
                                 Mã_Hóa_Đơn = o.order_id
                                        ,
                                 Mã_Khách_Hàng = o.customer_id
                                        ,
                                 Tên_Khách_Hàng = o.Customer.customer_name.ToString()
                                        ,
                                 Tên_nhân_viên = o.Employee.employee_name
                                        ,
                                 Mã_nhân_viên = o.employee_id
                                        ,
                                 Tổng_tiền = o.total
                                        ,
                                 Ngày_mua = o.order_date
                             };
                DataTable dt = Create_Table();
                foreach (var it in result)
                {
                    DataRow row = dt.NewRow();
                    row["order_id"] = it.Mã_Hóa_Đơn;
                    row["customer_id"] = it.Mã_Khách_Hàng;
                    row["customer_name"] = it.Tên_Khách_Hàng;
                    row["employee_name"] = it.Tên_nhân_viên;
                    row["employee_id"] = it.Mã_nhân_viên;
                    row["total"] = it.Tổng_tiền;
                    row["order_date"] = it.Ngày_mua;
                    dt.Rows.Add(row);
                }
                return dt;
            }
            catch
            {
                return null;
            }

        }
        
        public DataTable Search_by_Date(DateTime now_day)
        {
            try
            {
                var result = from o in db.Orders
                             select o;
                result.ToList();
                var date = from c in result
                           where c.order_date.Value.Year == now_day.Year &&
                                 c.order_date.Value.Month == now_day.Month &&
                                 c.order_date.Value.Day == now_day.Day
                           select new
                           {
                               Mã_Hóa_Đơn = c.order_id
                                    ,
                               Mã_Khách_Hàng = c.customer_id
                                    ,
                               Tên_Khách_Hàng = c.Customer.customer_name.ToString()
                                    ,
                               Tên_nhân_viên = c.Employee.employee_name
                                    ,
                               Mã_nhân_viên = c.employee_id
                                    ,
                               Tổng_tiền = c.total
                                    ,
                               Ngày_mua = c.order_date
                           };
                DataTable dt = Create_Table();
                foreach (var it in date)
                {
                    DataRow row = dt.NewRow();
                    row["order_id"] = it.Mã_Hóa_Đơn;
                    row["customer_id"] = it.Mã_Khách_Hàng;
                    row["customer_name"] = it.Tên_Khách_Hàng;
                    row["employee_name"] = it.Tên_nhân_viên;
                    row["employee_id"] = it.Mã_nhân_viên;
                    row["total"] = it.Tổng_tiền;
                    row["order_date"] = it.Ngày_mua;
                    dt.Rows.Add(row);
                }
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public DataTable Search_by_id(int id)
        {
            try
            {
                var result = from c in db.Orders
                             where c.order_id == id
                             select new
                             {
                                 Mã_Hóa_Đơn = c.order_id
                                    ,
                                 Mã_Khách_Hàng = c.customer_id
                                    ,
                                 Tên_Khách_Hàng = c.Customer.customer_name.ToString()
                                    ,
                                 Tên_nhân_viên = c.Employee.employee_name
                                    ,
                                 Mã_nhân_viên = c.employee_id
                                    ,
                                 Tổng_tiền = c.total
                                    ,
                                 Ngày_mua = c.order_date
                             };

                DataTable dt = Create_Table();
                foreach (var it in result)
                {
                    DataRow row = dt.NewRow();
                    row["order_id"] = it.Mã_Hóa_Đơn;
                    row["customer_id"] = it.Mã_Khách_Hàng;
                    row["customer_name"] = it.Tên_Khách_Hàng;
                    row["employee_name"] = it.Tên_nhân_viên;
                    row["employee_id"] = it.Mã_nhân_viên;
                    row["total"] = it.Tổng_tiền;
                    row["order_date"] = it.Ngày_mua;
                    dt.Rows.Add(row);
                }
                return dt;

            }
            catch
            {
                return null;
            }
        } 
        
        public DataTable Search_by_customer_name(string name)
        {
            try
            {
                var order = from o in db.Orders
                             select o;
                order.ToList();
                var cus = from c in order
                          where c.Customer.customer_name.ToLower().Contains(name.ToLower())
                           select new
                           {
                               Mã_Hóa_Đơn = c.order_id
                                    ,
                               Mã_Khách_Hàng = c.customer_id
                                    ,
                               Tên_Khách_Hàng = c.Customer.customer_name.ToString()
                                    ,
                               Tên_nhân_viên = c.Employee.employee_name
                                    ,
                               Mã_nhân_viên = c.employee_id
                                    ,
                               Tổng_tiền = c.total
                                    ,
                               Ngày_mua = c.order_date
                           };
                DataTable dt = Create_Table();
                foreach (var it in cus)
                {
                    DataRow row = dt.NewRow();
                    row["order_id"] = it.Mã_Hóa_Đơn;
                    row["customer_id"] = it.Mã_Khách_Hàng;
                    row["customer_name"] = it.Tên_Khách_Hàng;
                    row["employee_name"] = it.Tên_nhân_viên;
                    row["employee_id"] = it.Mã_nhân_viên;
                    row["total"] = it.Tổng_tiền;
                    row["order_date"] = it.Ngày_mua;
                    dt.Rows.Add(row);
                }
                return dt;
            }
            catch
            {
                return null;
            }
        }

    }
}
