using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Task3___Post_Office
{
    public abstract class PostalItem
    {
        //feilds
        protected string _address;
        protected string _name;
        protected int _height;
        protected int _length;
        protected bool _urgent;

        private const decimal STAMP_PRICE = 0.7m;

        public PostalItem(string address, string name, int height, int length, bool urgent) 
        {
            _address = address;
            _name = name;
            _height = height;
            _length = length;
            _urgent = urgent;
        }
        public bool Urgent 
        { 
            get { return _urgent; } 
            set { _urgent = value; }
        }

        public override string ToString()
        {
            return _name + ", " + _address + ", " + _height + "mm x " + _length + "mm, Urgent: " + (_urgent ? "Yes" : "No") + ", Cost: " + Cost().ToString("C");
        }

        public abstract decimal Cost();
    }
}
