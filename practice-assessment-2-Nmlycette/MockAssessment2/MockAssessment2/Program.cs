using MockAssessment2;
using System.Runtime.InteropServices;

string[] planetsArray = new string[] { "1. Mercury", "2. Venus", "3. Earth", "4. Mars", "5. Jupiter", "6. Saturn", "7. Uranus", "8. Neptune" };

string[] starWarsCharactersArray = new string[] { "Luke", "C3PO", "Darth Vader", "Bobba Fett", "Yoda" };

Dictionary<string, int> characterAttacksDictionary = new Dictionary<string, int>()
{
    { "Luke Skycrawler", 1 },
    { "Super Ewok" , 999},
    { "Garth Vader" , 100},
    { "Bobba Fatt", 950 },
    { "Yoda", 100 }
};

// Method 1
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Array of Star Wars Characters:");
Console.ResetColor();

foreach (string character in starWarsCharactersArray)
{
    Console.WriteLine($"{character} ");
}

int yodaIndex = StarWarsClass.AddStarWarsCharacters(starWarsCharactersArray);

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Yoda is in index position: {yodaIndex}");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("\nPress any key to move onto the next method\n");
Console.ResetColor();
Console.ReadKey();
Console.Clear();


//Method 2
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Character names and attack values:");
Console.ResetColor();

foreach (var item in characterAttacksDictionary)
{
    Console.WriteLine($"{item.Key}, {item.Value}");
}
string highestAttackScore = StarWarsClass.DeathStarCombat(characterAttacksDictionary);

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"{highestAttackScore} has the highest attack score");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("\nPress any key to move onto the next method\n");
Console.ResetColor();
Console.ReadKey();
Console.Clear();


//Method 3
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Array of Planets:");
Console.ResetColor();

foreach (string planet in planetsArray)
{
    Console.WriteLine(planet);
}

List<string> planetList = PlanetsClass.ConvertPlanets(planetsArray);

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Planets listed in reverse order:");
Console.ResetColor();

foreach (string planet in planetList)
{
    Console.WriteLine(planet);
}

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("\nPress any key to move onto the next method\n");
Console.ResetColor();
Console.ReadKey();
Console.Clear();


// Method 4
List<int> droidList = new List<int>();
droidList = new List<int>
{
    330, 101, 400, 856, 40, 105, 600
};

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Droid numbers:");
Console.ResetColor();

foreach (int droid in droidList)
{
    Console.WriteLine(droid);
}

double evenDroidAverage = Droids.AverageDroids(droidList);

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"The average of all the droid numbers is: {evenDroidAverage}");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("\nPress any key to move onto the next method\n");
Console.ResetColor();
Console.ReadKey();
Console.Clear();


// Method 5
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Was Vader captured, or did he escape? Enter a number or string of text to find out!");
Console.ResetColor();
string userInput = Console.ReadLine();

string vaderOutcome = StarWarsClass.TryToCatchDarthVader(userInput);

Console.ForegroundColor = ConsoleColor.Red;
Console.Write(vaderOutcome);
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("\nPress any key to end the program\n");
Console.ResetColor();
Console.ReadKey();