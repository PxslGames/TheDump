using System;
using System.Collections.Generic;

namespace Breeze
{
    internal static class Menu
    {
        private static List<string> pages = new List<string>
        {
            "Home",
            "Files",
            "Network",
            "Page 4: Thank you for using Breeze!"
        };

        private static List<string[]> commands = new List<string[]>
        {
            new string[] { "1. Exit", "2. View help", "3. Credits", "4. Update Log" },
            new string[] { "1. Duplicate File Remover", "2. UNDEFINED", "3. Back" },
            new string[] { "1. Reveal IP", "2. Feature 2", "3. Back" },
            new string[] { "1. Feedback", "2. Rate us", "3. Back" },
        };

        public static void ShowMenu()
        {
            int currentPage = 0;

            while (true)
            {
                Console.Clear();
                Setup.Banner(); // Call Banner to display it on every loop iteration
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(pages[currentPage]);
                Console.WriteLine();

                // Display commands for the current page
                foreach (var command in commands[currentPage])
                {
                    Console.WriteLine(command);
                }

                Console.WriteLine();

                // Read user input for actions or navigation
                var key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.LeftArrow)
                {
                    if (currentPage > 0)
                    {
                        currentPage--;
                    }
                }
                else if (key == ConsoleKey.RightArrow)
                {
                    if (currentPage < pages.Count - 1)
                    {
                        currentPage++;
                    }
                }
                else if (key >= ConsoleKey.D1 && key <= ConsoleKey.D7)
                {
                    int option = (int)key - (int)ConsoleKey.D1;
                    Actions.PerformAction(currentPage, option);
                }
            }
        }
    }
}