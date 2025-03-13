using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practest2
{
    /// <summary>
    /// this class creates pedestals 
    /// </summary>
    public class Pedestal : Artworks
    {
        public const int WALL_HEIGHT = 400;
        public string _Colour;
        public int y;
        /// <summary>
        /// initialises the pedestal
        /// </summary>
        /// <param name="x">x postion</param>
        /// <param name="y">y postion</param>
        /// <param name="w">width</param>
        /// <param name="h">height </param>
        /// <param name="colour"></param>
        public Pedestal(int x, int y, int w, int h, string colour) : base(x, y, w, h)
        {
            //this.y = 0;
            this._Colour = colour;
        }
        /// <summary>
        /// Draws the pedestal with a 0 y postion as instructed
        /// </summary>
        /// <param name="wall"></param>
        public override void Display(Graphics wall)
        {
            
            Rectangle newFrame = new Rectangle(_xPos, WALL_HEIGHT - _Height, _Width, _Height);

            if (_Colour == "black")
                wall.FillRectangle(Brushes.Black, newFrame);
            else if (_Colour == "white")
                wall.FillRectangle(Brushes.White, newFrame);
            wall.DrawRectangle(Pens.Black, newFrame);
            wall.DrawEllipse(Pens.Black, _xPos + _Width/4 , WALL_HEIGHT - _Height - _Width / 2 , _Width / 2, _Width/2 );
        }
        /// <summary>
        /// returns the pedestal values as string comma seperated
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Frame.X.ToString() + "," +
                Frame.Y.ToString() + "," +
                Frame.Width.ToString() + "," +
                Frame.Height.ToString() + "," +
                _Colour;

        }
        /// <summary>
        /// Checks if the mouse is on the pedestal
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public override bool IsMouseOn(int x, int y)
        {
            Rectangle newFrame = new Rectangle(_xPos, 0, _Width, _Height);
            Point mousePos = new Point(x, y);
            return newFrame.Contains(mousePos);
        }
        /// <summary>
        /// Updates the pedestal to new values 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        public override void Update(int x, int y, int w, int h)
        {
            Frame = new Rectangle(x, y, w, h);
        }
    }
}
