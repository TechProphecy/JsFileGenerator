using System;

namespace JSFileGenerator
{
    public static class ShowText
    {
        public static void SuccessMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            RevertConsoleColor();
        }

        public static void WarningMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(message);
            RevertConsoleColor();
        }

        public static void InfoMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            RevertConsoleColor();
        }

        public static void ErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            RevertConsoleColor();
        }

        public static void CustomMessage(string message, ConsoleColor consoleColor)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(message);
            RevertConsoleColor();
        }

        public static void RevertConsoleColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
