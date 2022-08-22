using System;
using System.Collections.Generic;
using System.Text;

namespace AdavaceCsharp.ExcepationD
{
    class Class2
    {
        static void m1()
        {
            Console.WriteLine("m1 starts");
            Console.WriteLine("enter number");

            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("m1 ends");
        }
        public static void m2()
        {
            m1();
            Console.WriteLine("in mssserfdfgg");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("main starts");
            try
            {
                m2();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("main ends");
        }
    }
    
}
