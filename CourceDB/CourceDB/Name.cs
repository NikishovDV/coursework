using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourceDB
{
    public class Name
    {
        public int ID { get; set; }
        public string Naming { get; set; }
        public Name(int id, string naming)
        {
            ID = id;
            Naming = naming;
        }
    }
}
