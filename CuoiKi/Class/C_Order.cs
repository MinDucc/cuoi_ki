using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKi.Class
{
    class C_Order
    {
        private int id;
        private string date;
        private string customer_name;
        private int employee_id;
        private double total;

        public int Id { get => id; set => id = value; }
        public string Date { get => date; set => date = value; }
        public string Customer_name { get => customer_name; set => customer_name = value; }
        public int Employee_id { get => employee_id; set => employee_id = value; }
        public double Total { get => total; set => total = value; }

        public C_Order() { }
        public C_Order(string date,string customer_name,int emloyee_id,double total)
        {
            
            this.Date = date;
            this.Customer_name = customer_name;
            this.Employee_id = emloyee_id;
            this.Total = total;
        }
    }
}
