using MockAssessment3;
using System;

Town testTown = new Town();

int numberOfVillagers = testTown.DisplayVillagerCount();
Console.WriteLine($"Total number of Villagers: {numberOfVillagers}");

Console.WriteLine("\nVillagers in the Town:");
testTown.DisplayVillagers();

int numberOfFarmers = testTown.CountNumberOfFarmers();
Console.WriteLine($"\nTotal number of Farmers: {numberOfFarmers}");

int numberOfSlackers = testTown.CountNumberOfSlackers();
Console.WriteLine($"\nTotal number of Slackers: {numberOfSlackers}");

int testHarvert = testTown.Harvest();
Console.WriteLine($"\nTown Harvest: {testHarvert}"); //Should return 2

int testFoodCalc = testTown.CalcFoodConsumption();
Console.WriteLine($"\nTown Total Food Consumption: {testFoodCalc}"); //Should return 10

bool testSurviveWinter = testTown.SurviveTheWinter();
//Return true if the value from CalcFoodConsumption is less than or equal to Harvest.
//Return false if the value from CalcFoodConsumption is greater than Harvest.
Console.WriteLine($"\nTown Survives Winter: {testSurviveWinter}"); // Harvest is 2, Consumption is 10, should return 'false'