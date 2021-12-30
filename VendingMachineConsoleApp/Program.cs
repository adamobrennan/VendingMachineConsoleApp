using VendingMachineConsoleApp.FileIO;
using VendingMachineConsoleApp.Views;

namespace VendingMachineConsoleApp
{
    public static class Program
    {
        private static int defaultStockLevel = 10;

        public static void Main(string[] args)
        {
            VendingMachineCli cli;

            if (args.Length == 1)
            {
                cli = InitializeCli(args[0], defaultStockLevel);
            }
            else
            {
                cli = InitializeCli("vendingmachinecli.csv", defaultStockLevel);
            }

            cli.Run();
        }

        private static VendingMachineCli InitializeCli(string filePath, int startingStockLevel)
        {
            IMenuService menu = new MenuService();
            IFileInputHandler input = new FileInputHandler(filePath);
            VendingMenuOptions options = new VendingMenuOptions();
            VendingMachineCli cli = new VendingMachineCli(menu, options);
            return cli;
        }
    }
}
