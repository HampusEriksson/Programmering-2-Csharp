using System;

class Program
{
    static void Main()
    {
        // Variabler och datatyper
        string name = "Alice";
        int age = 25;
        double height = 1.75;  // meter

        // Input och omvandling
        Console.Write("Vad heter du? ");
        string userName = Console.ReadLine();

        Console.Write("Hur gammal är du? ");
        int userAge;
        while (!int.TryParse(Console.ReadLine(), out userAge))
        {
            Console.Write("Ogiltig inmatning. Ange ett heltal: ");
        }

        // Formatstring
        Console.WriteLine($"Hej {userName}, du är {userAge} år gammal.");

        // If-else
        if (userAge >= 18)
        {
            Console.WriteLine("Du är myndig.");
        }
        else
        {
            Console.WriteLine("Du är inte myndig.");
        }

        // Slumpmässigt tal
        Random random = new Random();
        int randomNumber = random.Next(1, 11); // Endast 1-10
        Console.WriteLine($"Slumpmässigt tal: {randomNumber}");

        // Omvandling mellan datatyper
        string heightStr = height.ToString();
        Console.WriteLine($"Höjden som sträng: {heightStr}");
    }
}
