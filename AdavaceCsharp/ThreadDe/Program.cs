using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AdavaceCsharp.ThreadDe
{

    //synchronization =>common object being shared among multiple threads updates
    //inter thread wait=>common object one thread goes waiting
    class Program
    {
       
        public static void m1()
        {
            for (int i = 1; i <= 30; i = i + 2)
            {
                Console.WriteLine("odd"+i+Thread.CurrentThread.Name);
            }
        }

        static void Main(string[] args)
        {
            Thread main = Thread.CurrentThread;
            Thread t1 = new Thread(m1);
            t1.Name = "om";
            Console.WriteLine("priority=" + t1.Priority);
            Console.WriteLine("priority=" + t1.Priority);
            Thread t2 = new Thread(m1);
            t2.Name = "ram";
            t2.Priority = ThreadPriority.Highest;
            t1.Start();
            t2.Start();
            
            Thread.Sleep(1000);
            for (int i = 2; i <= 30; i = i + 2)
            {
                Console.WriteLine(i);
            }

            /*//isBackground thread
            Thread t3 = new Thread(m1);
            t3.IsBackground = true;//helper
            t3.Start();*/

        }
    }
}
