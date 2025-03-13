using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees_redo
{
    public class Tree
    {
        //datafields 
        protected int _xPos;
        protected int _yPos;
        protected int _size;

        private const int TRUNKWIDTH = 6;
        private const int TRUNKHEIGHT = 80;

        /// <summary>
        /// Constructor initialises and creates a new tree object
        /// </summary>
        /// <param name="xPos">is the x posiotn of the tree</param>
        /// <param name="yPos">is the y position of the tree</param>
        /// <param name="size">is the size of the tree</param>
        public Tree(int xPos, int yPos, int size)
        {
            _xPos = xPos;
            _yPos = yPos;
            if (size < 10)
            {
                size = 10;
            }
            else if (size > 30)
            {
                size = 30;
            }
            else
            { _size = size; }
        }

        public void DrawTree(Graphics graphics)
        {
            //Draw the trunk of the tree
            graphics.FillRectangle(Brushes.Blue, _xPos - TRUNKWIDTH / 2, _yPos, TRUNKWIDTH, TRUNKHEIGHT);

            //Draw the fucking leaves of the tree bruv
            graphics.FillEllipse(Brushes.Red, _xPos -  _size/ 2, _yPos - _size / 2, _size, _size);
        }
    }
}
