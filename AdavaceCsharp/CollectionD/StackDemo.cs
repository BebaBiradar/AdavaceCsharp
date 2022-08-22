using System;
using System.Collections.Generic;
using System.Text;

namespace AdavaceCsharp.CollectionD
{
    class StackDemo
    {
        //stack follow LIFO method
        static void Main(string[] args)
        {
            Stack<string> st = new Stack<string>();
            st.Push("a");
            st.Push("b");
            st.Push("c");
            string[] arr = new string[st.Count];
            st.CopyTo(arr, 0);
            foreach (string d in arr)
                Console.WriteLine(d);
           // st.Clear();
            /*string dataremove = st.Pop();*/
            string datapeek = st.Peek();
            Console.WriteLine("Peek"+datapeek);
            /*foreach(string d in st)
             
            Console.WriteLine(d);
            Console.WriteLine("----------");
            string dataremove1 = st.Pop();
            foreach (string d in st)
                Console.WriteLine(d);*/

             

        }
    }

    
}
