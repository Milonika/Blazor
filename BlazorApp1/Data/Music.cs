using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Music
    {
        public Music()
        {
        }

        public Music(string name, string author, string category, string time)
        {
            name = Name;
            author = Author;
            category = Category;
            time = Time;
        }

        public string Name { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public string Time { get; set; }

        public static List<Music> GetMusic()
        {
            List<Music> mus = new List<Music>();
            mus.Add(new Music() { Name = "Скорлупа", Author = "Источник", Category = "Pop Trip", Time = "2:32" });
            mus.Add(new Music() { Name = "Numb", Author = "LinkinPark", Category = "Rock", Time = "3:05" });
            mus.Add(new Music() { Name = "With Me", Author = "Sum 41", Category = "Rock", Time = "4:51" });
            mus.Add(new Music() { Name = "TheWaitingGame", Author = "BONES", Category = "Cloud rap", Time = "2:09"});
            return mus;
        }
    }
}
