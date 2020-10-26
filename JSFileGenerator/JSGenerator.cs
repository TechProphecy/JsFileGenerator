﻿using System;
using System.IO;

namespace JSFileGenerator
{
    partial class Program
    {
        public static class JSGenerator
        {
            public static void GenerateCrud()
            {
                var filePath = "C:\\Users\\jjeff\\Desktop\\my_js.js";
                File.WriteAllText(filePath, JSContent.PrepareForFirestoreCrud());
                File.AppendAllText(filePath, "\n\n");
                File.AppendAllText(filePath, JSContent.FirestoreCreateCode());
                ShowText.SuccessMessage("my_js.js file generated!");
            }

            private static void SignJsFile(string filePath)
            {
                File.WriteAllText(filePath, "// Generated by TechProphecy-JS Generator at " + DateTime.Now);
                File.AppendAllText(filePath, "\n\n\n");
            }

            private static void SignHtmlFile(string filePath)
            {
                File.WriteAllText(filePath, "<!-- Generated by TechProphecy-JS Generator at " + DateTime.Now + " -->");
                File.AppendAllText(filePath, "\n\n\n");
            }

            internal static void GenerateHtmlwithFirestoreCrud()
            {
                // Generate JS File

                // Get file name
                ShowText.InfoMessage("Type in a name for the JS file, or just press enter to default name to scripts.js");
                var fileName = Console.ReadLine();
                // Get file path
                ShowText.InfoMessage("Type in a path for the JS file, or just press enter to default path to your Desktop");
                var filePath = Console.ReadLine();
                var fileNameToProcess = fileName == "" ? "scripts.js" : fileName + ".js";
                var filePathToProcess = filePath == "" ? Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + fileNameToProcess : filePath + "\\" + fileNameToProcess;
                ShowText.WarningMessage("Creating " + fileNameToProcess + " in " + filePathToProcess + "...");
                SignJsFile(filePathToProcess);
                File.AppendAllText(filePathToProcess, JSContent.PrepareForFirestoreCrud() + "\n\n" + JSContent.FirestoreCreateCode() + "\n\n" + JSContent.FirestoreUpdateCode() + "\n\n" + JSContent.FirestoreDeleteCode() + "\n\n" + JSContent.FirestoreReadSingleCode() + "\n\n" + JSContent.FirestoreReadMultipleCode());
                // Show Progress
                ShowText.SuccessMessage(fileNameToProcess + " file generated at " + filePathToProcess + " !");

                // Preserve JS file name for later use
                var preservedJsFileName = fileNameToProcess;

                // Generate HTML file

                // Get file name
                ShowText.InfoMessage("Type in a name for the HTML file, or just press enter to default name to index.html");
                fileName = Console.ReadLine();
                // Get file path
                ShowText.InfoMessage("Type in a path for the HTML file, or just press enter to default path to your Desktop");
                filePath = Console.ReadLine();
                fileNameToProcess = fileName == "" ? "index.html" : fileName + ".html";
                filePathToProcess = filePath == "" ? Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + fileNameToProcess : filePath + "\\" + fileNameToProcess;
                ShowText.WarningMessage("Creating " + fileNameToProcess + " in " + filePathToProcess + "...");
                SignHtmlFile(filePathToProcess);
                File.AppendAllText(filePathToProcess, JSContent.StartupHtml(preservedJsFileName));
                // Show Progress
                ShowText.SuccessMessage(fileNameToProcess + " file generated at " + filePathToProcess + " !");
            }

            internal static void GenerateHtml()
            {
                // Generate HTML file

                // Get file name
                ShowText.InfoMessage("Type in a name for the HTML file, or just press enter to default name to index.html");
                var fileName = Console.ReadLine();
                // Get file path
                ShowText.InfoMessage("Type in a path for the HTML file, or just press enter to default path to your Desktop");
                var filePath = Console.ReadLine();
                var fileNameToProcess = fileName == "" ? "index.html" : fileName + ".html";
                var filePathToProcess = filePath == "" ? Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + fileNameToProcess : filePath + "\\" + fileNameToProcess;
                ShowText.WarningMessage("Creating " + fileNameToProcess + " in " + filePathToProcess + "...");
                SignHtmlFile(filePathToProcess);
                File.AppendAllText(filePathToProcess, JSContent.StartupHtml(""));
                // Show Progress
                ShowText.SuccessMessage(fileNameToProcess + " file generated at " + filePathToProcess + " !");
            }

            internal static void GenerateCompleteCrud()
            {
                // Generate JS File

                // Get file name
                ShowText.InfoMessage("Type in a name for the JS file, or just press enter to default name to scripts.js");
                var fileName = Console.ReadLine();
                // Get file path
                ShowText.InfoMessage("Type in a path for the JS file, or just press enter to default path to your Desktop");
                var filePath = Console.ReadLine();
                var fileNameToProcess = fileName == "" ? "scripts.js" : fileName + ".js";
                var filePathToProcess = filePath == "" ? Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + fileNameToProcess : filePath + "\\" + fileNameToProcess;
                ShowText.WarningMessage("Creating " + fileNameToProcess + " in " + filePathToProcess + "...");
                SignJsFile(filePathToProcess);
                File.AppendAllText(filePathToProcess, JSContent.PrepareForFirestoreCrud() + "\n\n" + JSContent.FirestoreCreateCode() + "\n\n" + JSContent.FirestoreUpdateCode() + "\n\n" + JSContent.FirestoreDeleteCode() + "\n\n" + JSContent.FirestoreReadSingleCode() + "\n\n" + JSContent.FirestoreReadMultipleCode());
                // Show Progress
                ShowText.SuccessMessage(fileNameToProcess + " file generated at " + filePathToProcess + " !");
            }

            internal static void GenerateCustom()
            {
                throw new System.NotImplementedException();
            }
        }
    }
}
