using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace AdavaceCsharp.CollectionD.NonGenaricD
{

    //non generic can store hetrogenous(mix) data arraylist
    //autoboxing--automatically converting primitive to respective object

    class ArrayListDemo
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();
            a1.Add(12);
            a1.Add("omkar");
            a1.Add("true");
            a1.Add(new StringBuilder("beba"));
            foreach(object ob in a1)
                Console.WriteLine(ob);

            /*for(int i=0;i<a1.Count;i++)
                Console.WriteLine(a1[i]);*/

        }
    }
}
