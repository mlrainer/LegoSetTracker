using System;
using System.Collections.Generic;
using LegoSetTracker;

namespace LegoSets
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Lego Tracker");
            Console.WriteLine("How many Lego Sets Would You like to Add");
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
                Console.WriteLine($"Number of Pieces: {setname.Pieces}");
                Console.WriteLine($"Number of Mini Figures: {setname.MiniFigs}");
            }
        }
    }
}