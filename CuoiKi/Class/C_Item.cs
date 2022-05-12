using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKi.Class
{
    class C_Item
    {

        private int id;
        private string name;
        private int quantity;
        private double price_in;
        private double price_out;
        private string expiry;

        
        //Get and Set
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Price_in { get => price_in; set => price_in = value; }
        public double Price_out { get => price_out; set => price_out = value; }
        public string Expiry { get => expiry; set => expiry = value; }
        
        public C_Item(int id,string name,int quatity,double price_in,double price_out,string expiry)
        {
            this.Id = id;
            this.Name = name;
            this.Quantity = quatity;
            this.Price_in = price_in;
            this.Price_out = price_out;
            this.Expiry = expiry;
        }
    }
}
