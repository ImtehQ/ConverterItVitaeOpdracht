using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logger
{
    public interface ILogger
    {
        void Log(string message);
        void Log(string Type, double value1, double value2);
        void Log(string message, ConsoleKey key);
        void Save(string messageText);
    }
}
