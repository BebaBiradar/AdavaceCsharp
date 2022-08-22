using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AdavaceCsharp.ThreadDe
{
    
    //JOIN ==>the currentl thread which is exicuting  the method 
    //will wait till t1 thread completes its logic

            
    class JoinDemo
    {
       static void m1()
        {
            for(int i=1;i<=20;i=i+2)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
            }
       }
        static void Main(string[] args)
        {
            Console.WriteLine("main thread");
            Thread t1 = new Thread(m1);
            t1.Join();
            for(int i=200;i<=220;i=i+2)
            {
                Console.WriteLine("mai"+i);
            }
        }
    }
}
