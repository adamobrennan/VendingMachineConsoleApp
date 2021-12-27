using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Models
{
    public class Item
    {
        public Item(string name, string price, string type)
        {
            Name = name;
            Price = price;
            Type = type;
        }

        public string Name { get; }
        public string Price { get; }
        public string Type { get; }
    }
}
