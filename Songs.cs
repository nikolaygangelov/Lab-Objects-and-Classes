

namespace _3._Songs
{
    using System;
    using System.Linq;
    using System.Numerics;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < N; i++)
            {
                string[] songInfo = Console.ReadLine()
                    .Split('_')
                    .ToArray();
                string typeList = songInfo[0];
                string songName = songInfo[1];

                Song song = new Song(typeList, songName);
                songs.Add(song);
            }

            string command = Console.ReadLine();

            for (int i = 0; i < songs.Count; i++)
            {
                Song currentSong = songs[i];

                if (command == "all")
                {
                    Console.WriteLine(currentSong.Name);
                }
                else if (command == currentSong.TypeList)
                {
                    Console.WriteLine(currentSong.Name);
                }
            }
        }
    }

    public class Song
    {
        public Song(string typeList, string songName)
        {
            TypeList = typeList;
            Name = songName;
        }
        public string TypeList { get; set; } 
        public string Name { get; set; } 
        
    }
}
