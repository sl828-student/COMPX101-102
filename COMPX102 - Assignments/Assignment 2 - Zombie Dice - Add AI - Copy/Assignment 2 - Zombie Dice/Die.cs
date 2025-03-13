using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2___Zombie_Dice
{
    public class Die
    {
        public enum DieColor { Green, Yellow, Red }
        public enum DieResult { Brain, Shotgun, Footprints }

        private static Random random = new Random();
        public DieColor Color { get; private set; }
        /// <summary>
        /// Constructor,inttialises the color of die
        /// </summary>
        /// <param name="color"></param>
        public Die(DieColor color)
        {
            Color = color;
        }
        /// <summary>
        /// Rolls the die to give possible results
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DieResult Roll()
        {
            int roll = random.Next(1, 7); // Simulating a six-sided die
            switch (Color)
            {
                case DieColor.Green:
                    if (roll <= 3) return DieResult.Brain; // 3 sides for Brain
                    if (roll == 4) return DieResult.Shotgun; // 1 side for Shotgun
                    return DieResult.Footprints; // 2 sides for Footprints

                case DieColor.Yellow:
                    if (roll <= 2) return DieResult.Brain; // 2 sides for Brain
                    if (roll <= 4) return DieResult.Shotgun; // 2 sides for Shotgun
                    return DieResult.Footprints; // 2 sides for Footprints

                case DieColor.Red:
                    if (roll == 1) return DieResult.Brain; // 1 side for Brain
                    if (roll <= 4) return DieResult.Shotgun; // 3 sides for Shotgun
                    return DieResult.Footprints; // 2 sides for Footprints

                default:
                    throw new Exception("Unknown die color");
            }
        }
    }
}
