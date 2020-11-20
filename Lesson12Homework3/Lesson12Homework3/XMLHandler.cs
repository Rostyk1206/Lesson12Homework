using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson12Homework3
{
    class XMLHandler:AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("XML file is opened");
        }
        public override void Create()
        {
            Console.WriteLine("XML file is created");
        }
        public override void Chenge()
        {
            Console.WriteLine("XML file is changed");
        }
        public override void Save()
        {
            Console.WriteLine("XML file is saved");
        }
    }
}
