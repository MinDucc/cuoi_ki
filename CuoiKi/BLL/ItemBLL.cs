using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CuoiKi.DAL;
namespace CuoiKi.BLL
{
    public class ItemBLL
    {
        private static ItemBLL instance;
        public static ItemBLL Instance
        {
            get { if (instance == null) instance = new ItemBLL(); return ItemBLL.instance; }
            private set { ItemBLL.instance = value; }
        }
        public List<Item> Get_ListItem()
        {
            return ItemDAL.Instance.ListItem();
        }
        public bool Check_Item_Exit(int id,string name)
        {
            if (id == 0)
                return ItemDAL.Instance.itemExit_name(name);
            return ItemDAL.Instance.itemExit_id(id);
        }
        public bool Add_Item(Item it)
        {
            return ItemDAL.Instance.Add_Item(it);
        }
        public bool Update_Infor(Item it)
        {
            return ItemDAL.Instance.Update_Infor(it);
        }
        public bool Delete_Item(int id)
        {
            return ItemDAL.Instance.Delete_Item(id);
        }

    }
}
