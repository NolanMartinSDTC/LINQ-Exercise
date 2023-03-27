using System;
using System.Collections.Generic;
using System.Linq;



namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>()
            {
                "Call of Duty: Modern Warfare",
                "Call of Duty: Black Ops",
                "Overwatch",
                "Fortnite",
                "Diablo",
                "GTA"
            };

            Console.WriteLine("Shortest to Longest Video Game Names:\n");
            videoGames.OrderBy(game => game.Length).ToList().ForEach(Console.WriteLine);

        }
    }
}
