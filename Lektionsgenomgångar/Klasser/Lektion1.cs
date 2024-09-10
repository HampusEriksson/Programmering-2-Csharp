using System;

namespace FirstClass
{
    public class Enemy
    {
        // Attribut
        float damage;
        float hp;
        string name;
        int gold;
        bool isDead;
        
        // Konstruktor
        public Enemy(float damage, float hp, string name, int gold)
        {
            this.damage = damage;
            this.hp = hp;
            this.name = name;
            this.gold = gold;
            if (hp>0)
            {
                this.isDead = false;
            }
            else
            {
                this.isDead = true;
            }
        }
    
        // Metoder - funktioner som hanterar en klass

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {this.name}\nHp:{this.hp}");
        }

        public void TakeDamage(float damage)
        {
            Console.WriteLine($"{this.name} took {damage} damage.");

            this.hp -= damage;

            if (hp<=0)
            {
                this.isDead = true;
                Console.WriteLine($"{this.name} is dead.");
            }


        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Enemy enemy1 = new Enemy(160.0f, 100, "Olle", 100);
            Enemy enemy2 = new Enemy(160.0f, 200, "Alican", 3000);

            enemy1.PrintInfo();
            enemy2.PrintInfo();

            enemy1.TakeDamage(50);

            enemy2.TakeDamage(300);

        }
    }
}