using System;
using System.Collections.Generic;
using System.Linq;


namespace songs
{

    class Program
    {
        static void Main(string[] args)
        {

            int songsNumber = int.Parse(Console.ReadLine());
            List<Songs> songs = new List<Songs>();

            for (int i = 0; i < songsNumber; i++)
            {
                Songs song = new Songs();
                string[] songInfo = Console.ReadLine().Split("_").ToArray();

                song.TypeList = songInfo[0];
                song.Name = songInfo[1];
                song.Time = songInfo[2];

                songs.Add(song);

            }
            string command = Console.ReadLine();
            if (command == "all")
            {
                foreach (Songs song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Songs song in songs)
                {
                    if (command ==song.TypeList)
                        Console.WriteLine(song.Name);
                }
            }
        }
        class Songs
        {
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }
        }
    }
}
