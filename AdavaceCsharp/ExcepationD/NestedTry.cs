using System;
using System.Collections.Generic;
using System.Text;

namespace AdavaceCsharp.ExcepationD
{
    class NestedTry
    {
        static string mm;
        static void Main(string[] args)
        {
            Console.WriteLine("welcome");
            Console.WriteLine("eneter number");
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("divide:" + a / b);

                try
                {
                    Console.WriteLine("eneter age");
                    int c = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine(e.Message);

                }
                Console.WriteLine("try ends");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("1");
                Console.WriteLine(e.Message);
            }
        }
    }
}
