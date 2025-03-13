using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task3___Post_Office
{
    public class Letter : PostalItem
    {
        public Letter(string address, string name, int height, int length, bool urgent) 
            : base(address, name, height, length, urgent)
        {
    
        }
        public override decimal Cost()
        {
            decimal cost = 0;

            if (_height <= 130 && _length <=235)
            {
                cost = 0.7m;
            }
            else if(_height <= 165 && _length <=235)
            {
                cost = 1.4m;
            }
            else if(_height <= 230 && _length <= 325)
            {
                cost = 2.1m;
            }
            else
            {
                cost = 2.8m;
            }

            if(_urgent == true)
            { 
                cost += 0.7m;
            }
            return cost;
        }

        public override string ToString()
        {
            return "Letter: ".PadRight(20) + _name + ", ".PadLeft(10) + _address + ", ".PadRight(15) + _height + "mm x " + _length + "mm, Urgent: " + (_urgent ? "Yes" : "No") + ", Cost: " + Cost().ToString("C");
        }
    }
}
