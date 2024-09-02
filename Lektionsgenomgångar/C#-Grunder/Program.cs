
// C# C-sharp
// Variabler och datatyper
string name = "Alice";
name = "Bob";
int age = 25;
float height = 1.75f;

// Input och omvandling
Console.WriteLine("Vad heter du?");
string user_name = Console.ReadLine();

Console.WriteLine("Hur gammal är du?");
int user_age = int.Parse(Console.ReadLine());

// Formatstring
Console.WriteLine($"Hej {user_name}, du är {user_age} år gammal.");

// If-else
if (user_age > 18)
{
    Console.WriteLine("Du är myndig med marginal.");
}
else if (user_age == 18)
{
    Console.WriteLine("Grattis, du blev precis myndig!");
}
else
{
    Console.WriteLine("Du är inte myndig.");
}

// Slumpmässigt tal
Random randomizer = new Random();
int random_nr = randomizer.Next(5, 100);
Console.WriteLine($"Slumpmässigt tal: {random_nr}");

// Omvandling mellan datatyper
age = 50;
string age_str = age.ToString();

string height_str = height.ToString();

// Lista
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
Console.WriteLine($"Första talet i listan: {numbers[0]}");

// Lägg till ett element i listan
numbers.Add(6);

// Dictionary
Dictionary<string, string> person = new Dictionary<string, string>
{             
    { "name", "Alice"},
    {"city", "Stockholm" }
};

Console.WriteLine($"Personens namn: {person["name"]}");

// Lägg till ett nyckel-värde par
person["job"] = "lärare";
Console.WriteLine($"Personens jobb: {person["job"]}");


// While-loop
int counter = 0;
while (counter <5)
{
    Console.WriteLine($"While loop, iteration {counter}");

    //counter += 1;
    counter++;
}

// For-loop (range)
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"For loop med range, iteration {i}");
}

// Iterera över lista

List<string> fruits = new List<string>{"apple", "banana", "cherry"};

foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

// Iterera över dictionary
foreach (var item in person)
{
    Console.WriteLine(item.Value);
}



// Funktion utan returvärde

// Funktion med returvärde

// Funktion med standardvärden