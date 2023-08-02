using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCLecture
{
    internal class Item
    {
        //props
        public string Name { get; set; }
        public decimal Price { get; set; }

        //constructors
        public Item(string _name, decimal _price)
        {
            Name = _name;
            Price = _price;
        }
    }
}
