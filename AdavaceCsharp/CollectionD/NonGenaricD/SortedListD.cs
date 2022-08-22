using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace AdavaceCsharp.CollectionD.NonGenaricD
{
    class SortedListD
    {
        static void Main(string[] args)
        {
            SortedList s1 = new SortedList();
            s1.Add("onn", "sdbdg");
            s1.Add("vg", 8990);
            s1.Add("cf", 7.8f);
            s1.Add(90, "hgh");

            foreach(object ob in s1)
                Console.WriteLine(ob);
        }
    }
}
