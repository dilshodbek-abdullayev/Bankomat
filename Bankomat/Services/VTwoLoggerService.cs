using System;
using Bankomat.Interfaces;

namespace Bankomat.Services
{
    internal class VTwoLoggerService : ILoggerService
    {
        public void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.WriteLine(message);
        }
    }
}
