using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using LegoSets;

namespace LegoSets
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu.ShowMainMenu();
            }
        }
    }
}