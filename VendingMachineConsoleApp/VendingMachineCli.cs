using System;
using System.Collections.Generic;
using System.Text;
using VendingMachineConsoleApp.Views;

namespace VendingMachineConsoleApp
{
    public class VendingMachineCli
    {
        private readonly IMenu menu;
        private const string MAIN_MENU_OPTION_DISPLAY_ITEMS = "Display Vending Machine Items";
        private const string MAIN_MENU_OPTION_PURCHASE = "Purchase";
        private readonly string[] MAIN_MENU_OPTIONS = { MAIN_MENU_OPTION_DISPLAY_ITEMS, MAIN_MENU_OPTION_PURCHASE };


        public VendingMachineCli(IMenu menu)
        {
            this.menu = menu;
        }

        public void Run()
        {
            while (true)
            {
                string choice = menu.GetChoiceFromOptions(MAIN_MENU_OPTIONS);
            }
        }
    }
}
