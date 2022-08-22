using System;
using System.Collections.Generic;
using System.Text;

namespace AdavaceCsharp.Papar
{
    class Empp
    {
        int eno;
        string name;
        string deptname;

        public Empp(int eno, string name, string deptment)
        {
            this.Eno = eno;
            this.Name = name;
            this.deptname = deptname;
        }

        public override string ToString()
        {
            return "Eno:" + eno + "Name:" + name + "Departmentname=" + deptname;
        }
        public int Eno { get => eno; set => eno = value; }
        public string Name { get => name; set => name = value; }
        public string Department { get => deptname; set => deptname = value; }
    }
    class Program22
    {
        static void Main(string[] args)
        {
            LinkedList<Empp> ll = new LinkedList<Empp>();
            ll.AddLast(new Empp(1, "AA", "IT"));
            ll.AddLast(new Empp(1, "BB", "TESTING"));
            ll.AddLast(new Empp(1, "CC", "HR"));
            ll.AddLast(new Empp(1, "DD", "IT"));
            ll.AddLast(new Empp(1, "EE", "IT"));
            ll.AddLast(new Empp(1, "FF", "HR"));
            ll.AddLast(new Empp(1, "GG", "TESTING"));

            String dname = " ";
            foreach(Empp e in ll)
            {
                if(e.Eno==10)
                {
                    dname = e.Department;
                    break;

                }
            }
            foreach(Empp e in ll)
            {
                if(e.Department==dname)
                {
                    Console.WriteLine(e);
                }
            }


        }
    }


   /* class Program2
    {
        static void Main(string[] args)
        {

        }
    }*/
}
