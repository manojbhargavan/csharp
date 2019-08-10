using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basics
            string path = @"c:\windows";
            ShowLargeFileWithoutLinq(path);
            Console.WriteLine("***");
            ShowLargeFileWithLinq(path);
            Console.WriteLine("***");
            Console.WriteLine("***");
            

        }

        private static void ShowLargeFileWithLinq(string path)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            FileInfo[] files = dirInfo.GetFiles();
            foreach (var file in files.OrderByDescending(f => f.Length).Take(5))
            {
                Console.WriteLine($"{file.Name,-20}: {file.Length,10:N0}");
            }
        }

        private static void ShowLargeFileWithoutLinq(string path)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            FileInfo[] files = dirInfo.GetFiles();
            Array.Sort(files, new FileInfoComparer());

            for (int i = 0; i < 5; i++)
            {
                var file = files[i];
                Console.WriteLine($"{file.Name,-20}: {file.Length,10:N0}");
            }

        }

        public class FileInfoComparer : IComparer<FileInfo>
        {
            public int Compare(FileInfo x, FileInfo y)
            {
                return y.Length.CompareTo(x.Length);
            }
        }
    }
}
