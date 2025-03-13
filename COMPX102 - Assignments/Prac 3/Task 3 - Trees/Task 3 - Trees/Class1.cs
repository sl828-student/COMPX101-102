using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3___Trees
{
    public class Tree
    {
        private int xPos;
        private int yPos;
        private int size;
        private const int TrunkWidth = 6;
        private const int TrunkHeight = 80;

        public Tree(int xPos, int yPos, int size)
        {
            this.xPos = xPos;
            this.yPos = yPos;
            if (size < 10)
                this.size = 10;
            else if (size > 30)
                this.size = 30;
            else
                this.size = size;
        }

        public void DrawTree(Graphics g)
        {
            // Draw the trunk
            g.FillRectangle(Brushes.Brown, xPos - TrunkWidth / 2, yPos, TrunkWidth, TrunkHeight);

            // Draw the foliage
            g.FillEllipse(Brushes.Green, xPos - size / 2, yPos - size / 2, size, size);
        }
    }
}
