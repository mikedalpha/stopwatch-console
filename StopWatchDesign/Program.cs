using System;

namespace StopWatchDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 'start' to start the timer, 'stop' to stop the timer once started.");
            string input;
            do
            {
                input = Console.ReadLine().ToLower();
                if (input == "start")
                {
                    Stopwatch.Start();
                }
                else if (input == "stop")
                {
                    Stopwatch.Stop();
                }
            }
            while (input == "start" || input == "stop");
        }
    }
}
