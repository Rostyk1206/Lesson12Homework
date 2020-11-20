using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson12Homework3
{
    public class TXTHandler:AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("TXT file is opened");
        }
        public override void Create()
        {
            Console.WriteLine("TXT file is created");
        }
        public override void Chenge()
        {
            Console.WriteLine("TXT file is changed");
        }
        public override void Save()
        {
            Console.WriteLine("TXT file is saved");
        }
    }
}
