using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Practest2
{
    /// <summary>
    /// this artworks class is the superclass 
    /// </summary>
    abstract public class Artworks
    {
        //public properties
        public Rectangle Frame;
        public int _xPos;
        public int _yPos;
        public int _Width;
        public int _Height;

        /// <summary>
        /// initialises the artwork
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        public Artworks(int x, int y, int w, int h)
        {
            _xPos = x;
            _yPos = y;
            _Width = w;
            _Height = h;

            Frame = new Rectangle(x, y, w, h);
        }

        /// <summary>
        /// abstract display method passed a graphics 
        /// </summary>
        /// <param name="wall"></param>
        public abstract void Display(Graphics wall);

        /// <summary>
        /// abstract is mouse on method passed x and y postion 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public abstract bool IsMouseOn(int x, int y);

        /// <summary>
        /// abstract update method passes the dimensions of the artwork
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        public abstract void Update(int x, int y, int w, int h);
    }
}
