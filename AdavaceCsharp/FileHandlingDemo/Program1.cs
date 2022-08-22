using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AdavaceCsharp.FileHandlingDemo
{

    //Using DirectoryInfo & file info class
    public class Program1
    {
        static void CreateFolder()
        {
            string path = @"E:\Advance C sharpe\Test";
            if (Directory.Exists(path))
            {
                Console.WriteLine("Folder is already created");
            }
            else
            {
                Directory.CreateDirectory(path);
                Console.WriteLine("folder is created");
            }
        }
        static void Main(string[] args)
        {
            CreateFolder();
        }
    }



    //using  Directoryinfo& file infoclass


    public class Program2
    {
        static void CreateFolder()
        {
            string path = @"E:\Advance C sharpe\TestFolder";
            DirectoryInfo d = new DirectoryInfo(path);
            if (d.Exists)
            {
                Console.WriteLine("Folder is already created");
            }
            else
            {
                d.Create();
                Console.WriteLine("Folder is created");
            }
        }
        static void CreateFile()
        {
            string path = @"E:\Advance C sharpe\TestFolder\TestFile1.txt";
            FileInfo f = new FileInfo(path);
            if (f.Exists)
            {
                Console.WriteLine("File already exits");
            }
            else
            {
                f.Create();
                Console.WriteLine("File created");
            }

        }
    }
}



