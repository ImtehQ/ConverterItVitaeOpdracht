using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logger
{
    public class DbLogger : ILogger
    {
        public void Log(string message)
        {
            throw new NotImplementedException();
        }

        public void Log(string Type, double value1, double value2)
        {
            throw new NotImplementedException();
        }

        public void Log(string message, ConsoleKey key)
        {
            throw new NotImplementedException();
        }

        public void Save(string messageText)
        {
            throw new NotImplementedException();
        }
    }
}
