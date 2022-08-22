using System;
using System.Collections.Generic;
using System.Text;

namespace AdavaceCsharp.CollectionD
{
    //add remove replace
    class Class1
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();
            lst.Add(100);
            lst.Add(200);
            lst.Add(300);
            lst.Add(400);
            lst.Add(500);
            lst.Add(300);
            lst.Add(300);
            lst.Add(300);
            lst.Remove(300);
            lst[0] = 1000;//
            Console.WriteLine(lst.Count);
            Console.WriteLine(lst.Capacity);
            for(int i=0;i<lst.Count;i++)
                Console.WriteLine(lst[i]);
            foreach (int data in lst)
                Console.WriteLine(data);
            //lst.Clear();
            Console.WriteLine(lst.Contains(90));
            Console.WriteLine("indexOf"+lst.IndexOf(300));
            List<int> lst2 = new List<int>() { 111, 112, 113 };
            lst2.AddRange(lst);
            lst2.InsertRange(1, lst);
            for(int i=0;i<lst2.Count;i++)
                Console.WriteLine(lst2[i]+" ");


        }
    }

    class Evennumber
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>() { 11, 45, 34, 66, 79, 99, 13 };
            List<int> l2 = new List<int>();
            List<int> l3 = lst.FindAll(a => a % 2 == 0);//using lambada 
            /*foreach(int d in lst)
            {
                if(d%2==0)
                {
                    l2.Add(d);
                }
            }*/
        }
    }
}
