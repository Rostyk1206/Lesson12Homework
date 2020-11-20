using System;

namespace Lesson12Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayable player_first = new Player();
            IRecodable player_second = new Player();

            player_first.Stop();
            player_first.Pause();
            player_first.Stop();

            player_second.Record();
            player_second._Pause();
            player_second._Stop();
        }
    }
}
