using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{
    class Poolball : MovingBall
    {
        private const int TABLE_WIDTH = 233;
        private const int TABLE_HEIGHT = 117;

        public Poolball(int x, int y, int dx, int dy) : base(x, y, dx, dy)
        {

        }

        public override void Move()
        {
            base.Move();

            // Ensure ball stays within the horizontal bounds of the table
            if (xCoord < 0)
            {
                XSpeed *= -1;
                xCoord = 0; // Reset to left boundary
            }
            else if (xCoord > TABLE_WIDTH - size)
            {
                XSpeed *= -1;
                xCoord = TABLE_WIDTH - size; // Reset to right boundary
            }

            // Ensure ball stays within the vertical bounds of the table
            if (yCoord < 0)
            {
                YSpeed *= -1;
                yCoord = 0; // Reset to top boundary
            }
            else if (yCoord > TABLE_HEIGHT - size)
            {
                YSpeed *= -1;
                yCoord = TABLE_HEIGHT - size; // Reset to bottom boundary
            }
        }
    }
}
