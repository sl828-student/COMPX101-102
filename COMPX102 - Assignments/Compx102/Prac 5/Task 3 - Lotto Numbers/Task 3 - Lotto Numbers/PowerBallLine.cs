using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3___Lotto_Numbers
{
    public class PowerBallLine : LottoLine
    {
        private int powerballNum;

        // Constructor
        public PowerBallLine(string[] csvArray) : base(csvArray)
        {
            powerballNum = int.Parse(csvArray[6]);
        }

        // Override ToString method to include the Powerball number
        public override string ToString()
        {
            return base.ToString() + $"  Powerball: {powerballNum.ToString().PadLeft(2, ' ')}";
        }

        // Check how many winning numbers match, including Powerball
        public int CheckNumbers(int[] winNumsArray, int winPowerball)
        {
            int matchCount = base.CheckNumbers(winNumsArray);
            if (powerballNum == winPowerball)
            {
                matchCount++;
            }
            return matchCount;
        }
    }
}
