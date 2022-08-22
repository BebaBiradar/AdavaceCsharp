using System;
using System.Collections.Generic;
using System.Text;

namespace AdavaceCsharp.DelegateD.AnomanceDe
{
    public delegate void mydel17(int a, int b);
    class Class1
    {
        public static void Product(int a, int b)
        {
            Console.WriteLine("Prod=" + (a + b));
        }
        static void Main(string[] args)
        {
            //anonymous
            mydel17 d = delegate (int a, int b)
            {
                Console.WriteLine("Product" + (a * b));
            };
            d(9, 7);
        }

    }
}
