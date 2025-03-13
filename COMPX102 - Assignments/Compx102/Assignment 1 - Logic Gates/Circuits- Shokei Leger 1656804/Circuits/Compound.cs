using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circuits
{
    /// <summary>
    /// This class implement the compound gate
    /// </summary>
    public class Compound : Gate
    {
        //list of gates to be compounded
        private List<Gate> gates = new List<Gate>();

        /// <summary>
        /// initialises the compound gate
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Compound(int x, int y) : base(x, y) 
        {

        }

        /// <summary>
        /// Adds a gate to the list of gates to be compounded
        /// </summary>
        /// <param name="gate"></param>
        public void AddGate(Gate gate)
        {
            gate.Left += this.Left; 
            gate.Top += this.Top;   
            gates.Add(gate);
        }

        /// <summary>
        /// Moves the compounded gate
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
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

        /// <summary>
        /// Drawss all gates in the gate list
        /// </summary>
        /// <param name="g"></param>
        public override void Draw(Graphics g)
        {
            foreach (var gate in gates)
            {
                gate.Draw(g);
            }
        }

        /// <summary>
        /// Checks if the mouse is on the compound gate
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Checks if the gates is selected 
        /// </summary>
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
        /// <summary>
        /// returns all pins for the compound gate from a list
        /// </summary>
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

        /// <summary>
        /// Evaluates if the wires are correctly connected and "current" flows
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Clones the compound gate and returns the clone
        /// </summary>
        /// <returns></returns>
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
