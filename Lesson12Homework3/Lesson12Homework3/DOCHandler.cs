using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson12Homework3
{
    public class DOCHandler:AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Doc file is opened");
        }
        public override void Create()
        {
            Console.WriteLine("Doc file is created");
        }
        public override void Chenge()
        {
            Console.WriteLine("Doc file is changed");
        }
        public override void Save()
        {
            Console.WriteLine("Doc file is saved");
        }
    }
}
