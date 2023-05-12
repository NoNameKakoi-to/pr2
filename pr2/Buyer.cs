using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    internal class Buyer
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public Buyer(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }
    }
}
