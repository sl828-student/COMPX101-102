using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{
    class ColorPoolBall : Poolball
    {
        private Brush brush;

        public ColorPoolBall(int x, int y, int dx, int dy, Color color) : base(x, y, dx, dy)
        {
            brush = new SolidBrush(color);
        }

        public override void Display(Graphics paper)
        {
            paper.FillEllipse(brush, xCoord, yCoord, size, size);
        }
    }
}
