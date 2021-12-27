using System;
using System.Collections.Generic;
using System.Text;
using VendingMachineConsoleApp.Models;

namespace VendingMachineConsoleApp.Interfaces
{
    public interface IFileInputHandler
    {
        Dictionary<string, Item> ItemData { get; }
    }
}
