using System;
using System.Collections.Generic;
using System.Text;

namespace AdavaceCsharp.DelegateD
{

    //3 types of generic delegates
    class Class1
    {
        static double m1(int r,char c)
        {
            return r * 3.4;
        }
        static void m2(byte a,string e)
        {
            Console.WriteLine("in m2"+e+a);
        }
        static bool m3(long m)
        {
            return true;
        }
        static bool m4(long a,string s)
        {
            return true;
        }
        static void Main(string[] args)
        {

            Func<int, char,double> d1 = m1;
            double xx = d1(88, 'a');

            Action<byte, string> d2 = m2;
            d2(234, "xyz");

           Predicate<long> d3 = m3;
            Func<long, string, bool> ff = m4;
            bool bb = ff(10, "yes/no");
           

        }
    }


    class Class2
    {


        static void m4(int a,float b)
        {
            Console.WriteLine("in m1"+(a+b));
        }
        static void m5(string msg)
        {
            Console.WriteLine("welcome"+msg);
        }
        static int cube(int x)
        {
            return x * x * x;
        }
        static float AreaOfcircle(int r)
        {
            return 3.14f * r * r;
        }
        static bool isEven(int x)
        {
            return x % 2 == 0;
        }
        static void Main(string[] args)
        {
            Action<int, float> d1 = m4;
            d1(11, 2.3f);

            Action<string> d2 = m5;
            d2("good morning");

            Func<int, float> d3 = AreaOfcircle;
            float area = d3(5);

            Func<int, bool> d4 = isEven;

            Predicate<int> d5 = isEven;

        }
    }
}
