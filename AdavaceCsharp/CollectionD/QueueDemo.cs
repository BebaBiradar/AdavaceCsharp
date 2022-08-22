using System;
using System.Collections.Generic;
using System.Text;

namespace AdavaceCsharp.CollectionD
{
    class QueueDemo
    {
        //FIFO First in frist out 
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(100);
            q.Enqueue(200);
            q.Enqueue(300);
            q.Enqueue(400);
            foreach(int d in q)
                Console.WriteLine(d);
            Console.WriteLine("------");
            int remove = q.Dequeue();
            
            foreach (int d in q)
                Console.WriteLine(d);
            Console.WriteLine("-----------");
            /*q.Clear();
            q.CopyTo()*/


        }
    }
}
