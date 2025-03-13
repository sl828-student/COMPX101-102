using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circuits
{
    /// <summary>
    /// This class implemetns the gate superclass
    /// </summary>
    public abstract class Gate
    {
        //the left position of the gate
        protected int _left;

        //The top of the gate
        protected int _top;

        //List of pins for all gates
        protected List<Pin> pins;

        //Property for whether or not the gate is selected
        public bool selected { get; set; }

        /// <summary>
        /// initialises the gate 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="top"></param>
        public Gate(int left, int top)
        {
            _left = left;
            _top = top;
            this.pins = new List<Pin>();
        }

        /// <summary>
        /// gets and sets if the gate is selected
        /// </summary>
        public virtual bool Selected
        {
            get { return selected; }
            set { selected = value; }
        }

        /// <summary>
        /// Property to get or set the X position (left) of the gate
        /// </summary>        
        public int Left
        {
            get { return _left; }
            set { _left = value; }
        }

        /// <summary>
        /// gets and sets the top value of the gate
        /// </summary>
        public int Top
        {
            get { return _top; }
            set { _top = value; }
        }

        /// <summary>
        /// gets the pins 
        /// </summary>
        public abstract List<Pin> Pins { get; }

        /// <summary>
        /// Abstract method to check if mouse is on
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public abstract bool IsMouseOn(int x, int y);

        /// <summary>
        /// Abstract draw method
        /// </summary>
        /// <param name="paper"></param>
        public abstract void Draw(Graphics paper);

        /// <summary>
        /// abstract move to method
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public abstract void MoveTo(int x, int y);

        /// <summary>
        /// abstract evaluate method
        /// </summary>
        /// <returns></returns>
        public abstract bool Evaluate();

        /// <summary>
        /// abstract clone method
        /// </summary>
        /// <returns></returns>
        public abstract Gate Clone();

    }
}
