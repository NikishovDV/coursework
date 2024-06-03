using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourceDB
{
    public class Brand
    {
        public int ID { get; set; }
        public string Brandname { get; set; }
        public string Adress { get; set; }
        public Brand (int id, string brandname, string adress)
        {
            ID = id;
            Brandname = brandname;
            Adress = adress;
        }
       
    }
}
