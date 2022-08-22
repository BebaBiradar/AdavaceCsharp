using System;
using System.Collections.Generic;
using System.Text;

namespace AdavaceCsharp.CollectionD
{
   /* array -fixed size,homogenous element .primitive and non primitive 
        collection -growable,homogenus /hetrogenus ,objects
        Autoboxing convert primitive to object*/


    class LinkedListDemo
    {
        static void Main(string[] args)
        {
            /* //autoboxing 
             int a = 10;
             object ob = a;*/

            LinkedList<int> ll = new LinkedList<int>();
            ll.AddLast(100);
            ll.AddLast(200);
            ll.AddLast(300);
            ll.AddLast(200);

            LinkedListNode<int> nn = ll.Find(200);
            ll.AddBefore(nn, 1000);
            ll.AddAfter(nn, 2000);

            ll.Clear();

            Console.WriteLine(ll.Count);
            Console.WriteLine(ll.Contains(34));
            /*int x = ll.First();
            int last = ll.Last();*/
            ll.Remove(90);
            foreach (int d in ll)
                Console.WriteLine(d);
                
                
        }
    }
}
