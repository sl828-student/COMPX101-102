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
        protected int _xPos;
        protected int _yPos;
        protected int _size;
        protected const int width = 6;
        protected const int height = 80;

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

        public virtual void DrawTree(Graphics graphics)
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

        public virtual string ToCsvString()
        {
            //return (_xPos.ToString() + ',' + _yPos.ToString() + ',' + _size.ToString());

            return $"Tree,{_xPos},{_yPos},{_size}";
        }

        public void GrowTree(int amount)
        {
            if (_size <= 50)
            {
                _size += amount;
            }
        }
        public override string ToString()
        {
            return $"Tree at position {_xPos}, {_yPos}";
        }
    }
}
