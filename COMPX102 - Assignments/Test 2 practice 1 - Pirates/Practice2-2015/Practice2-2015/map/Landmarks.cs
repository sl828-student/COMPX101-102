using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace map
{
    class Landmarks : Features
    {
        public Landmarks(int startX, int startY, int size, string name): base(startX, startY, size, name)
        {

        }

        public override void Display(Graphics paper)
        {
            SolidBrush br = new SolidBrush(Color.Red );
            paper.FillRectangle(br, Location.X, Location.Y, _Size, _Size);
        }

        public override string ToString()
        {
            return Location.X.ToString() + "," +
                    Location.Y.ToString() + "," +
                    _Size.ToString() + "," + _Name;
        }

        public override bool IsMouseOn(int x, int y)
        {
            Point mousePos = new Point(x, y);

            // This creates an invisible rectangle from the start point to the end point so that we can use Contains
            Rectangle area = new Rectangle(Location.X, Location.Y, _Size, _Size);
            return area.Contains(mousePos);
        }

        public void MovePosition(int startX, int startY)
        {
            Location = new Point(startX, startY);
        }
    }
}
