using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourceDB
{
    public class Material
    {
        public int ID { get; set; }
        public string Materialname { get; set; }
        public string Description { get; set; }
        public Material(int iD, string materialname, string description)
        {
            ID = iD;
            Materialname = materialname;
            Description = description;
        }
    }
}
