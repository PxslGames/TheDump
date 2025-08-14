using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Breeze
{
    internal class Modules
    {
        // These are the modules for | Home [1]
        public static void ExitApplication()
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.Clear(); // Clear the console to update the dots each time
                Setup.Banner();
                Console.Write("Exiting" + new string('.', i));
                Thread.Sleep(1000); // Wait for 1 second
            }

            Environment.Exit(0); // Exit the application after showing "Exiting..."
        }

        public static void HelpDialogue()
        {
            List<string[]> helpPages = new List<string[]>
            {
                new string[]
                {
                    "[1/3]",
                    "Welcome to Breeze Help!",
                    "This will guide you through using Breeze!",
                    "[PRESS ANY KEY TO CONTINUE]"
                },
                new string[]
                {
                    "[2/3]",
                    "To navigate pages, use your arrow keys [< & >].",
                    "To select an item, type the corresponding number.",
                    "[PRESS ANY KEY TO CONTINUE]"
                },
                new string[]
                {
                    "[3/3]",
                    "Enjoy Using Breeze!",
                    "[PRESS ANY KEY TO CONTINUE]"
                }
            };

            foreach (var page in helpPages)
            {
                Console.Clear();
                Setup.Banner();
                foreach (string line in page)
                {
                    Console.WriteLine(line);
                }
                Console.ReadKey();
            }

            Console.Clear();
            Setup.SetupFunc(); // Proceed to setup function after the help dialogue
        }

        public static void CreditsDialogue()
        {
            List<string[]> helpPages = new List<string[]>
            {
                new string[]
                {
                    "[1/4]",
                    "Welcome to Breeze Credits!",
                    "This is where I have credited people / software which helped create Breeze.",
                    "[PRESS ANY KEY TO CONTINUE]"
                },
                new string[]
                {
                    "[2/4]",
                    "Visual Studio 2022 (IDE)",
                    "ChatGPT (Code Help)",
                    "[PRESS ANY KEY TO CONTINUE]"
                },
                new string[]
                {
                    "[3/4]",
                    "https://patorjk.com/software/taag/ (Banner)",
                    "Pxsl (Me) (Developer)",
                    "[PRESS ANY KEY TO CONTINUE]"
                },
                new string[]
                {
                    "[4/4]",
                    "Thanks to everyone who helped!",
                    "[PRESS ANY KEY TO CONTINUE]"
                }
            };

            foreach (var page in helpPages)
            {
                Console.Clear();
                Setup.Banner();
                foreach (string line in page)
                {
                    Console.WriteLine(line);
                }
                Console.ReadKey();
            }

            Console.Clear();
            Setup.SetupFunc(); // Proceed to setup function after the help dialogue
        }
    }
}
