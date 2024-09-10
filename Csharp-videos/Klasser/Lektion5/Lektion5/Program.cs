using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion5
{

    public class Person
    {
        // Attribut
        private string name;
        private string city;
        private int age;

        // Konstruktor
        public Person(string name, string city, int age)
        {
            this.name = name;
            this.city = city;
            this.age = age;
        }

        // Metod - Funktion i en klass

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, City: {city}");
        }

        public void Birthday()
        {
            Console.WriteLine($"Happy birthday {name}!");
            age += 1;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person me = new Person("Hampus", "Stockholm", 30);
            me.DisplayInfo();
            me.Birthday();
            me.DisplayInfo();
            Person alice = new Person("Alice", "Lund", 22);
            Person my_enemy = new Person("Olle", "Stockholm", 45);

        }
    }
}
