using System;

namespace StopWatchDesign
{
    class Stopwatch
    {
        private static DateTime startTime;
        private static DateTime stopTime;
        private static bool ticking;

        public static void Start()
        {
            startTime = DateTime.Now;
            if (ticking == true)
            {
                throw new InvalidOperationException("Stopwatch cannot be started twice in a row.");
            }
            Console.WriteLine("Stopwatch ticking... Press 'stop' to stop the timer.");
            ticking = true;
        }

        public static void Stop()
        {
            stopTime = DateTime.Now;
            if (ticking == false)
            {
                throw new InvalidOperationException("Stopwatch cannot be stopped twice in a row.");
            }
            Console.WriteLine($"Time elapsed: " + (stopTime - startTime) + ". Press 'start' again to restart the timer.");
            ticking = false;
        }
    }
}
