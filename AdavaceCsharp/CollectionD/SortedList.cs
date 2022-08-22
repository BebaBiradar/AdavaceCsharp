using System;
using System.Collections.Generic;
using System.Text;

namespace AdavaceCsharp.CollectionD
{
    class SortedListd
    {
        //stores data in sorted order according the keys
        //tree
        //Binary search tree--->binary
        static void Main(string[] args)
        {
            SortedList<String, int> ss = new SortedList<string, int>();
            ss.Add("Devesh", 90);
            ss.Add("Amey", 90);
            ss.Add("chirag", 90);
            ss.Add("siya", 90);
            ss.Add("saif", 90);
            ss.Add("tanish", 90);
            ss.Add("harsh", 90);
            
            foreach(KeyValuePair<string,int>kv in ss)
            {
                Console.WriteLine(kv.Key+"===>"+kv.Value);
            }
        }
    }



    class myStringBuilderSort:IComparer<StringBuilder>
    {
        public int Compare(StringBuilder x,StringBuilder y)
        {
            return x.ToString().CompareTo(y.ToString());
        }
    }
    class Demo
    {
        static void Main(string[] args)
        {
            SortedList<StringBuilder, int> sb = new SortedList<StringBuilder, int>(new myStringBuilderSort());
            sb.Add(new StringBuilder("amit"), 90000);
            sb.Add(new StringBuilder("Sumit"), 90000);
            sb.Add(new StringBuilder("meet"), 90000);
            sb.Add(new StringBuilder("amit"), 90000);
            sb.Add(new StringBuilder("siya"), 90000);
            foreach (KeyValuePair<StringBuilder, int> kv in sb)
                Console.WriteLine(kv.Key + "==>" + kv.Value);
            Dictionary<StringBuilder, int> dd = new Dictionary<StringBuilder, int>(sb);

                    
                    


        }
    }
}
