using System;

namespace Breeze
{
    internal static class Actions
    {
        public static void PerformAction(int page, int option)
        {
            switch (page)
            {
                case 0: // Page 1 actions
                    HandlePage1Actions(option);
                    break;
                case 1: // Page 2 actions
                    HandlePage2Actions(option);
                    break;
                case 2: // Page 3 actions
                    HandlePage3Actions(option);
                    break;
                case 3: // Page 4 actions
                    HandlePage4Actions(option);
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void HandlePage1Actions(int option)
        {
            switch (option)
            {
                case 0:
                    Modules.Home.ExitApplication();
                    break;
                case 1:
                    Modules.Home.HelpDialogue();
                    break;
                case 2:
                    Modules.Home.CreditsDialogue();
                    break;
                case 3:
                    Modules.Home.UpdateLog();
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }

        public static void HandlePage2Actions(int option)
        {
            switch (option)
            {
                case 0:
                    Modules.Files.DuplicateRemover();
                    break;
                case 1:
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }

        public static void HandlePage3Actions(int option)
        {
            switch (option)
            {
                case 0:
                    Modules.Network.RevealIP();
                    break;
                case 1:
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }

        private static void HandlePage4Actions(int option)
        {
            switch (option)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}