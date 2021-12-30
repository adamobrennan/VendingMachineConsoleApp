using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Models
{
    public class VendingMachine
    {
        private readonly Inventory inventory;

        public VendingMachine(Dictionary<string, Item> itemData, int startingStockLevel)
        {
            inventory = new Inventory(itemData, startingStockLevel);
        }

        
    }
}
