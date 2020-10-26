using System;
using System.Collections.Generic;

namespace JSFileGenerator
{
    partial class Program
    {
        static void Main(string[] args)
        {
            ShowHeading.Content("TechProphecy - JS File Generator", ConsoleColor.Cyan, "=");
            while(true)
            {
                ShowHeading.Content("Choose option to generate JS file: ", ConsoleColor.Blue, "-", true);
                ShowOptions();
                var selectedOption = Console.ReadLine();
                switch (selectedOption)
                {
                    case "1":
                        JSGenerator.GenerateHtmlwithFirestoreCrud();
                        break;
                    case "2":
                        JSGenerator.GenerateHtml();
                        break;
                    case "3":
                        JSGenerator.GenerateCompleteCrud();
                        break;
                    case "4":
                        JSGenerator.GenerateCustom();
                        break;
                    default:
                        ShowText.WarningMessage("Please choose valid option");
                        break;
                }
            }
        }

        private static void ShowOptions()
        {
            var optionCount = 1;
            var options = new List<string>();
            options.Add("Startup HTML5 with Firestore CRUD");
            options.Add("Startup HTML5");
            options.Add("Firestore CRUD JS");
            options.Add("Make custom choices");

            options.ForEach((option) =>
            {
                ShowText.InfoMessage(optionCount++ + ") " + option);
            });

            ShowText.CustomMessage("Waiting for input..", ConsoleColor.Gray);
        }
    }
}
