using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Collections;

namespace AdavaceCsharp.ThreadDe
{
    class SingleTharedDemo
    {


        static void m1()
        {
            for(int i=1;i<=100;i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("main starts");
            Thread t1 = new Thread(m1);
            t1.Start();
            for(int i=1;i<=100;i++)
            {
                Console.WriteLine("gm");
            }
            Console.WriteLine("main ends");
        }
    }
}
