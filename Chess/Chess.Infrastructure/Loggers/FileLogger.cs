
using Chess.Core.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.infrastructure.Loggers
{
    public class FileLogger : ILogger
    {
        public void Log(string text) => File.AppendAllText("log.txt", text +"\n");
    }
}
