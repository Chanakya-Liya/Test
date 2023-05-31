using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Pizza
    {
        public string size;
        public List<string> toppings;
        public int price = 0;

        public Pizza(string size)
        {
            this.size = size;
            toppings = new List<string>();
        }
    }
}
