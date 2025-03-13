using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3___Post_Office
{
    public class Postcard : PostalItem
    {
        public Postcard(string address, string name, int height, int length, bool urgent) : base(address, name, height, length, urgent ) 
        {
            _urgent = true;
        }

        public override decimal Cost()
        {
            decimal cost = 1.4m;

            return cost;
        }
        public bool Ugent()
        {
            return _urgent;
        }
        public override string ToString()
        {
            return "Postcard: ".PadRight(20) + _name + ", ".PadLeft(10) + _address + ", ".PadRight(15) + _height + "mm x    " + _length + "mm, Urgent: " + (_urgent ? "Yes" : "No") + ", Cost: " + Cost().ToString("C");
        }
    }
}
