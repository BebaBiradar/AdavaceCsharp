using System;
using System.Collections.Generic;
using System.Text;

namespace AdavaceCsharp.DelegateD.LambdaDe
{
    public delegate void mydel17(int a, int b);
    public delegate int mydel12(int a);
    class Class2
    {
        public static void Product(int a, int b)
        {
            Console.WriteLine("Prod=" + (a + b));
        }
        
        static void Main(string[] args)
        {
            mydel17 d1 = (a, b) => Console.WriteLine("area of rect=" + (a * b));
            {
              d1(12, 45);

               
                mydel12 ddd2 = (a) => a * a;
                int sq1 = ddd2(9);
                Console.WriteLine("square"+sq1);
            }
        }
    }


    public delegate int mydel13(int a);
    class SquareDemp
    {
        public static int Square(int n)
        {
            return n * n;
        }
        static void Main(string[] args)
        {
            mydel13 d2 = (a) =>
              {
                  return a * a;
              };
            int sq = d2(9);

            mydel13 d3 = (a) => a * a;
            int sq1 = d3(6);
            Console.WriteLine("square"+sq1);

        }

    }
}
