using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationActionLogger
{
    public static class Logger
    {
        private static readonly string docPath =
         Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        private static readonly int logType = 1;

        public static void Log(this string Text)
        {
            if (Text.Length == 0)
                return;
            LogTo(Text);
        }
        public static void Log(this double Text)
        {

        }
        public static void Log(this string Text, int selectedOptionIndex)
        {
            LogTo($"{Text} - [{selectedOptionIndex}]");
        }
        public static void Log(this string Text, string selectedOptionIndex)
        {
            LogTo($"{Text} - [{selectedOptionIndex}]");
        }
        public static void Log(this string Text, ConsoleKey selectedOptionIndex)
        {
            LogTo($"{Text} - [{selectedOptionIndex}]");
        }
        public static void Log(this string Text, double value)
        {
            LogTo($"{Text} - [{value}]");
        }


        private static void LogTo(string text)
        {
            if (logType == 0)
                LogToFile(text);
            else
                LogToDatabase(text);
        }

        private static void LogToFile(string Text)
        {
            using StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "LoggerFile.txt"));
            outputFile.WriteLine($"[{DateTime.UtcNow}] - ({Text})");
        }
        private static void LogToDatabase(string Text)
        {

        }
    }
}
