using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionPlayground
{
    class Program
    {
        public static int Age { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Foo(() => Print(default(int), default(int)));
        }

        public static int Print(int x, int y)
        {
            return 1;
        }
        public static void Foo<T>(Expression<Func<T>> propNameExpression)
        {
            Console.WriteLine();
        }
    }
}
