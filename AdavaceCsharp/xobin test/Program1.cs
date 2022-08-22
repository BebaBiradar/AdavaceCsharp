using System;
using System.Collections.Generic;
using System.Text;

namespace AdavaceCsharp.Papar.xobin_test
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the ss");
            string str = "";    
            string input = Console.ReadLine();
            Console.WriteLine(Check.CheckOccurances(input));

        }
    }
    static class Check
    {
        public static int CheckOccurances(String input)
        {
            int count = 1;
            int a = 0;
            while((a=input.IndexOf(input,a))!=-1)
            {
                a += input.Length;
                count++;
            }
            return count;
        }
    }

    class Demo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            string Word = Console.ReadLine();
            string[] wrd = str.Split(' ');
            int c = 0;
            for(int i=0;i<wrd.Length;i++)
            {
                if(Word.Equals(Word[i]))
                {
                    c++;
                }
            }

            Console.WriteLine(c);
        }
    }
    

    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
           string  str = Console.ReadLine();
            string strnew = "";
            for(int i=0;i<str.Length;i++)
            {
                char ch = str[i];
                if (ch >'A'&&ch<='Z')
                {
                    ch = (char)(ch + 32);
                }
                else
                {
                    ch = (char)(ch - 32);
                }
                strnew = strnew + ch;
            }
            Console.WriteLine(strnew);

        }
    }







    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            string newstr = "";
            for(int i=0;i<str.Length;i++)
            {
                char ch = str[i];
                {
                    if(Char.IsUpper(ch))
                    {
                        ch = (char)(ch + 32);
                    }
                    else if(Char.IsLower(ch))
                    {
                        ch = (char)(ch - 32);
                    }
                    newstr = newstr + ch;
                }
                Console.WriteLine(newstr);
            }
        }
    }



    /*class Program5
    {
        static void Main(string[] args)
        {
            string str1 = "hello world";

            Console.WriteLine("Occurence:"+Check.CheckOccurances1(str1,"hello"));

        }
    }
     static class Check2
    {
        public static int CheckOccurances1(String str1,string pattern)
        {
            int count = 0;
            int a = 0;
            while ((a = str1.IndexOf(pattern,a))!=-1)

            {
                a += pattern.Length;
                count++;
            }
            return count;
        }
    }*/
}
