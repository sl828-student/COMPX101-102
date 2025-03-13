using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3___Lotto_Numbers
{
    public class LottoLine
    {
        private int[] numbersArray;

        // Constructor
        public LottoLine(string[] csvArray)
        {
            numbersArray = new int[6];
            for (int i = 0; i < 6; i++)
            {
                numbersArray[i] = int.Parse(csvArray[i]);
            }
        }

        // Override ToString method to return the lotto numbers as a string
        public override string ToString()
        {
            return string.Join(" ", numbersArray.Select(num => num.ToString().PadLeft(2, ' ')));
        }

        // Check how many winning numbers match
        public int CheckNumbers(int[] winNumsArray)
        {
            return numbersArray.Count(num => winNumsArray.Contains(num));
        }
    }
}
