using System;
using Newtonsoft.Json;
using System.IO;
using LegoSets;

namespace LegoSets
{
    public class MainMenu
    {
        public static bool ShowMainMenu()
        {
            Console.WriteLine("Welcome to Lego Tracker");
            Console.WriteLine("1) Would you like to manually enter a set?");
            Console.WriteLine("2) Import a set?");
            Console.WriteLine("3) Exit Application");
            Console.Write("\r\nSelect an option: ");
            
            switch (Console.ReadLine())
            {
                case "1":
                    ImportHandler.manualSet();
                    return true;
                case "2":
                    ImportHandler.importSet();
                    return true;
                case "3":
                    return false;
                default:
                    Console.WriteLine("Input not valid... Closing program");
                    return false;
            }
        }
    }
}