using System;
using System.Collections.Generic;
using System.Text;

namespace AdavaceCsharp.ExcepationD
{
    //delegets is variable which holds reference of a function
    //its a ponter to function 
    //declare a delegate
    //set a target
    //Invoke

    //singlecast Delegate

    public delegate void mydel1();
    class Class3
    {
        static void greet1()
        {
            Console.WriteLine("good morning");
        }
        static void Main(string[] args)
        {
            mydel1 d1 = greet1;
            d1();
        }
        

    }


    public delegate void mydel();//declare deleget
    class SingleDelgateD
    {
        public delegate int mydel2(int a, int b);
        public static int Add(int a,int b)
        {
            Console.WriteLine("ADD="+(a+b));
            return a + b;
        }
        static void greet()
        {
            Console.WriteLine("good evening");
        }
        static void Main(string[] args)
        {
            mydel d1 = greet;
            d1();
            mydel2 d2 = Add;
            int r;
            r = d2(10, 20);


        }
    }
}
