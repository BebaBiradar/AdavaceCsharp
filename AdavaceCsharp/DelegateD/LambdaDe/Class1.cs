using System;
using System.Collections.Generic;
using System.Text;

namespace AdavaceCsharp.DelegateD.LambdaDe
{
    public delegate int myd(int n);
    class Class1
    { 
        static void Main(string[] args)
        {
          myd m = (n) =>
          {
            int i, f = 1;
             for (i = 1; i <= n; i++)
             {
              f = f * i;
             }
             return f;

          };
            int e = m(5);
            Console.WriteLine(e);
        }
        
    }


    public delegate void mydel(int n);
    class Fact
    {
        static void Main(string[] args)
        {
            mydel d = (a) =>
            {
                  int f = 1;
                  for (int i = 1; i <= a; i++)
                  {
                      f = f * i;
                  }
                  Console.WriteLine("factorial" + f);
            };
            d(10);
        }
    }
}
