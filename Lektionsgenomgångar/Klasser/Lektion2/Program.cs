using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion2
{

    class Player
    {
        // Attribut
        float hp;
        float durability;
        string name;
        int nr_of_bikes;

        // Konstruktor
        public Player(float hp, float durability, string name)
        {
            this.hp = hp;
            this.durability = durability;
            this.name = name;
            
        }

        // ToString-metod
        public override string ToString()
        {
            return "Name: " + this.name;
        }

        // Metoder
        public void BaxaCykel()
        {
            // Samma sak som nr_of_bikes += 1
            nr_of_bikes++;
            Console.WriteLine($"{this.name} baxade en cykel. Antal cyklar nu: {nr_of_bikes}");

        }
        

    }

    internal class Program
    {
        static void Main()
        {
            string test = "Testing!!";
            Console.WriteLine(test);

            Player p1 = new Player(100f, 50f, "Mahmoud");

            Console.WriteLine(p1);
            Player p2 = new Player(200f, 70f, "Ayhan");
            p2.BaxaCykel();
            Console.WriteLine(p2);

        }
    }
}
