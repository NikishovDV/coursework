using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourceDB
{
    public class Fabricator
    {
        public int ID { get; set; }
        public string Fabricatorname { get; set; }
        public Fabricator(int iD, string fabricatorname)
        {
            ID = iD;
            Fabricatorname = fabricatorname;
        }
    }
}
