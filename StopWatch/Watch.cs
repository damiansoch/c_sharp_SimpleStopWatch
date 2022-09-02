using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace StopWatch
{
    public class Watch
    {
        public Watch(int length)
        {
            Length = length;
        }

        public void Start()
        {
            if (!isCounting)
            {
                Console.WriteLine("Is counting!\n");
                curDuration = Length;
                timer = new Timer(TimerCallback, null, 0, 1000);

                //isCounting = true;
            }
        }
        public void Stop()
        {
            Console.WriteLine("Stopped @ {0}", curDuration);
            curDuration = Length;
            timer.Dispose();
            isCounting = false;
        }


        private void TimerCallback(Object o)
        {
            if (curDuration > 0)
            {
                Console.Clear();
                curDuration--;
                Console.WriteLine("\n\n\n\n\n\n\n\n");
                Console.Write($"                         {curDuration}");
                GC.Collect();
            }
            else
            {
                Console.Clear();

                Stop();
            }
        }

        protected int Length { get; set; }
        Timer timer;
        protected bool isCounting = false;
        int curDuration;
    }
}
