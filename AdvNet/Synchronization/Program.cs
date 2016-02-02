using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Synchronization
{
    class Program
    {
        static private Int64 x = 100;
        static volatile private int y = 5;
        static void Main(string[] args)
        {
            var after=Interlocked.Increment(ref y);

           

        }
    }
}
