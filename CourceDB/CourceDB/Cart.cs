using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourceDB
{
    internal class Cart
    {
        public int ID { get; set; }
        public Tovar Tovar { get; set; }
        public Client Client { get; set; }
        public Cart(int id, Tovar tovar, Client client) 
        {
            ID = id;
            Tovar = tovar;
            Client = client;
        }
    }
}
