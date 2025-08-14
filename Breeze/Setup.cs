using System;

namespace Breeze
{
    internal static class Setup
    {
        public static void SetupFunc()
        {
            Console.Title = "Breeze | Made By Pxsl";
            Banner();
            Menu.ShowMenu();
        }
        public static void Banner()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" ________  ________  _______   _______   ________  _______      ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("|\\   __  \\|\\   __  \\|\\  ___ \\ |\\  ___ \\ |\\_____  \\|\\  ___ \\     ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\\ \\  \\|\\ /\\ \\  \\|\\  \\ \\   __/|\\ \\   __/| \\|___/  /\\ \\   __/|    ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" \\ \\   __  \\ \\   _  _\\ \\  \\_|/_\\ \\  \\_|/__   /  / /\\ \\  \\_|/__  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("  \\ \\  \\|\\  \\ \\  \\\\  \\\\ \\  \\_|\\ \\ \\  \\_|\\ \\ /  /_/__\\ \\  \\_|\\ \\ ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("   \\ \\_______\\ \\__\\\\ _\\\\ \\_______\\ \\_______\\\\________\\ \\_______\\");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("    \\|_______|\\|__|\\|__|\\|_______|\\|_______|\\|_______|\\|_______|");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}