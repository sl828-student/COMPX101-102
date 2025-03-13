using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circuits
{
    public class OutputLamp : Gate
    {
        private bool isOn;

        protected const int WIDTH = 55;
        protected const int HEIGHT = 55;

        protected const int GAP = 10;

        public OutputLamp(int x, int y) :base(x, y) 
        {
            pins.Add(new Pin(this, true, 20));


            isOn = false;

            MoveTo(x, y);
        }

        public override bool Selected { get => base.Selected; set => base.Selected = value; }

        public override List<Pin> Pins { get { return pins; } }

        public override bool IsMouseOn(int x, int y)
        {
            if (_left <= x && x < _left + WIDTH
               && _top <= y && y < _top + HEIGHT)
                return true;
            else
                return false;
        }

        public override void Draw(Graphics paper)
        {
            foreach (Pin p in Pins)
            {
                p.Draw(paper);
            }
            if (isOn)
            {
                paper.FillEllipse(Brushes.Yellow, _left, _top, WIDTH, HEIGHT);
                paper.DrawLine(Pens.Black, _left, _top, _left+ WIDTH, _top + HEIGHT);
                paper.DrawLine(Pens.Black, _left + WIDTH, _top, _left , _top + HEIGHT);
            }
            else
            {
                paper.FillEllipse(Brushes.DarkGray, _left, _top, WIDTH, HEIGHT);
                paper.DrawLine(Pens.Black, _left, _top, _left + WIDTH, _top + HEIGHT);
                paper.DrawLine(Pens.Black, _left + WIDTH, _top, _left, _top + HEIGHT);
            }
        }
        public override void MoveTo(int x, int y)
        {
            //Debugging message
            Console.WriteLine("pins = " + pins.Count);
            //Set the position of the gate to the values passed in
            _left = x;
            _top = y;
            // must move the pins too
            pins[0].X = x - GAP;
            pins[0].Y = y + HEIGHT / 2;
        }

        public override bool Evaluate()
        {
            if (pins[0].InputWire == null)
            {
                MessageBox.Show("Error: Input pin is not connected.", "Evaluation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isOn = false;
            }
            else
            {
                Gate inputGate = pins[0].InputWire.FromPin.Owner;
                isOn = inputGate.Evaluate();
            }

            return isOn;
        }
        public override Gate Clone()
        {
            // Create a new OutputLamp at the same position
            OutputLamp clone = new OutputLamp(_left, _top);

            // Clone each pin and add it to the clone's pin list
            foreach (Pin pin in pins)
            {
                Pin clonedPin = new Pin(clone, pin.IsInput, pin.X - clone._left);
                clonedPin.X = pin.X;  // Set the X position of the cloned pin
                clonedPin.Y = pin.Y;  // Set the Y position of the cloned pin
                clone.pins.Add(clonedPin);
            }

            // Set the isOn state in the clone to match the original
            clone.isOn = this.isOn;

            // Return the cloned OutputLamp
            return clone;
        }

    }
}
