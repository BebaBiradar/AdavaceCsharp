using System;
using System.Collections.Generic;
using System.Text;

namespace AdavaceCsharp.Papar
{
   /* class Class1
    {
        static void Main(string[] args)
        {
            List<string> ll = new List<string>() { "om", "raj", "beba", "sony" };
            string temp = ll[1];
            ll[1] = ll[2];
            ll[2] = temp;
            //Console.WriteLine(ll.Count);
           // Console.WriteLine(string.Join(" ",ll));
        }
    }*/

    class Program
    {
        public static void Swap<T>(List<T> List,int i,int j)
        {
            T temp = List[i];
            List[i] = List[j];
            List[j] = temp;
        }
    }
    public class Exaple
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>() { 1, 2, 3, 4, 5, };
            Program.Swap(num, 1, 2);
            Console.WriteLine(string.Join(" ",num));
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            List<string> ll = new List<string>();
            ll.Add("red");
            ll.Add("pink");
            ll.Add("blue");
            ll.Add("yellow");
            ll.Add("green");
            /*Console.WriteLine(ll.Count);
            Console.WriteLine(ll.Capacity);*/
            Console.WriteLine(string.Join(" ",ll));

        }
    }

    class  Program2
    {
        static void Main(string[] args)
        {
            List<string> lll = new List<string>();
            lll.Add("Raj");
            lll.Add("Adil");
            lll.Add("Ram");
            lll.Add("Sham");
            lll.Add("Rohid");
            Console.WriteLine(string.Join(" ",lll));
            lll.Remove("Adil");
            Console.WriteLine(string.Join(" ",lll));
            lll[1] = "Balaji";
            Console.WriteLine(string.Join(" ",lll));
        }
    }

    class Program3
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int>();
            number.Add(10);
            number.Add(20);
            number.Add(30);
            number.Add(40);
            number.Add(50);
            int[] a = number.ToArray();
            Console.WriteLine("the array element are:");
            foreach(int i in a)
            {
                Console.WriteLine(i);
            }
        }
    }

    class ArraytoList
    {
        static void Main(string[] args)
        {
            //create array
            string[] s = new string[] { "sunday", "monday", "tuesday" };
            //create list
            List<string> days = new List<string>(s);
            Console.WriteLine("the list elments are:");
            foreach(string i in days)
            {
                Console.WriteLine(i);
            }

        }
    }

    class Program4
    {
        static void Main(string[] args)
        {
            List<string> lll = new List<string>();
            lll.Add("Raj");
            lll.Add("Adil");
            lll.Add("Ram");
            lll.Add("Sham");
            lll.Add("Rohid");
            Console.WriteLine("original list names");
            Console.WriteLine("-----------------------");
            foreach(string a in lll)
                Console.WriteLine(a);
            lll.Reverse();
            Console.WriteLine("----------");
            foreach(string a in lll)
                Console.WriteLine(a);

        }
    }

    class StudentDetails
    {
        public int stdentid { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public int totalmarks { get; set; }
    }
    class Student
    {
        static void Main(string[] args)
        {
            StudentDetails sone = new StudentDetails()
            {
                stdentid = 10,
                name = "raj",
                totalmarks = 446
            };
            StudentDetails stwo = new StudentDetails()
            {
                stdentid = 20,
                name = "sohm",
                totalmarks = 449
            };
            List<StudentDetails> StudentDetailsList = new List<StudentDetails>();
            StudentDetailsList.Add(sone);
            StudentDetailsList.Add(stwo);
            StudentDetails s = StudentDetailsList[0];
            foreach (StudentDetails d in StudentDetailsList)
                Console.WriteLine("student id is:{0}, student name is{1},student gender is{2},student marks is{3}", s.stdentid, s.name, s.gender, s.totalmarks);


        }
    } 
    
    class Program5
    {
        static void Main(string[] args)
        {
            List<string> lll = new List<string>();
            lll.Add("Raj");
            lll.Add("Adil");
            lll.Add("Ram");
            lll.Add("Sham");
            lll.Add("Rohid");
            Console.WriteLine("original list");
            Console.WriteLine("--------------");
            foreach(string a in lll)
                Console.WriteLine(a);
            lll.Sort();
            Console.WriteLine();
            Console.WriteLine("sorted list");
            Console.WriteLine("--------------");
            foreach(string a in lll)
                Console.WriteLine(a);


         
        }
    }
}
