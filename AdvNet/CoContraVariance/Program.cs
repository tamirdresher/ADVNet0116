using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoContraVariance
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> sFunc = (s) => Console.WriteLine(s);
            Action<object> oFunc = (o) => Console.WriteLine(o);

            //since T is 'in' the action can be
            //assigned to Action<G> where G:T
            //in == upcast
            sFunc = oFunc;

            sFunc("123");
           

            //out
            IEnumerable<object> objects =
                new List<string>();


            Func<object, string> f1 = x => x.ToString();
            Func<string, object> f2 = f1;

           
        }
    }
}
