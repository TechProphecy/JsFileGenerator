using System;

namespace JSFileGenerator
{
    partial class Program
    {
        public static class ShowHeading
        {
            public static void Content(string message, ConsoleColor consoleColor, string text, bool onlyUnderline = false)
            {
                Console.ForegroundColor = consoleColor;
                var messageLength = message.Length;
                if (!onlyUnderline)
                {
                    PrintUnderline(messageLength, text);
                }
                Console.WriteLine(message);
                PrintUnderline(messageLength, text);
                ShowText.RevertConsoleColor();
            }

            private static void PrintUnderline(int count, string text)
            {
                var underline = string.Empty;
                for (int index = 0; index < count; index++)
                {
                    underline += text;
                }
                Console.WriteLine(underline);
            }
        }
    }
}
