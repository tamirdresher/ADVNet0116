using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var time in GetTimes())
            {
                Console.WriteLine(time);
            }

            //
            // Conceptually the same as below:
            //
            //var enumerator = GetTimes().GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current);
            //}
            /**/

        }

        public static IEnumerable<DateTime> GetTimes()
        {
            while (true)
            {
                yield return DateTime.Now;
            }
        }
    }
}
