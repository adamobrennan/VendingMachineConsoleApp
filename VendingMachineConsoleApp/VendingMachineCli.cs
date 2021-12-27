using System;
using System.Collections.Generic;
using System.Text;
using VendingMachineConsoleApp.Interfaces;
using VendingMachineConsoleApp.Models;
using VendingMachineConsoleApp.Views;

namespace VendingMachineConsoleApp
{
    public class VendingMachineCli
    {
        private readonly IMenuService menu;
        private readonly VendingMenuOptions options;
        private readonly IFileInputHandler fileInput;
        private readonly Item errorValue = null;


        public VendingMachineCli(IMenuService menu, VendingMenuOptions options, IFileInputHandler fileInput)
        {
            this.menu = menu;
            this.options = options;
            this.fileInput = fileInput;
        }

        public void Run()
        {
            Dictionary<string, Item> itemData = fileInput.ItemData;

            if (itemData.ContainsValue(errorValue))
            {
                ExitDueToErrors(itemData);
            }

            RunVendingMenu(itemData);
        }

        private void RunVendingMenu(Dictionary<string, Item> itemData)
        {
            throw new NotImplementedException();
        }

        private void ExitDueToErrors(Dictionary<string, Item> itemData)
        {
            string[] errorMessages = new string[itemData.Count];
            itemData.Keys.CopyTo(errorMessages, 0);
            foreach (string error in errorMessages)
            {
                menu.PrintMessage(error);
            }
            Console.WriteLine("Exiting due to errors.");
            Console.ReadLine();
            Environment.Exit(1);
        }
    }
}
