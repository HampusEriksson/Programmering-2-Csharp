using System;
using System.Xml.Linq;

namespace Lektion6
{
    
    
    internal class Program
    {

        //Basklass / parent-class
        public class Pet
        {
            // Attribut
            public string name;
            public string breed;
            public string color;
            public int age = 0;

            // Konstruktor
            public Pet(string name, string breed, string color)
            {
                this.name = name;
                this.breed = breed;
                this.color = color;
            }

            public virtual void MakeSound()
            {
                Console.WriteLine($"{name} makes a sound!");
            }
        }

        public class Dog : Pet
        {
            // Specifikt attribut för klassen Dog
            string favorite_food;

            public Dog(string name, string breed, string color, string favorite_food) : base(name, breed, color)
            {
                this.favorite_food = favorite_food;
            }

            public  override void MakeSound()
            {
                Console.WriteLine($"{name} barks!");
            }
        }

        public class Cat : Pet
        {
            int lives = 9;
            public Cat(string name, string breed, string color) : base(name, breed, color)
            {

            }

            public void LoseLife()
            {
                lives -= 1;

            }

            public override void MakeSound()
            {
                Console.WriteLine($"{name} meows!");
            }
        }





        static void Main(string[] args)
        {
            Dog my_dog = new Dog("Fido", "Labrador", "Gul", "Hamburger");
            my_dog.MakeSound();

            Cat my_cat = new Cat("Musse", "Bondkatt", "Svart");
            my_cat.MakeSound();

            
        }
    }
}
