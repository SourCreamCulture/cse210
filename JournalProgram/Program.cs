using System;

namespace JournalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var journal = new Journal();
            var promptGen = new PromptGenerator();
            bool running = true;

            while (running)
            {
                Console.WriteLine("Please choose one of the following options:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Quit");
                Console.Write("Your choice: ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string prompt = promptGen.GetRandomPrompt();
                        Console.WriteLine($"Prompt: {prompt}");
                        Console.Write("> ");
                        string? response = Console.ReadLine() ?? string.Empty;
                        string date = DateTime.Now.ToShortDateString();
                        journal.AddEntry(new Entry(prompt, response, date));
                        Console.WriteLine("Entry added.\n");
                        break;

                    case "2":
                        Console.WriteLine("\nYour Journal Entries:");
                        foreach (var entry in journal.GetEntries())
                        {
                            Console.WriteLine(entry);
                        }
                        break;

                    case "3":
                        Console.Write("Enter filename to save: ");
                        string? saveFile = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(saveFile))
                        {
                            FileManager.Save(journal, saveFile);
                            Console.WriteLine("Journal saved.\n");
                        }
                        break;

                    case "4":
                        Console.Write("Enter filename to load: ");
                        string? loadFile = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(loadFile) && System.IO.File.Exists(loadFile))
                        {
                            journal = FileManager.Load(loadFile);
                            Console.WriteLine("Journal loaded.\n");
                        }
                        else
                        {
                            Console.WriteLine("File not found.\n");
                        }
                        break;

                    case "5":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice.\n");
                        break;
                }
            }

            Console.WriteLine("Goodbye!");
        }
    }
}
