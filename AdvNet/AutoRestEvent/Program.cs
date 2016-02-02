using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoResetEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            var autoResetEvent = new System.Threading.AutoResetEvent(false);
            var t1 =
                new Thread(() =>
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("Thread is done");
                    autoResetEvent.Set();
                });

            t1.Start();

            var result = 
                autoResetEvent.WaitOne(TimeSpan.FromSeconds(5));

            Console.WriteLine("Program is done, result {0}",result);
        }
    }
}
