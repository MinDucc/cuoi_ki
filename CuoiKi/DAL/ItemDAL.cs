using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKi.DAL
{
    public class ItemDAL
    {
        ManagementDFContext db = new ManagementDFContext();
        private static ItemDAL instance;
        public static ItemDAL Instance
        {
            get { if (instance == null) instance = new ItemDAL(); return ItemDAL.instance; }
            private set { ItemDAL.instance = value; }
        }
        public List<Item> ListItem()
        {
            List<Item> lstItem = new List<Item>();
            foreach (var item in db.Items)
            {
                Item it = new Item()
                {
                    item_id = item.item_id,
                    item_name = item.item_name,
                    item_price_in = item.item_price_in,
                    item_price_out = item.item_price_out,
                    product_id = item.product_id,
                    expiry = item.expiry,
                    quantity_in_stock = item.quantity_in_stock 
                };
                lstItem.Add(it);
            }
            return lstItem;
        }

        public bool itemExit_id(int id)
        {
            try
            {
                var result = db.Items.Where(c => c.item_id == id);
                return  result.Count() > 0;
            }
            catch
            {
                return false;
            }

        }
        public bool itemExit_name(string name)
        {
            try
            {
                var result = db.Items.Where(c => c.item_name.ToLower() == name.ToLower());
                return result.Count() > 0;
            }
            catch
            {
                return false;
            }

        }
        public bool Add_Item(Item it)
        {
            try
            {
                db.Items.Add(it);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool Update_Infor(Item it)
        {
            try
            {
                var result = db.Items.Where(c => c.item_id == it.item_id);

                result.FirstOrDefault().item_name = it.item_name;
                result.FirstOrDefault().item_price_in = it.item_price_in;
                result.FirstOrDefault().item_price_out = it.item_price_out;
                result.FirstOrDefault().quantity_in_stock = it.quantity_in_stock;
                result.FirstOrDefault().expiry = it.expiry;

                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete_Item(int id)
        {
            try
            {
                Item it = db.Items.Where(c => c.item_id == id).SingleOrDefault();
                db.Items.Remove(it);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
