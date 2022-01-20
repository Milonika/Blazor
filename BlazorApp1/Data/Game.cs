using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Game
    {
        public Game()
        {
        }

        public Game(string name, string category, string players, string size)
        {
            name = Name;
            category = Category;
            players = Players;
            size = Size;
        }

        public string Name { get; set; }
        public string Category { get; set; }
        public string Players { get; set; }
        public string Size { get; set; }

        public static List<Game> GetGame()
        {
            List<Game> gm = new List<Game>();
            gm.Add(new Game() { Name = "Stardew Valley", Category = "Инди", Players = "Однопользовательская", Size = "500MB" });
            gm.Add(new Game() { Name = "Warframe", Category = "Экшен", Players = "Коопеатив", Size = "60GB" });
            gm.Add(new Game() { Name = "Forza Horizon 5", Category = "Гонки", Players = "Многопользовательсякая", Size = "110GB" });
            gm.Add(new Game() { Name = "Tiny Bunny", Category = "Инди", Players = "Однопользовательская", Size = "800MB" });
            return gm;
        }
    }
}
