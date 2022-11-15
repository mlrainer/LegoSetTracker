using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LegoSets
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.WriteLine("Welcome to Lego Tracker");
            Console.WriteLine("1) Would you like to manually enter a set?");
            Console.WriteLine("2) Import a set?");
            Console.WriteLine("3) Exit Application");
            Console.Write("\r\nSelect an option: ");
            switch (Console.ReadLine())
            {
                case "1":
                    manualSet();
                    return true;
                case "2":
                    importSet();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }

            private static string CaptureInput()
            {
                Console.Write("Enter your Selection (1,2,or 3: ");
                return Console.ReadLine();
            }

            static void manualSet()
            {
                Console.WriteLine("How many sets would you like to add?");
#pragma warning disable CS8604 // Possible null reference argument.
                var numberOfRecords = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.

                var recordList = new List<SetName>();
                for (int i = 0; i < numberOfRecords; i++)
                {

                    SetName setname = new();
                    setname.Id = i + 1;

                    Console.WriteLine("Enter sets Title:");
                    setname.ThemeSubTitle = Console.ReadLine();

                    Console.WriteLine("Enter sets Theme):");
                    setname.Theme = Console.ReadLine();

                    Console.WriteLine("Enter Lego Set id Number:");
                    setname.SetNumber = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter sets number of pieces:");
                    setname.Pieces = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter sets number of Mini Figures:");
                    setname.MiniFigs = int.Parse(Console.ReadLine());

                    Console.WriteLine("Is the Set Complete?");
                    setname.Complete = Console.ReadLine();

                    recordList.Add(setname);

                    Console.WriteLine("Printing Set Details");
                }
                foreach (SetName setname in recordList)
                {
                    Console.WriteLine($"Lego Set '{setname.Id}'");
                    Console.WriteLine($"Theme Sub Title: {setname.ThemeSubTitle}");
                    Console.WriteLine($"Theme: {setname.Theme}");
                    Console.WriteLine($"Set ID Nuber: {setname.SetNumber}");
                    Console.WriteLine($"Number of Pieces: {setname.Pieces}");
                    Console.WriteLine($"Number of Mini Figures: {setname.MiniFigs}");
                    Console.WriteLine($"Is the Set Complete?: {setname.Complete}");
                }






                static void importSet()
                {
                    //ACT ON ANSWER

                    // IF IMPORT
                    // CREATE JSONIMPORT FOLDER IF IT DOES NOT ALREADY EXIST.
                    Console.WriteLine("Currently, Lego Set Tracker only allows import through a specific location.");
                    Console.WriteLine("We hope to implement exploring your machine for the JSON file in the future.");
                    Console.WriteLine("For now, look in the Lego Set Tracker project files for a JSONIMPORT folder and place the JSON in there.");
                    Console.WriteLine("Check README for JSON structure.");
                    Console.WriteLine("Press enter when you have placed file in there.");
                    Console.ReadLine();

                    // Search any json files.
                    //If there multiple, import one at a time
                    StreamReader file = new StreamReader("import.json");
                    string jsonString = file.ReadToEnd();
                    importSet = JsonConvert.DeserializeObject<importSet>(jsonString);
                public class SetDetails
        {
            public int Id { get; set; }
            public string? Theme { get; set; }
            public int SetNumber { get; set; }
            public int Pieces { get; set; }
            public int MiniFigs { get; set; }
            public string? Complete { get; set; }
        }
    }
}
