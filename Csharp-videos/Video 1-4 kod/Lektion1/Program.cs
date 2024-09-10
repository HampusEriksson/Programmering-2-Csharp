using System;

class Program
{
    static void Main()
    {
        //Lektion1();
        //Lektion2();
        //Lektion3();
        Lektion4();

    }

    // Enkel funktion utan returvärde

    static void Greet(string name)
    {
        Console.WriteLine($"Hej {name}!");
    }


    // Funktion med returvärde

    static int Add(int a, int b)
    {
        return a + b;
    }


    // Funktion med standardvärden

    static void GreetWithTime(string name, string timeOfDay = "dag")
    {
        Console.WriteLine($"God {timeOfDay},  {name}");
    }


    static void Lektion4()
    {
        Greet("Hampus");

        int result = Add(3, 5);
        Console.WriteLine($"Summan är: {result}");

        GreetWithTime("Hampus", "Natt");
    }

    static void Lektion3()
    {
        // While-loop
        int counter = 0;

        while (counter < 5)
        {
            Console.WriteLine($"While loop, iteration {counter}");
            counter += 1;
            // counter++;
        }

        // For loop över en lista
        List<string> fruits = new List<string> { "äpple", "banan", "körsbär" };

        foreach (string fruit in fruits)
        {
            Console.WriteLine($"For loop, frukt: {fruit}");
        }

        // For loop med range

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"For loop med range, iteration {i}");

        }


        // Dictionary

        Dictionary<string, object> person = new Dictionary<string, object>
        {
            { "name", "Alice"},
            {"age", 25 },
            { "city", "Stockholm"}

        };

        // Loop genom dictionary

        foreach (var stat in person)
        {

            Console.WriteLine($"Nyckel: {stat.Key}, Värde {stat.Value}");

        }
    }

    static void Lektion2()
    {
        // Lista
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        Console.WriteLine($"Första talet i listan: {numbers[0]}");

        // Lägg till ett element i listan
        numbers.Add(6);
        Console.WriteLine($"Lista efter append: {string.Join(", ", numbers)}");

        // Dictionary

        Dictionary<string, object> person = new Dictionary<string, object>
        {
            { "name", "Alice"},
            {"age", 25 },
            { "city", "Stockholm"}

        };

        Console.WriteLine($"Personens namn: {person["name"]}");

        // Lägg till ett nyckel-värde par
        person["job"] = "lärare";

        Console.WriteLine($"Uppdaterat dictionary: {string.Join(", ", person)}");



    }

    static void Lektion1()
    {
        // Variabler och datatyper
        string name = "Alice";
        name = "Bob";
        int age = 25;
        float height = 1.75f;


        // Input och omvandling
        Console.Write("Vad heter du? ");
        string user_name = Console.ReadLine();

        Console.Write("Hur gammal är du?");
        int user_age = int.Parse(Console.ReadLine());


        // Format-string

        Console.WriteLine($"Hej {user_name}, du är {user_age} år gammal.");

        // If-else

        if (user_age >= 18)
        {
            Console.WriteLine("Du är myndig.");
        }
        else
        {
            Console.WriteLine("Du är inte myndig.");
        }

        // Slumpmässigt tal
        Random random = new Random();
        int random_number = random.Next(11);
        Console.WriteLine($"Slumpmässigt tal: {random_number}");


        // Omvandling mellan datatyper

        string nr_str = random_number.ToString();
        Console.WriteLine(nr_str);

    }
}
