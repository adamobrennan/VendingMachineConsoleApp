using System;
using VendingMachineConsoleApp.Interfaces;
using VendingMachineConsoleApp.Views;

namespace VendingMachineConsoleApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            VendingMachineCli cli;

            if (args != null)
            {
                cli = InitializeCli(args[0]);
            }
            else
            {
                cli = InitializeCli("vendingmachinecli.csv");
            }

            cli.Run();
        }

        private static VendingMachineCli InitializeCli(string filePath)
        {
            IMenuService menu = new MenuService();
            IFileInputHandler input = new FileInputHandler(filePath);
            VendingMenuOptions options = new VendingMenuOptions();
            VendingMachineCli cli = new VendingMachineCli(menu, options, input);
            return cli;
        }
    }
}
