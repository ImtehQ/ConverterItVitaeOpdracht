using System;
using System.IO;

namespace Logic.Logger
{
    public class IOLogger : ILogger
    {
        private readonly string docPath =
         Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public IOLogger()
        {

        }

        public void Log(string Text)
        {
            if (Text.Length == 0)
                return;
            Save(Text);
        }

        public void Log(string Type, double value1, double value2)
        {
            Save($"[{DateTime.UtcNow}][{Type}] -> {value1} => {value2}");
        }

        public void Log(string message, ConsoleKey key)
        {
            Save($"[{DateTime.UtcNow}][{message}] + [key]");
        }

        public void Save(string messageText)
        {
            using StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "LoggerFile.txt"));
            outputFile.WriteLine(messageText);
        }
    }
}
