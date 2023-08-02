using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCLecture
{
    internal class ItemListView
    {
        //props
        public List<Item> AllItems { get; set; }

        //constructor
        public ItemListView(List<Item> _allItems)
        {
            AllItems = _allItems;
        }

        //methods
        public void Display()
        {
            for (int i = 0; i < AllItems.Count; i++)
            {
                Console.WriteLine($"{i}. {AllItems[i].Name}");
            }
        }
    }
}
