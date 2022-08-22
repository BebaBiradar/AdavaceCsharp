using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace AdavaceCsharp.DelegateD
{   
    //delegate is used for callback function
    class DelegatFunctionCall
    {
    
        static void greet()
        {
            Console.WriteLine("happy morning");
        }
        static void m2(int a,int b,Action e)
        {
            Console.WriteLine("addition"+(a+b));
            e();
        }
        static void Main(string[] args)
        {
            m2(10, 20, greet);
        }
    }

    class Program
    {
        static void greet1()
        {
            Console.WriteLine("happ");
        }
        static void m3(int a,int b, Action d1)
        {
            Console.WriteLine("Addition"+(a+b));
            d1();
        }
        static bool isEven(int n)
        {
            Console.WriteLine("in even"+n);
            return n % 2 == 0;
        }
        static void print(int a)
        {
            Console.WriteLine("*",a);
        }
        static void Main(string[] args)
        {
            m3(10, 20,()=>Console.WriteLine("happy"));

            List<int> lst = new List<int>() { 11, 45, 66, 78, 99, 89 };
            List<int> l3 = lst.FindAll(a => a % 2 == 0);
            lst.ForEach(d => Console.WriteLine(d));//using lambda (optinal we can use this one or below two methods ForEach and foreach)
           //print all
            lst.ForEach(print);//using ForEach

             /*foreach(int d in l3)//using foreach any one we can use
                 Console.WriteLine(d);
            List<int> l2 = new List<int>();
            foreach(int d in lst)
            {
                if(d%2==0)
                {
                    l3.Add(d);
                }
            }*/

        }
    }
}
