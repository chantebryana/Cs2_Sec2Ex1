using System;

namespace Stopwatch2
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start = DateTime.Now;
            Console.WriteLine(stopwatch.Start);
        }
    }
}
