// See https://aka.ms/new-console-template for more information
using System.Data.Common;

Console.WriteLine("Hello, Welcome to the _***_ pattern drawing app");

//Prompts user for input
Console.WriteLine("\nPlease enter the number of rows you would like the pattern generated for:");
    int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nPlease enter the number of columns you would like the pattern generated for:");
    int columns = Convert.ToInt32(Console.ReadLine());

if (rows < 1 || columns < 1)
{ 
    Console.WriteLine("Please enter a valid number");
    return; 
}
else 
{
    for (int row = 0; row < rows; row++)
    { for (int col = 0; col < columns; col++)
        {
            if (col == 0 || col == columns - 1)
            {
                Console.Write("_");
            }
            else 
            {
                Console.Write("*");
            }
        }
        Console.WriteLine();    
    }
}
Console.WriteLine("\n\nPress any key to exit...");
Console.ReadKey();



