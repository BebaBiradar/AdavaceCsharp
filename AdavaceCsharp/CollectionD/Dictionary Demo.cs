using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace AdavaceCsharp.CollectionD
{
   class Dictionary_Demo
    {
        static void Main(string[] args)
        {

            /*string s = "pratiksha";
            char[] carr = s.ToCharArray();*/
            List<string> ll = new List<string>()
            { "red","pink","blue","red","pink","yellow","red"};
            //ke-color
            //value-count
            Dictionary<string, int> dd = new Dictionary<string, int>();
            //["red=1","pink=1","blue=1"]
            foreach(string color in ll)
            {
                if(dd .ContainsKey(color))
                {
                    int oldvalue = dd[color];
                    dd[color] = oldvalue + 1;
                }
                else
                {
                    dd.Add(color, 1);
                }
            }
            Console.WriteLine(ll);
        }
    }


    /*class classs4
    {
        static void Main(string[] args)
        {
            List<Emp> ll = new List<Emp>();
            ll.Add(new Emp

        }
    }*/
}
