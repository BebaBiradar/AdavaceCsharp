using System;
using System.Collections.Generic;
using System.Text;

namespace AdavaceCsharp.CollectionD
{
    class HashSetDemo
    {
        static void Main(string[] args)
        {
            //union,intersection,SubsetOf,SupersetOf
            HashSet<String> hs1 = new HashSet<string>() { "om", "raj", "ram", "siya" };
            HashSet<string> hs2 = new HashSet<string>(){ "omkar","raj","ram","siya"};
            
          // HashSet<String> h3 = hs1.IntersectWith(hs2).ToHashSet();
            hs1.IntersectWith(hs2);
            hs1.UnionWith(hs2);
            bool b1 = hs1.IsSubsetOf(hs2);
            bool b2 = hs2.IsSubsetOf(hs1);
            foreach(string d in hs1)
                Console.Write(d+"");
            Console.WriteLine();
            foreach(string d in hs2)
               Console.Write(d+"");
            Console.WriteLine();
            /*foreach(string d in h3)
                Console.WriteLine(d);*/





        }
    }
}
