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
    /// This class implements an AND gate with two inputs
    /// and one output.
    /// </summary>
    public class AndGate : Gate
    {
        // width and height of the main part of the gate
        protected const int WIDTH = 60;
        protected const int HEIGHT = 50;
        // length of the connector legs sticking out left and right
        protected const int GAP = 10;

        /// <summary>
        /// Initialises the Gate.
        /// </summary>
        /// <param name="x">The x position of the gate</param>
        /// <param name="y">The y position of the gate</param>
        public AndGate(int x, int y) : base(x,y)
        {
            //Add the two input pins to the gate
            pins.Add(new Pin(this, true, 20));
            pins.Add(new Pin(this, true, 20));
            //Add the output pin to the gate
            pins.Add(new Pin(this, false, 20));
            //move the gate and the pins to the position passed in
            MoveTo(x, y);
        }

        /// <summary>
        /// Gets and sets whether the fate is selected or not.
        /// </summary>
        public override bool Selected
        {
            get { return selected; }
            set { selected = value; }
        }

        /// <summary>
        /// Gets the list of pins for the gate.
        /// </summary>
        public override List<Pin> Pins
        {
            get { return pins; }
        }

        /// <summary>
        /// Checks if the gate has been clicked on.
        /// </summary>
        /// <param name="x">The x position of the mouse click</param>
        /// <param name="y">The y position of the mouse click</param>
        /// <returns>True if the mouse click position is inside the gate</returns>
        public override bool IsMouseOn(int x, int y)
        {
            if (_left <= x && x < _left + WIDTH
                && _top <= y && y < _top + HEIGHT)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Draws the gate in the normal colour or in the selected colour.
        /// </summary>
        /// <param name="paper"></param>
        public override void Draw(Graphics paper)
        {
            
            //Draw each of the pins
            foreach (Pin p in pins)
                p.Draw(paper);
            
            //Check if the gate has been selected
            if (selected)
            {
                //Draws gate as selected i.e red
                paper.DrawImage(Properties.Resources.AndGateRed, Left, Top);
            }
            else
            {
                //draws gate as not selected i.e normal
                paper.DrawImage(Properties.Resources.AndGate, Left, Top);
            }
            

            // AND is simple, so we can use a circle plus a rectange.
            // An alternative would be to use a bitmap.
            //paper.FillEllipse(brush, left, top, WIDTH, HEIGHT);
            //paper.FillRectangle(brush, left, top, WIDTH / 2, HEIGHT);

            //Note: You can also use the images that have been imported into the project if you wish,
            //      using the code below.  You will need to space the pins out a bit more in the constructor.
            //      There are provided images for the other gates and selected versions of the gates as well.
            //paper.DrawImage(Properties.Resources.AndGate, Left, Top);


        }

        /// <summary>
        /// Moves the gate to the position specified.
        /// </summary>
        /// <param name="x">The x position to move the gate to</param>
        /// <param name="y">The y position to move the gate to</param>
        public override void MoveTo(int x, int y)
        {
            //Debugging message
            Console.WriteLine("pins = " + pins.Count);
            //Set the position of the gate to the values passed in
            _left = x;
            _top = y;
            // must move the pins too
            pins[0].X = x - GAP;
            pins[0].Y = y + GAP;
            pins[1].X = x - GAP;
            pins[1].Y = y + HEIGHT - GAP;
            pins[2].X = x + WIDTH + GAP;
            pins[2].Y = y + HEIGHT / 2;
        }

        /// <summary>
        /// Checks whether pins are connected to the andgate
        /// </summary>
        /// <returns></returns>
        public override bool Evaluate()
        {
            //checks if either pin is not connectd
            if (pins[0].InputWire == null || pins[1].InputWire == null)
            {
                MessageBox.Show("Error: One or more input pins are not connected.", "Evaluation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            Gate gateA = pins[0].InputWire.FromPin.Owner;
            Gate gateB = pins[1].InputWire.FromPin.Owner;

            return gateA.Evaluate() && gateB.Evaluate();
        }

        /// <summary>
        /// Method clones the and gate
        /// </summary>
        /// <returns></returns>
        public override Gate Clone()
        {
            // Creates a new AndGate at same place
            AndGate clone = new AndGate(_left, _top);

            // Clone each pin put it into the pin list
            foreach (Pin pin in pins)
            {
                Pin clonedPin = new Pin(clone, pin.IsInput, 20);
                clonedPin.X = pin.X;  // Set the X position of the cloned pin
                clonedPin.Y = pin.Y;  // Set the Y position of the cloned pin
                clone.pins.Add(clonedPin);
            }

            // Return the cloned AndGate
            return clone;
        }
    }
}
