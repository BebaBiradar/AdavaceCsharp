using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace AdavaceCsharp.FileHandlingDemo
{
   public  class Course
   {
        public int Id { get; set;}
        public string Name { get; set; }
        public int fee { get; set; }
   }
    static void WriteToFile(Course course)
    {
        try
        {
            FileStream fs = new FileStream(@"E:\Advance C sharpe\TestFolder\TestFile1", FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(course.Id);
            bw.Write(course.Name);
            bw.Write(course.fee);
            bw.Close();
            fs.Close();
            Console.WriteLine("data added to file");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
   
    static void Main(string[] args)
    {
        Course course = new Course { Id = 1, Name = "Abc", fee = 10000 };
    }
}
