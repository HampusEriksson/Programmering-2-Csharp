using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion3
{

    // Enemy är bas-klass / parent-class för Zombie, Goomba
    public class Enemy
    {
        // Attribut
        public int health;
        public int damage;
        public float speed;
        public int size;

        // Konstruktor
        public Enemy(int health, int damage, float speed)
        {
            this.health = health;
            this.damage = damage;
            this.speed = speed;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("The enemy makes a sound");
        }
    }

    class Zombie : Enemy
    {
        // Attribut specifikt för Zombie
        int arms;

        //Konstruktor
        public Zombie(int health, int damage, float speed, int arms) : base(health, damage, speed)
        {
            this.arms = arms;
        }

        public override void MakeSound()
        {
            Console.WriteLine("The zombie makes a sound: AARHGRGR");

        }
    }

    class Goomba : Enemy
    {
        bool teeth;
        public Goomba(int health, int damage, float speed, bool teeth) : base(health, damage, speed)
        {
            this.teeth = teeth;
        }

        public override void MakeSound()
        {
            Console.WriteLine("The goomba makes a sound: MEEEH");

        }
    }


    internal class Program
    {
        static void Main()
        {
            Zombie zombie1 = new Zombie(100, 50, 3, 2);
            Goomba goomba1 = new Goomba(50, 3, 5, true);

            zombie1.MakeSound();
            goomba1.MakeSound();
            
        }
    }
}
