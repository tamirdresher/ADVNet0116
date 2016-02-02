using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadStatic
{
    class Program
    {
        [ThreadStatic]
        public static int _value = 6;
        
        static void Main(string[] args)
        {
            Func<int> valueFactory = () => 1;
            ThreadLocal<int> tl = 
                new ThreadLocal<int>(valueFactory);

            LocalDataStoreSlot localDataStoreSlot = 
                Thread.GetNamedDataSlot("myThreadLocal");

            var value = valueFactory();

            Console.WriteLine("thread:{0} value:{1}", Thread.CurrentThread.ManagedThreadId, _value);
            _value = 10;
            ThreadStart action = () =>
            {
                _value = Thread.CurrentThread.ManagedThreadId;
                Console.WriteLine("thread:{0} value:{1}", Thread.CurrentThread.ManagedThreadId, _value);
            };

            var t1 = new Thread(action);
            var t2= new Thread(action);
            t1.Start();
            t2.Start();

            Console.ReadLine();


            var ints = new List<int>() {1, 2, 3, 4};
            var readOnlyCollection = ints.AsReadOnly();
            var count = readOnlyCollection.Count;

          
            
        }

        
    }
}
