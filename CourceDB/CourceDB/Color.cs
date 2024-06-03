using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourceDB
{
    public class Color
    {
        public int ID {  get; set; }
        public string Colorname { get; set; }
        public string Hex_kod { get; set; }
        public Color(int id, string colorname, string hex_kod)
        {
            ID = id;
            Colorname = colorname;
            Hex_kod = hex_kod;
        }
    }
}
