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
        private readonly VendingMenuOptions options;
        private readonly IFileInputHandler fileInput;


        public VendingMachineCli(IMenuService menu, VendingMenuOptions options, IFileInputHandler fileInput)
        {
            this.menu = menu;
            this.options = options;
            this.fileInput = fileInput;
        }

        public void Run()
        {
            if (fileInput.ItemData.ContainsValue(null))
            {
                
            }
            while (true)
            {
                string choice = menu.GetChoiceFromOptions(options.MAIN_MENU_OPTIONS);
            }
        }
    }
}
