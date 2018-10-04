using System;
using System.Collections.Generic;

namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> Showroom = new HashSet<string>() {
            ("Mustang"),
            ("Challenger"),
            ("Lamborghini"),
            ("Corvette"),
            ("Corvette")
            };

            HashSet<string> UsedLot = new HashSet<string>();
            UsedLot.Add("Porsche");
            UsedLot.Add("Ferrari");

            Showroom.UnionWith(UsedLot);

            Showroom.Remove("Challenger");

            HashSet<string> Junkyard = new HashSet<string>() {
                ("Taurus"),
                ("Eclipse"),
                ("Equinox"),
                ("Charger"),
                ("Porsche"),
                ("Corvette")
            };

            HashSet<string> Clone = new HashSet<string>(Showroom);

            Clone.IntersectWith(Junkyard);

            Showroom.UnionWith(Junkyard);

            Showroom.Remove("Taurus");
            Showroom.Remove("Equinox");

            foreach (string model in Showroom)
            {
                Console.WriteLine($"{model}");
            }
        }
    }
}
