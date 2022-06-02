using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CuoiKi.DAL;
namespace CuoiKi.BLL
{
    class OrderBLL
    {
        private static OrderBLL instance;

        internal static OrderBLL Instance 
        { 
            get { if (instance == null) instance = new OrderBLL();return OrderBLL.instance; }
            private set { OrderBLL.instance = value; }
        }       
        
        public void Update_Quantity(int id,int sl)
        {
            OrderDAL.Instance.Update_Quantity(id, sl);
        }

        public int Get_Order_ID()
        {
            return OrderDAL.Instance.Get_Order_ID();
        }    
        public void Add_LineItem(int item_id,int sl)
        {
            OrderDAL.Instance.Add_LineItem(item_id, sl);
        }

        public Customer Get_Customer_Infor(int id)
        {
            return OrderDAL.Instance.Customer_Infor(id);
        }
       

        public void Add_Order(Order or,Customer cus)
        {
            OrderDAL.Instance.Add_Order(or,cus);
        }
        public void Save_DB()
        {
            OrderDAL.Instance.Save_DB();
        }
    }
}
