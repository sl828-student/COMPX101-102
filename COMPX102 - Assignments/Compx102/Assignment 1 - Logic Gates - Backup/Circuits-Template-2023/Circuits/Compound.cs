using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circuits
{
    public class Compound : Gate
    {
        private List<Gate> gates = new List<Gate>();

        public Compound(int x, int y) : base(x, y) 
        {

        }

        public void AddGate(Gate gate)
        {
            gate.Left += this.Left; 
            gate.Top += this.Top;   
            gates.Add(gate);
        }

        public override void MoveTo(int x, int y)
        {
            int deltaX = x - this.Left;
            int deltaY = y - this.Top;
            this.Left = x;
            this.Top = y;

            foreach (var gate in gates)
            {
                gate.MoveTo(gate.Left + deltaX, gate.Top + deltaY);
            }
        }

        public override void Draw(Graphics g)
        {
            foreach (var gate in gates)
            {
                gate.Draw(g);
            }
        }

        public override bool IsMouseOn(int x, int y)
        {
            foreach (var gate in gates)
            {
                if (gate.IsMouseOn(x, y))
                {
                    return true;
                }
            }
            return false;
        }


        public override bool Selected 
        {
             get
            {
                return gates.All(gate => gate.Selected);
            }
            set
            {
                foreach(var gate in gates)
                {
                    gate.Selected = value;
                }
            }
        }
        public override List<Pin> Pins
        {
            get
            {
                // Combine the pins of all gates in the compound
                List<Pin> allPins = new List<Pin>();
                foreach (var gate in gates)
                {
                    allPins.AddRange(gate.Pins);
                }
                return allPins;
            }
        }

        public override bool Evaluate()
        {
            // Evaluate all gates in the compound
            bool result = true;
            foreach (var gate in gates)
            {
                result &= gate.Evaluate();
            }
            return result;
        }

        public override Gate Clone()
        {
            // Create a new compound gate at the same position
            Compound clone = new Compound(this.Left, this.Top);

            // Create a list to keep track of cloned gates
            List<Gate> clonedGates = new List<Gate>();

            // Clone each gate and add it to the new compound gate
            foreach (var gate in gates)
            {
                Gate gateClone = gate.Clone();
                clone.AddGate(gateClone);
                clonedGates.Add(gateClone);
            }
            return clone;
        }
    }
}
