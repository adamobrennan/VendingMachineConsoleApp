using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using VendingMachineConsoleApp.Interfaces;
using VendingMachineConsoleApp.Models;

namespace VendingMachineConsoleApp
{
    public class FileInputHandler : IFileInputHandler
    {
        public Dictionary<string, Item> ItemData { get => items; }

        public FileInputHandler(string filePath)
        {
            items = PopulateItemDictionary(filePath);
        }

        private Dictionary<string, Item> PopulateItemDictionary(string filePath)
        {
            if (File.Exists(filePath) == false)
            {
                Dictionary<string, Item> errorDictionary = GetErrorResponse(filePath);
                return errorDictionary;
            }

            Dictionary<string, Item> itemsFromFile = ReadDataFromFile(filePath);

            return itemsFromFile;
        }

        private static Dictionary<string, Item> GetErrorResponse(string filePath)
        {
            Dictionary<string, Item> errorDictionary = new Dictionary<string, Item>();
            errorDictionary.Add($"Error: File not found -- {filePath} \nPlease turn off vending machine and confirm required files are available in file system.", null);
            return errorDictionary;
        }

        private static Dictionary<string, Item> ReadDataFromFile(string filePath)
        {
            Dictionary<string, Item> itemsFromFile = new Dictionary<string, Item>();

            using StreamReader sr = File.OpenText(filePath);
            string itemString;

            while ((itemString = sr.ReadLine()) != null)
            {
                string[] itemData = itemString.Split('|');
                itemsFromFile.Add(itemData[0], new Item(itemData[1], itemData[2], itemData[3]));
            }

            return itemsFromFile;
        }

        private readonly Dictionary<string, Item> items;
    }
}
