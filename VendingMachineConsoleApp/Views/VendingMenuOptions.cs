using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Views
{
    public class VendingMenuOptions
    {
        public const string MAIN_MENU_OPTION_DISPLAY_ITEMS = "Display Vending Machine Items";
        public const string MAIN_MENU_OPTION_PURCHASE = "Purchase";
        public readonly string[] MAIN_MENU_OPTIONS = { MAIN_MENU_OPTION_DISPLAY_ITEMS, MAIN_MENU_OPTION_PURCHASE };
    }
}
