using System;
using System.Collections.Generic;
using System.Text;
using VendingMachineConsoleApp.Models;

namespace VendingMachineConsoleApp.FileIO
{
    public interface IFileInputHandler
    {
        Dictionary<string, Item> ItemData { get; }
    }
}
