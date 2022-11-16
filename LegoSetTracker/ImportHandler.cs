using System;
using Newtonsoft.Json;
using System.IO;

namespace LegoSets
{
    public static class ImportHandler
    {
         
        public static void importSet()
        {
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
            var incomingSet = new List<SetDetails>();

            DirectoryInfo directory = new DirectoryInfo(Directory.GetCurrentDirectory());
            var fileName = Path.Combine(directory.FullName, "JSONIMPORT/import.json");

            using (StreamReader reader = new StreamReader(fileName)) 
            {
                string json = reader.ReadToEnd();
                incomingSet = JsonConvert.DeserializeObject<List<SetDetails>>(json);
            }
        }

        public static void manualSet()
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
        }
    }
}