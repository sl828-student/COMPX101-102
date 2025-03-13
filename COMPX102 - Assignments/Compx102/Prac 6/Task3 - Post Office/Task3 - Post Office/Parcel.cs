using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3___Post_Office
{
    public class Parcel : PostalItem
    {
        private int _thickness;
        private int _weight;

        public Parcel(string address, string name, int height, int length, bool urgent, int thickness, int weight) 
            : base(address, name, height, length, urgent)
        {
            _thickness = thickness;
            _weight = weight;
        }

        public override decimal Cost()
        {
            decimal cost = 0;
             if(_height * _length * _thickness <= 200000)
            {
                cost = 1.4m * _weight;
            }
             else if (_height * _length * _thickness <= 300000)
            {
                cost = 2.1m * _weight;
            }
            else if (_height * _length * _thickness <= 600000)
            {
                cost = 2.8m * _weight;
            }
             else
            {
                cost = 3.5m * _weight;
            }

             if(_urgent == true)
            {
                cost += 0.7m;
            }
             return cost;
        }

        public override string ToString()
        {
            return "Parcel: ".PadRight(20) + _name + ", ".PadLeft(10) + _address + ", ".PadRight(15) + _height + "mm x " + _length + "mm x " + _thickness + "mm, Weight: " + _weight + "g, Urgent: " + (_urgent ? "Yes" : "No") + ", Cost: " + Cost().ToString("C");
        }
    }
}
