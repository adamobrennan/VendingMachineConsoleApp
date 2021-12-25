using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Views
{
    public interface IMenu
    {
        public string GetChoiceFromOptions(string[] options);
    }
}
