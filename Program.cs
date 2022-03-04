using ExercicioDioAbstracaoRPG.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ExercicioDioAbstracaoRPG
{
    class Program
    {
        static ICollection<Hero> listHero = new List<Hero>();

        static void Main(string[] args)
        {
            var sw = new Stopwatch(); // Measures elapsed time by counting timer ticks in the underlying timer mechanism
            sw.Start();

            listHero.Add(new Swordsman("Scarlett", 5, 90, 80, 20, "Double Blade"));
            listHero.Add(new Wizard("Mosquet", 2, 103, 10, 8, "Ilusion"));
            listHero.Add(new Apprentice("Nichols", 2, 100, 5, 8));
            listHero.Add(new Swordsman("Mikasa", 10, 12, 50, 60, "Single Blade"));
            listHero.Add(new Apprentice("Mary", 8, 68, 5, 8));

            PrintHeroes(); // Calls method to shows the Heroes

            sw.Stop();
            Console.WriteLine("Total time in this application : " + sw.ElapsedMilliseconds.ToString() + " milliseconds"); // Prints the elapsed time
        }

        static void PrintHeroes() // Shows the heroes
        {
            var heroes = listHero.OrderBy(x => x.HeroType).ThenBy(x => x.Name); // Heroes by Type and by Name

            int index = 1;
            if (listHero.Count > 0) // If there is Hero (List not empty).
            {
                foreach (var hero in heroes)
                {
                    Console.WriteLine($"#{index}/{listHero.Count}\n" + hero); // Prints Heroes
                    index++;
                }
            }
        }
    }
}

/*
    Possibilidades de instanciação e uso de proprieties
    var sw1 = new Swordsman("Swordsman","Esloveno", 10, 50, 20, "Double Blade");
    var sw2 = new Swordsman("Swordsman", "Mosquet", 10, 50, 20, "Single Blade");
    listHero.Add(sw1);
    listHero.Add(sw1);

    //Console.WriteLine(sw1);
    //Console.WriteLine(sw2);
*/