
using Chess.Core.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.infrastructure.Loggers
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string text) => Console.WriteLine(text);
    }
}
