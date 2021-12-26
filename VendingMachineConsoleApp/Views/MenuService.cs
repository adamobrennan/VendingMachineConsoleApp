using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace VendingMachineConsoleApp.Views
{
    public class MenuService : IMenuService
    {
        public string GetChoiceFromOptions(string[] options)
        {
            string choice = null;

            while (choice == null)
            {
                DisplayMenuOptions(options);
                choice = GetChoiceFromUserInput(options);
            }
            return choice;
        }

        private string GetChoiceFromUserInput(string[] options)
        {
            string choice = null;
            string userInput = Console.ReadLine();

            try
            {
                int optionNumber = int.Parse(userInput);
                if(optionNumber > 0 && optionNumber <= options.Length)
                {
                    choice = options[optionNumber - 1];
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid entry. Please try again.");
            }
            
            return choice;
        }

        private void DisplayMenuOptions(string[] options)
        {
            Console.WriteLine();

            for(int i = 0; i < options.Length; i++)
            {
                int optionNumber = i + 1;
                Console.WriteLine($"{optionNumber}) {options[i]}");
            }

            Console.Write("Please choose an option number. >>>");
        }
    }
}
