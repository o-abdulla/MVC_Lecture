using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCLecture
{
    internal class ItemView
    {
        //props
        public Item DisplayItem { get; set; }

        //constructor
        public ItemView(Item _item)
        {
            DisplayItem = _item;
        }


        //methods
        public void Display()
        {
            Console.WriteLine($"Name: {DisplayItem.Name} ${DisplayItem.Price}");
        }
    }
}
