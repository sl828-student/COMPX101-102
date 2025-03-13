using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3___Trees
{
    public class Shrub : Tree
    {
        public Shrub(int xPos, int yPos, int size) : base(xPos, yPos, size)
        {
        }

        public override void DrawTree(Graphics graphics)
        {
            SolidBrush brush = new SolidBrush(Color.Brown);
            Pen pen = new Pen(Color.DarkGreen, 2);

            graphics.DrawEllipse(pen, _xPos - (_size / 2), _yPos - (_size / 2), _size, _size);
            graphics.FillEllipse(brush, _xPos - (_size / 2), _yPos - (_size / 2), _size, _size);
        }

        public override string ToString()
        {
            return $"Shrub at position {_xPos}, {_yPos}";
        }

        public override string ToCsvString()
        {
            return $"Shrub,{_xPos},{_yPos},{_size}";
        }
    }
}
