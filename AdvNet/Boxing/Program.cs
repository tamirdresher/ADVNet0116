using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    struct MyType : IMyType
    {
        public int X { get; set; }
        public void Increment()
        {
            X++;
        }
    }

    struct MyCollection 
    {
        public int X { get; set; }
        public List<int> InnerCollection { get; set; }
        public IEnumerator<int> GetEnumerator()
        {
            X++;
            return InnerCollection.GetEnumerator();
        }

       
    }

    internal interface IMyType
    {
        void Increment();
    }

    class Program
    {
        static void Main(string[] args)
        {
            //BoxingWithInterface();
            //ForeachDoesntUseIEnumerable();
            //IsDynamicBoxing();

            OpenGenericType();
        }

        private static void OpenGenericType()
        {
            var openType = typeof (List<>);
            var closeType = typeof (List<int>);
        }

        private static void IsDynamicBoxing()
        {
            var s1 = new MyType();
            s1.X = 5;

            dynamic s2 = s1;
            s2.Increment();

   
            Console.WriteLine(s1.X);
        }

        private static void ForeachDoesntUseIEnumerable()
        {
            MyCollection coll = new MyCollection();
            coll.InnerCollection = new List<int>()
            {
                1,
                2,
                3,
                4
            };
            foreach (var x in coll)
            {
            }

            foreach (var x in coll)
            {
            }

            Console.WriteLine(coll.X);
        }

        private static void BoxingWithInterface()
        {
            var s1 = new MyType();
            s1.X = 5;

            IMyType s2 = s1;
            IMyType s3 = s2;
            s2.Increment();

            Console.WriteLine(s1.X);
            
        }


    }
}
