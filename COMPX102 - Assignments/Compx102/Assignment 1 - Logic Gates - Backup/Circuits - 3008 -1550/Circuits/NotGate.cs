using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circuits
{
    public class NotGate : Gate
    {
        //width anbd height of the main part of the gate
         protected const int WIDTH = 55;
         protected const int HEIGHT = 50;
        // length of the connector legs sticking out of the left and right
         protected const int GAP = 10;

        /// <summary>
        /// Initialises the not gate
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public NotGate(int x, int y) : base(x, y)
        {
            pins.Add(new Pin(this, true, 20));
            

            pins.Add(new Pin(this, false, 20));

            MoveTo(x, y);
        }

        /// <summary>
        /// gets and sets whether the gate is selected or not
        /// </summary>
        public override bool Selected 
        { 
            get { return selected; }
            set { selected = value; }
        }

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

            //Draw each of the pins
            foreach (Pin p in pins)
                p.Draw(paper);

            //Check if the gate has been selected
            if (selected)
            {
                //Draws gate as selected i.e red
                paper.DrawImage(Properties.Resources.NotGateRed, Left, Top);
            }
            else
            {
                //draws gate as not selected i.e normal
                paper.DrawImage(Properties.Resources.NotGate, Left, Top);
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
            pins[0].Y = y + HEIGHT/2;
            //pins[1].X = x - GAP;
            //pins[1].Y = y + HEIGHT - GAP;
            pins[1].X = x + WIDTH + GAP;
            pins[1].Y = y + HEIGHT / 2;
        }

    }
}
