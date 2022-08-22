using System;
using System.Collections.Generic;
using System.Text;

namespace AdavaceCsharp.ExcepationD
{
    class AllException
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welvome");
            Console.WriteLine("enter number");
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Division :" + a / b);
                Console.WriteLine("try ends");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("1");
                Console.WriteLine(e.Message);

            }
            catch(FormatException e)
            {
                Console.WriteLine("2");
                Console.WriteLine(e.Message);
            }
            catch(SystemException e)//universal handler it should be always last
            {
                Console.WriteLine(e.Message);
            }
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
