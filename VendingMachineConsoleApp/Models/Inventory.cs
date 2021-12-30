using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Models
{
    public class Inventory
    {
        public Dictionary<Slot, Item> SlotItemMenu { get; private set; }
        public Dictionary<Slot, int> SlotStockLevels { get; private set; }

        public Inventory(Dictionary<string, Item> itemData, int startingStockLevel)
        {
            SlotItemMenu = LoadSlotItemMenu(itemData);
            SlotStockLevels = LoadSlotStockLevels(SlotItemMenu, startingStockLevel);
        }

        private Dictionary<Slot, int> LoadSlotStockLevels(Dictionary<Slot, Item> slotItemMenu, int startingStockLevel)
        {
            Dictionary<Slot, int> slotStocks = new Dictionary<Slot, int>();
            foreach(KeyValuePair<Slot, Item> slotItem in slotItemMenu)
            {
                slotStocks.Add(slotItem.Key, startingStockLevel);
            }
            return slotStocks;
        }

        private Dictionary<Slot, Item> LoadSlotItemMenu(Dictionary<string, Item> itemData)
        {
            Dictionary<Slot, Item> slotItems = new Dictionary<Slot, Item>();
            foreach(KeyValuePair<string, Item> item in itemData)
            {
                slotItems.Add(GetSlotFromString(item.Key), item.Value);
            }
            return slotItems;
        }

        private static Slot GetSlotFromString(string slotString)
        {
            return (Slot)Enum.Parse(typeof(Slot), slotString);
        }
    }
}
