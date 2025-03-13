using System;
using System.IO;

public class program
{
    static void Main()
    {   
        //Stores the filepath for the plants text file
        string filePath = @"H:\COMPX101\Week 8\Gravity Calc\planets.txt";

        //checks the file exists
        if(File.Exists(filePath))
        { 
            using (StreamReader reader = new StreamReader(filePath))
            {
                Console.WriteLine("Enter the path and name of the output file:");
                string outPath = Console.ReadLine();
                StreamWriter writer = new StreamWriter(outPath);

                while (!reader.EndOfStream)
                {
                    string planetName = reader.ReadLine();
                    double mass = double.Parse(reader.ReadLine());
                    double radius = double.Parse(reader.ReadLine());
                    
                    //Calls the method that Calculate the gravity of planets in earth gravity equivalent
                    double gravity = calcGravity(mass, radius);

                    Console.WriteLine($"{planetName} has earth equivalent gravity of: {gravity}\n");
                    writer.WriteLine($"{planetName} has earth equivalent gravity of: {gravity}\n");

                }
                reader.Close();
                writer.Close();
            }
        }
        //Error message if the file does not exist
        else
        {
            Console.WriteLine("File not found.");
        }

    }
    /// <summary>
    /// This method calculates the earth gravity equivalent of the plants
    /// </summary>
    /// <param name="mass"></param>
    /// <param name="radius"></param>
    /// <returns></returns>
    static double calcGravity(double mass, double radius)
    {
        double gravity = mass / (radius * radius);
        return gravity;

    }
}