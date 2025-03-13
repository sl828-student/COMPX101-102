using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Practest2
{
    /// <summary>
    /// Stores a paintings location and size on the gallery wall
    /// </summary>
    class Painting : Artworks
    {

        /// <summary>
        /// Specifies the location and size of a painting on a gallery wall
        /// </summary>
        /// <param name="x">left position of painting on wall</param>
        /// <param name="y">bottom position of painting on wall from ground</param>
        /// <param name="w">width of painting on wall</param>
        /// <param name="h">height of painting on wall</param>
        public Painting(int x, int y, int w, int h) : base(x, y, w, h)
        {
        }

        /// <summary>
        /// Specifies a new location and size for the painting on a gallery wall
        /// </summary>
        /// <param name="x">left position of painting on wall</param>
        /// <param name="y">bottom position of painting on wall from ground</param>
        /// <param name="w">width of painting on wall</param>
        /// <param name="h">height of painting on wall</param>
        public override void Update(int x, int y, int w, int h)
        {
            Frame = new Rectangle(x, y, w, h);
        }

        /// <summary>
        /// Checks if a (mouse) position is 'on' this painting.
        /// </summary>
        /// <param name="x">x position to check</param>
        /// <param name="y">y position to check</param>
        /// <returns>true if x,y is inside frame (border) of painting</returns>
        public override bool IsMouseOn(int x, int y)
        {
            Rectangle newFrame = new Rectangle(Frame.X, Form1.WALL_HEIGHT - Frame.Y - Frame.Height, Frame.Width, Frame.Height);
            Point mousePos = new Point(x, y);
            return newFrame.Contains(mousePos);
        }
        
        /// <summary>
        /// Displays the painting on the gallery wall using size of frame.
        /// a painting is represented by a rectangle with a smaller rectangle inside representing the frame.
        /// </summary>
        /// <param name="wall">Graphics object specifying where to draw image</param>
        public override void Display(Graphics wall)
        {
            int border = Frame.Width / 10;
            Rectangle newFrame = new Rectangle(Frame.X, Form1.WALL_HEIGHT - Frame.Y - Frame.Height, Frame.Width, Frame.Height);
            wall.DrawRectangle(Pens.Black, newFrame);
            //reduce size of newFrame for inside of frame
            newFrame.X += border;
            newFrame.Y += border;
            newFrame.Width -= 2 * border;
            newFrame.Height -= 2 * border;
            wall.FillRectangle(Brushes.White, newFrame);
            wall.DrawRectangle(Pens.Black, newFrame);
        }
        
        /// <summary>
        /// Returns a string summarising this painting
        /// format is "x,y,w,h" i.e. CSV                      
        /// </summary>
        /// <returns>String describing this painting</returns>
        public override string ToString()
        {
            return Frame.X.ToString()+","+
                Frame.Y.ToString() + "," +
                Frame.Width.ToString() + "," + 
                Frame.Height.ToString(); 
        }
    }
}
