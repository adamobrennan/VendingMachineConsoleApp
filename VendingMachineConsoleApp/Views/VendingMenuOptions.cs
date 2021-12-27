using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Views
{
    public class VendingMenuOptions
    {
        public const string MAIN_MENU_OPTION_DISPLAY_ITEMS = "Display vending machine items";
        public const string MAIN_MENU_OPTION_PURCHASE = "Purchase";
        public const string MAIN_MENU_OPTION_POWER_OFF = "Turn off vending machine";
        public readonly string[] MAIN_MENU_OPTIONS = { MAIN_MENU_OPTION_DISPLAY_ITEMS, MAIN_MENU_OPTION_PURCHASE, MAIN_MENU_OPTION_POWER_OFF };
    }
}
