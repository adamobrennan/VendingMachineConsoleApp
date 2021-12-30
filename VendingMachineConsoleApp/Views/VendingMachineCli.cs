using System;
using System.Collections.Generic;
using VendingMachineConsoleApp.FileIO;
using VendingMachineConsoleApp.Models;

namespace VendingMachineConsoleApp.Views
{
    public class VendingMachineCli
    {
        private const string errorExitMessage = "Exiting due to errors.";
        private readonly IMenuService menu;
        private readonly VendingMenuOptions options;
        private readonly Dictionary<string, Item> itemData;
        private readonly Item errorValue = null;


        public VendingMachineCli(IMenuService menu, VendingMenuOptions options, Dictionary<string, Item> itemData)
        {
            this.menu = menu;
            this.options = options;
            this.itemData = itemData;
        }

        public void Run()
        {
            if (itemData.ContainsValue(errorValue))
            {
                ExitDueToErrors(itemData);
            }

            RunVendingMenu(itemData);
            Environment.Exit(0);
        }

        private void RunVendingMenu(Dictionary<string, Item> itemData)
        {
            menu.GetChoiceFromOptions(options.MAIN_MENU_OPTIONS);
        }

        private void ExitDueToErrors(Dictionary<string, Item> itemData)
        {
            string[] errorMessages = new string[itemData.Count];
            itemData.Keys.CopyTo(errorMessages, 0);
            foreach (string error in errorMessages)
            {
                menu.PrintMessage(error);
            }
            menu.PrintMessage(errorExitMessage);
            Environment.Exit(1);
        }
    }
}
