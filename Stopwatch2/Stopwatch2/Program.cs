using System;

namespace Stopwatch2
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            //stopwatch.Start = DateTime.Now;
            //Console.WriteLine(stopwatch.Start);

            Console.WriteLine("Type 'Start' to start stopwatch: ");
            if (Console.ReadLine() == "Start")
            {
                stopwatch.Start = DateTime.Now;
            }
            //stopwatch.Start = DateTime.Now;
            Console.WriteLine("Stopwatch started at '{0}'", stopwatch.Start);
        }
    }
}
