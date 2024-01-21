using System;
using System.Diagnostics;

/* Exceeding the requirements
   1. Journal overwritting protection: We ask the customer to confirm if the journal exists.
   2. Empty list validation before saving.
   3. Show the number of entries saved/loaded.
   4. Skip header line while loading from a file.
*/

class Program
{
    static void Main(string[] args)
    {
        string option = string.Empty;
        Journal theJournal = new Journal();

        while (option != "exit")
        {
            //show menu
            Console.Clear();
            Console.WriteLine("Journal v1.0");
            Console.WriteLine("**************************");
            Console.WriteLine("  1. Write a new entry");
            Console.WriteLine("  2. Display journal");
            Console.WriteLine("  3. Save Journal");
            Console.WriteLine("  4. Load Journal");
            Console.WriteLine("  5. Exit");
            Console.Write(">> ");
            option = Console.ReadLine();
            switch (int.Parse(option)) {
                case 1:
                    Console.Clear();
                    Console.WriteLine("New Entry\n************************");
                    Entry entry = new Entry();
                    DateTime currentTime = DateTime.Now;
                    entry._date = currentTime.ToShortDateString();
                    entry._promptText = PromptGenerator.GetRandomPrompt();
                    Console.WriteLine(entry._promptText);
                    entry._entryText = Console.ReadLine();
                    
                    //we add the entry
                    theJournal.AddEntry(entry);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Display All\n************************");
                    theJournal.DisplayAll();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Save Journal to file (enter filename): ");
                    option = Console.ReadLine();
                    theJournal.SaveToFile(option);
                    option = string.Empty;
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Load Journal from file (enter filename): ");
                    option = Console.ReadLine();
                    theJournal.LoadFromFile(option);
                    option = string.Empty;
                    break;
                case 5:
                    option = "exit";
                    Console.Clear();
                    Console.WriteLine("Thank you for writing in your Journal.");
                    break;
                default:
                    Console.WriteLine("The option is incorrect. Try again.\n");
                    break;
            }

        }
    }
}