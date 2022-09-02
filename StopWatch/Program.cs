using System;

namespace StopWatch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Put the time in seconds!");
            int time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            Watch watch = new Watch(time);
            watch.Start();
            Console.ReadKey();
            watch.Stop();
            Console.ReadKey();
        }
    }
}
