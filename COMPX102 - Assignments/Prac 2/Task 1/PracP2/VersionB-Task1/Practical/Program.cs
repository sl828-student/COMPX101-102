using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{
    class Program
    {
        static void Main(string[] args)
        {
            int numChars = 5;
            string c = "*";
            try
            {
                Console.WriteLine("Please enter the number of characters");
                numChars = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the characters to draw");
                c = Console.ReadLine();
                DrawChars(numChars, c);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"There is an error: " + ex.Message);
            }
            // Wait for user to have read the output
            Console.WriteLine();
            Console.Write("<Press enter to finish>");
            Console.ReadLine();
        }

        /// <summary>
        /// Draws a line of characters
        /// </summary>
        /// <param name="n">Number of characters to draw</param>
        /// <param name="s">Character to draw n times</param>
        static void DrawChars(int numChars, string c)
        {
            for (int i = 1; i <= numChars; i++)
            {
                // Construct the line with the current line number
                string line = new string(c[0], numChars);
                line = line.Remove(i - 1, 1).Insert(i - 1, i.ToString());

                // Output the constructed line
                Console.WriteLine(line);
            }
        }
    }
}
