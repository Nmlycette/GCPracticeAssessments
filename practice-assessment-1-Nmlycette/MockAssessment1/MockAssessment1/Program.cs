bool IsTheSame(int num1, int num2)
{
    if (num1 == num2)
    {
        return true;
    }
    else
    {
        return false;
    }
}

double Subtract(double double1, double double2)
{
    return double1 - double2;
}

string FindBuildingType(int thing)
{
    if (thing >= 4 && thing <= 10)
    {
        string buildType = ("Your number is between 4 and 10 - this is an office building!");
        return buildType;

    }
    else if (thing > 50)
    {
        string buildType = ("Your number is greater than 50 - this is a SUPER skycraper!");
        return buildType;
    }
    else if (thing >= 11 && thing <= 49)
    {
        string buildType = ("Your number is between 11 and 49 - this is a skycraper!");
        return buildType;
    }
    else if (thing < 3)
    {
        string buildType = ("Your number is less than 3 - this is a house!");
        return buildType;
    }
    else
    {
        string buildType = ("I have no idea what this building is.");
        return buildType;
    }
}

void Menu()
{
    bool isValidInput = false;  // establishing variable before its used in do-while loop

    int menuSelect;
    int num1;
    int num2;
    double double1;
    double double2;
    int thing;

    Console.WriteLine("-------- MENU ---------");
    Console.WriteLine("Please input the number of the method you'd like to run:\n");

    Console.WriteLine("1. IsTheSame");
    Console.WriteLine("2. Subract");
    Console.WriteLine("3. FindBuildingType");
    Console.WriteLine("4. Exit program");
    Console.WriteLine("-----------------------");

    do // validation - checking to see if user input an integer
    {
        isValidInput = int.TryParse(Console.ReadLine(), out menuSelect);
        if (isValidInput == false)
        {
            Console.Clear();
            Console.WriteLine("Invalid input. Please enter a valid number option.");
        }
    }
    while (isValidInput == false);

    Console.Clear();

    switch (menuSelect)
    {
        case 1:

            Console.WriteLine($"\nYou've selected the 'IsTheSame' method.");
            Console.WriteLine("This method determines if two whole numbers are the same.");

            do // validation - checking to see if user input an integer
            {
                Console.WriteLine("Enter the first number: ");

                isValidInput = int.TryParse(Console.ReadLine(), out num1);
                if (isValidInput == false)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
            while (isValidInput == false);

            do // validation - checking to see if user input an integer
            {
                Console.WriteLine("Enter the second number: ");

                isValidInput = int.TryParse(Console.ReadLine(), out num2);
                if (isValidInput == false)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
            while (isValidInput == false);

            bool method1Return = IsTheSame(num1, num2);
            Console.WriteLine($"Are {num1} and {num2} the same?: {method1Return}\n");
            Menu();
            break;

        case 2:
            Console.WriteLine($"\nYou've selected the 'Subtract' method.");
            Console.WriteLine("This method subtracts one number from another number.");

            do // validation - checking to see if user input a double
            {
                Console.WriteLine("Enter a number: ");
                isValidInput = double.TryParse(Console.ReadLine(), out double1);
                if (isValidInput == false)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
            while (isValidInput == false);

            do // validation - checking to see if user input a double
            {
                Console.WriteLine($"Enter a number to subtract from {double1}: ");
                isValidInput = double.TryParse(Console.ReadLine(), out double2);
                if (isValidInput == false)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please enter a valid number option.");
                }
            }
            while (isValidInput == false);

            double method2Return = Subtract(double1, double2);
            Console.WriteLine($"{double1} - {double2} = {method2Return}\n");
            Menu();
            break;

        case 3:
            Console.WriteLine($"\nYou've selected the 'FindBuildingType' method.");
            Console.WriteLine("This method matches a number to a building type");

            do // validation - checking to see if user input a double
            {
                Console.WriteLine("Enter a number: ");
                isValidInput = int.TryParse(Console.ReadLine(), out thing);
                if (isValidInput == false)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
            while (isValidInput == false);

            string method3Return = FindBuildingType(thing);
            Console.WriteLine($"{method3Return}\n");
            Menu();
            break;

        case 4:
            Console.WriteLine("\nYou've chosen to exit the program. Goodbye!");
            Environment.Exit(0);
            break;

        default: // fallback if user doesn't select any of the 1-4 menu options
            Console.Clear();
            Console.WriteLine("Invalid option. Please input the number of the method you'd like to run.");
            break;
    }
}
Menu();
