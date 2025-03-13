using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3___Trees
{
    public class Tree
    {
        private int _xPos;
        private int _yPos;
        private int _size;
        private const int width = 6;
        private const int height = 80;

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
            _size = size;
        }

        public void DrawTree(Graphics graphics)
        {
            SolidBrush tr = new SolidBrush(Color.Brown);
            SolidBrush fo = new SolidBrush(Color.Green);
            Pen p1 = new Pen(Color.Brown, 2);
            Pen p2 = new Pen(Color.Green, 2);


            graphics.DrawRectangle(p1, _xPos - width / 2, _yPos, width, height);
            graphics.FillRectangle(tr, _xPos - width / 2, _yPos, width, height);


            graphics.DrawEllipse(p2, _xPos - (_size / 2), _yPos - (_size / 2), _size, _size);
            graphics.FillEllipse(fo, _xPos - (_size / 2), _yPos - (_size / 2), _size, _size);

        }

        public string ToCsvString()
        {
            return (_xPos.ToString() + ',' + _yPos.ToString() + ',' + _size.ToString());
        }

        public void GrowTree(int amount)
        {
            if (_size <= 50)
            {
                _size += amount;
            }
        }



    }
}
