using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circuits
{
    public abstract class Gate
    {
        protected int _left;

        protected int _top;

        protected List<Pin> pins;

        public bool selected { get; set; }

        public Gate(int left, int top)
        {
            _left = left;
            _top = top;
            this.pins = new List<Pin>();
        }

        public virtual bool Selected
        {
            get { return selected; }
            set { selected = value; }
        }

        // Property to get or set the X position (left) of the gate
        public int Left
        {
            get { return _left; }
            set { _left = value; }
        }

        public int Top
        {
            get { return _top; }
            set { _top = value; }
        }
        public abstract List<Pin> Pins { get; }

        

        public abstract bool IsMouseOn(int x, int y);

        public abstract void Draw(Graphics paper);

        public abstract void MoveTo(int x, int y);
        


    }
}
