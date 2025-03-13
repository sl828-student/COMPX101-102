using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace map
{
    public abstract class Features
    {
        public Point Location;
        public int _Size;
        public string _Name;
        
        public Features(int startX, int startY, int size, string name)
        {
            Location = new Point(startX, startY);
            
            _Size = size;
            _Name = name;
        }

        public abstract void Display(Graphics paper);

        public abstract bool IsMouseOn(int x, int y);
    }
}
