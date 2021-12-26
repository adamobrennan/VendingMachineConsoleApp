using System;
using VendingMachineConsoleApp.Interfaces;
using VendingMachineConsoleApp.Views;

namespace VendingMachineConsoleApp
{
    public static class Program
    {
        public static void Main()
        {
            VendingMachineCli cli = InitializeCli();
            cli.Run();
        }

        private static VendingMachineCli InitializeCli()
        {
            IMenuService menu = new MenuService();
            IFileInputHandler input = new FileInputHandler();
            VendingMenuOptions options = new VendingMenuOptions();
            VendingMachineCli cli = new VendingMachineCli(menu, input, options);
            return cli;
        }
    }
}
