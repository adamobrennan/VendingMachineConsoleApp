using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Views
{
    public interface IMenuService
    {
        public string GetChoiceFromOptions(string[] options);
        public void PrintMessage(string message);
    }
}
