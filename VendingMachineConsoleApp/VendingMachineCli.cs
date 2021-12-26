using System;
using System.Collections.Generic;
using System.Text;
using VendingMachineConsoleApp.Interfaces;
using VendingMachineConsoleApp.Views;

namespace VendingMachineConsoleApp
{
    public class VendingMachineCli
    {
        private readonly IMenuService menu;
        private readonly IFileInputHandler fileInput;
        private readonly VendingMenuOptions options;


        public VendingMachineCli(IMenuService menu, IFileInputHandler fileInput, VendingMenuOptions options)
        {
            this.menu = menu;
            this.fileInput = fileInput;
            this.options = options;
        }

        public void Run()
        {
            while (true)
            {
                string choice = menu.GetChoiceFromOptions(options.MAIN_MENU_OPTIONS);
            }
        }
    }
}
