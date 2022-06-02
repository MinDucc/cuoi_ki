using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKi.DAL
{
    public class OrderDAL
    {
        private static OrderDAL instance;

        public static OrderDAL Instance 
        {
            get { if (instance == null) instance = new OrderDAL();return OrderDAL.instance; }
            private set { OrderDAL.instance = value; }
        }

        ManagementDFContext db = new ManagementDFContext();       
        public void Update_Quantity(int id,int sl)
        {
            var result = from it in db.Items
                         where it.item_id == id
                         select it;
            if (result != null)
            {
                result.FirstOrDefault().quantity_in_stock -= sl;
            }
            db.SaveChanges();
        }
        public int  Get_Order_ID()
        {
            var id = db.Orders.Select(c => c.order_id);
            return id.ToList().Last();
        }    
        public void Add_LineItem(int item_id, int sl)
        {
            var id = db.Orders.Select(c => c.order_id);
            db.Lineitems.Add(new Lineitem()
            {
                order_id = id.ToList().Last()
                                                 ,
                item_id = item_id
                                                 ,
                quantity = sl
            });
        }

        public Customer Customer_Infor(int id)
        {
            try
            {
                var result = from c in db.Customers
                             where c.customer_id == id
                             select c;
                if (result.Count() > 0)
                {
                    return new Customer()
                    {
                        customer_id = result.FirstOrDefault().customer_id,
                        customer_name = result.FirstOrDefault().customer_name,
                        customer_address = result.FirstOrDefault().customer_address,
                        tolal = result.FirstOrDefault().tolal
                    };
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
        public void Add_Customer(Customer cus)
        {
            try
            {
                var customer = from c in db.Customers
                               where c.customer_id == cus.customer_id
                               select c;
                if (customer.Count() > 0)
                {
                    customer.FirstOrDefault().tolal += cus.tolal;
                }
                else
                {
                    db.Customers.Add(cus);
                }
                db.SaveChanges();
            }
            catch
            {
                return;
            }

        }
        public void Add_Order(Order or,Customer cus)
        {
            Add_Customer(cus);
            db.Orders.Add(or);
            db.SaveChanges();
        }
        public void Save_DB()
        {
            db.SaveChanges();
        }
    }
}
