using System;
using ProjetoDioOOcomRPG.Entities;

namespace ProjetoDioOOcomRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            MagicHero topapa = new MagicHero(
                name: "Topapa",
                level: 42,
                hp: 385,
                mp: 641,
                heroType: "Black Wizard"
            );

            MagicHero jenica = new MagicHero(
                name: "Jenica",
                level: 42,
                hp: 601,
                mp: 482,
                heroType: "White Wizard"
            );

            PhysicalHero arcus = new PhysicalHero(
                name: "Arcus",
                level: 42,
                hp: 749,
                mp: 72,
                heroType: "Knight"
            );

            PhysicalHero wedge = new PhysicalHero(
                name: "Wedge",
                level: 42,
                hp: 749,
                mp: 72,
                heroType: "Ninja"
            );

            System.Console.WriteLine(arcus.Attack());
            System.Console.WriteLine(topapa.Attack(32));
            System.Console.WriteLine(wedge.Attack(10));
            System.Console.WriteLine(jenica.Attack());
        }
    }
}
