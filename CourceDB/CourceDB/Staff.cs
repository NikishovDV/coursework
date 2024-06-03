using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourceDB
{
    internal class Staff
    {
        public int ID {  get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public long Phone {  get; set; }
        public string Position { get; set; }
        public Staff(int id, string surname, string name, long phone, string position) 
        {
            ID = id;
            Surname = surname;
            Name = name;
            Phone = phone;
            Position = position;
        }
    }
}
