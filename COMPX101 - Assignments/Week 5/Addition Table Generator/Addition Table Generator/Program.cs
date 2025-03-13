using System.Globalization;

Console.WriteLine("Welcome to the BEST times table generator!");

//promots user for input
Console.Write("\nPlease enter the number you would like to generate times tables for:");
    int number = Convert.ToInt32(Console.ReadLine());

Console.Write("\nEnter the number of lines for the table:");
    int lines = Convert.ToInt32(Console.ReadLine());

//displays the times tables
Console.WriteLine("\n\nGenerated times tables:\n");
for(int j = 1; j <= lines; j++)
{
    int result = number * j;
    Console.WriteLine($"{number} * {j} = {result}");
}

Console.WriteLine("\n\nPress any key to exit...");
Console.ReadKey();
