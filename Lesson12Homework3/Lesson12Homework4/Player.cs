using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson12Homework4
{
    public class Player:IRecodable,IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Play");
        }
        public void Pause()
        {
            Console.WriteLine("Pause");
        }
        public void Stop()
        {
            Console.WriteLine("Stop");
        }
        public void Record()
        {
            Console.WriteLine("Record");
        }
        public void _Pause()
        {
            Console.WriteLine("_Pause");
        }
        public void _Stop()
        {
            Console.WriteLine("_Stop");
        }

    }
}
