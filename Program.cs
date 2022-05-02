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

            Batalha(jenica, wedge);

            Console.Write("");
            Console.WriteLine("");
        }
        public static void Batalha(Hero hero1, Hero hero2){
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine( $"x {x}");
            Console.WriteLine( $"Nome Jogador 1 {hero1.Attack()}");
            Console.WriteLine( $"Nome Jogador 2 {hero2.Attack()}");
        }
    }
}
