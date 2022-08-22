using System;
using System.Collections.Generic;
using System.Text;

namespace AdavaceCsharp.CollectionD
{
    class SortedSetDeo
    {
        static void Main(string[] args)
        {
            SortedSet<String> hs = new SortedSet<string>();
            hs.Add("raman");
            hs.Add("leena");
            hs.Add("heena");
            hs.Add("beema");
            hs.Add("rama");
            foreach(string d in hs)
            {
                Console.WriteLine(d);
            }
        }
    }


    /*class mysort : IComparer<Emmp>
    {
        public int Compare(Empp e1, Empp e2)
        {
            return e1.Name.CompareTo(e2.Name);
        }
    }
    class SortedSetDeo1
    {
        static void Main(string[] args)
        {
            SortedSet<Empp> ss = new SortedSet<Empp>(new mysort());
            ss.Add(new Empp(12, "om", "it"));
            ss.Add(new Empp(13, "trisha", "it"));
            ss.Add(new Empp(2, "risha", "testing"));
            foreach (Empp e in ss)
                Console.WriteLine(e);
        }
    }*/

}
