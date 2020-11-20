using System;

namespace Lesson12Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler file1 = new DOCHandler();
            file1.Open();
            file1.Create();
            file1.Chenge();
            file1.Save();
            Console.WriteLine();
            AbstractHandler file2 = new TXTHandler();
            file2.Open();
            file2.Create();
            file2.Chenge();
            file2.Save();
            Console.WriteLine();
            AbstractHandler file3 = new XMLHandler();
            file3.Open();
            file3.Create();
            file3.Chenge();
            file3.Save();
        }
    }
}
