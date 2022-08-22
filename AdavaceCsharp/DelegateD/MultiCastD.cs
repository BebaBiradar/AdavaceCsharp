using System;
using System.Collections.Generic;
using System.Text;

namespace AdavaceCsharp.DelegateD
{


    //multicast Delegate holding reference of more than one function
    public delegate void mydel3(int a);
    class MultiCastD
    {
        public static void m1(int a)
        {
            Console.WriteLine("in m1 "+a);
        }
        public static void square(int n)
        {
            Console.WriteLine("square"+n*n);
        }
        static void Main(string[] args)
        {

            mydel3 d1 = square;//singlecast
            //multicast
            mydel3 d2 = square;
            d2 = d2 + m1;
            d2(9);

        }
    }



    public delegate int mydel2(int a, int b);
    //public delegate int mydel2(int a, int b);
    public delegate void mydel1();
    class Pro1
    {
        public static int Prod(int a,int b)
        {
            Console.WriteLine("prod="+(a*b));
            return a * b;
        }
        public static int   Add(int a,int b)
        {
            Console.WriteLine("Add="+(a+b));
            return a + b;
        }
        static void greet()
        {
            Console.WriteLine("welcome");
        }
        static void Main(string[] args)
        {
            mydel1 d1 = greet;
            d1();
            mydel2 d3 = Add;
            // mydel2 d2 = Prod;//singlecast
            d3 = d3 + Prod;//multicast
            int r;
            r = d3(10, 20);

        }
    }



}
