using System;
using VendingMachineConsoleApp.Views;

namespace VendingMachineConsoleApp
{
    static class Program
    {
        static void Main(string[] args)
        {
            IMenu menu = new Menu();
            VendingMachineCli cli = new VendingMachineCli(menu);
            cli.Run();
        }
    }
}
