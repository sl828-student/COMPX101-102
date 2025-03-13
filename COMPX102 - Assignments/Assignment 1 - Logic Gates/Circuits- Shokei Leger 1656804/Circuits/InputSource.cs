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
    /// this class implements an input source with one output
    /// </summary>
    public class InputSource : Gate
    {
        //the voltage of the input source
        private bool isHighVoltage;

        //With and height of the input source
        protected const int WIDTH = 55;
        protected const int HEIGHT = 50; 
        
        protected const int GAP = 10;

        /// <summary>
        /// iniitialises the input source 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public InputSource(int x, int y) : base(x, y)
        {
            pins.Add(new Pin(this, false, 20));

            MoveTo(x, y);
        }

        /// <summary>
        /// returns selected and sets selected as well as toggles whether the lamp is currently high voltage
        /// </summary>
        public override bool Selected 
        {
            get { return selected; }
            set {
                selected = value;
                if (value) // Toggle the state when selected
                {
                    isHighVoltage = !isHighVoltage;

                
                }
            }
        }

        /// <summary>
        /// Gets the pins from the pins list
        /// </summary>
        public override List<Pin> Pins { get { return pins; } }

        /// <summary>
        /// Method checks if the mouse position is on the output source 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public override bool IsMouseOn(int x, int y)
        {
            if (_left <= x && x < _left + WIDTH
               && _top <= y && y < _top + HEIGHT)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Draw method draws the lamp either on or off
        /// </summary>
        /// <param name="paper"></param>
        public override void Draw(Graphics paper)
        {
            foreach(Pin p in Pins)
            {
                p.Draw(paper);
            }

            // box
            paper.FillRectangle(selected ? Brushes.Red : Brushes.Black, _left - 3, _top - 3, WIDTH + 6, HEIGHT + 6);
            paper.FillRectangle(isHighVoltage ? Brushes.GreenYellow : Brushes.DarkGray, _left, _top, WIDTH, HEIGHT);

            // cross
            paper.DrawLine(Pens.Black, _left, _top + HEIGHT / 2, _left + WIDTH, _top + HEIGHT / 2);
            paper.DrawLine(Pens.Black, _left + WIDTH / 2, _top, _left + WIDTH / 2, _top + HEIGHT);

        }

        

        public override void MoveTo(int x, int y)
        {
            //Debugging message
            Console.WriteLine("pins = " + pins.Count);
            //Set the position of the gate to the values passed in
            _left = x;
            _top = y;
            // must move the pins too
            //pins[0].X = x - GAP;
            //pins[0].Y = y + GAP;
            ////pins[1].X = x - GAP;
            //pins[1].Y = y + HEIGHT - GAP;
            pins[0].X = x + WIDTH + GAP;
            pins[0].Y = y + HEIGHT / 2;
        }

        /// <summary>
        /// returns if the voltage is high
        /// </summary>
        /// <returns></returns>
        public override bool Evaluate()
        {
            return isHighVoltage;
        }

        /// <summary>
        /// Method clones the gate 
        /// </summary>
        /// <returns></returns>
        public override Gate Clone()
        {
            // Create a new InputSource at the same position
            InputSource clone = new InputSource(_left, _top);

            // Clone each pin and add it to the clone's pin list
            foreach (Pin pin in pins)
            {
                Pin clonedPin = new Pin(clone, pin.IsInput, 20);
                clonedPin.X = pin.X;  // Set the X position of the cloned pin
                clonedPin.Y = pin.Y;  // Set the Y position of the cloned pin
                clone.pins.Add(clonedPin);
            }

            // Clone the state of isHighVoltage
            clone.isHighVoltage = this.isHighVoltage;

            // Return the cloned InputSource
            return clone;
        }
    }
}
