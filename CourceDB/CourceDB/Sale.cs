using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourceDB
{
    internal class Sale
    {
        public int ID { get; set; }
        public Tovar Tovar { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }
        public Staff Staff { get; set; }
        public DateTime Date { get; set; }
        public Sale(int id, Tovar tovar, int price, int amount, Staff staff, DateTime date) 
        {
            ID = id;
            Tovar = tovar;
            Price = price;
            Amount = amount;
            Staff = staff;
            Date = date;
        }
    }
}
