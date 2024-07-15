using Bankomat.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat.Services
{
    internal class VOneLoggerService : ILoggerService    {
        public void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            
            Console.WriteLine(message);
        }
    }
}
