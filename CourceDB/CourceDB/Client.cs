using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourceDB
{
    public class Client
    {
        public int ID {  get; set; }
        public string Login { get; set; }

        public Client(int id, string login) 
        {
            ID = id;
            Login = login;
        }
    }
}
