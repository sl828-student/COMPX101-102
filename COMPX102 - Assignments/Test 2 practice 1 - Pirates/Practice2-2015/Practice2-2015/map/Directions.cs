using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace map
{
    /// <summary>
    /// Stores a direction (of where to go) on a treasure map
    /// </summary>
    class Direction : Features 
    {
        
        public Point EndLocation;   // location of end point of direction (where to go to)
       
        /// <summary>
        /// Specifies a direction to go on a treasure map
        /// </summary>
        /// <param name="StartX">start x position of direction on map</param>
        /// <param name="startY">start y position of direction on map</param>
        /// <param name="endX">end x position of direction on map</param>
        /// <param name="endY">end y position of direction on map</param>
        /// <param name="size">size of direction (line width & arrowhead size)</param>
        /// <param name="name">description of direction</param>
        public Direction(int startX, int startY, int endX, int endY, int size, string name) : 
            base(startX, startY, size, name)
        {
            EndLocation = new Point(endX, endY);
        }

        /// <summary>
        /// Moves the position of a direction on a treasure map 
        /// </summary>
        /// <param name="startX">new start x position of direction on map</param>
        /// <param name="startY">new start y position of direction on map</param>
        /// <param name="endX">new end x position of direction on map</param>
        /// <param name="endY">new end y position of direction on map</param>
        public void MovePosition(int startX, int startY, int endX, int endY)
        {
            Location = new Point(startX, startY);
            EndLocation = new Point(endX, endY);
        }

        /// <summary>
        /// Checks if a (mouse) position is 'on' this direction
        /// </summary>
        /// <param name="x">x position to check</param>
        /// <param name="y">y position to check</param>
        /// <returns>true if x,y is inside location of direction</returns>
        public override bool IsMouseOn(int x, int y)
        {
            Point mousePos = new Point(x, y);
            
            // This creates an invisible rectangle from the start point to the end point so that we can use Contains
            int left = Math.Min(Location.X, EndLocation.X);
            int top = Math.Min(Location.Y, EndLocation.Y);
            int width = Math.Abs(EndLocation.X - Location.X);
            int height = Math.Abs(EndLocation.Y - Location.Y);
            Rectangle area = new Rectangle(left, top, width, height);
            return area.Contains(mousePos);
        }
        
        /// <summary>
        /// Displays the Direction on the map using an arrow from Location to EndLocation.
        /// </summary>
        /// <param name="paper">Graphics object specifying where to draw image</param>
        public override void Display(Graphics paper)
        {
            Pen mypen = new Pen(Color.Black, _Size);
            mypen.EndCap = LineCap.ArrowAnchor; // draw an arrow at the end of the line
            paper.DrawLine(mypen, Location, EndLocation);

            // Write name of direction
            paper.DrawString(_Name, new Font("Arial", 10), Brushes.Black, Location);
        }
        
        /// <summary>
        /// Returns a string summarising this direction
        /// format is "startX,startY,endX,endY,size,name" i.e. CSV
        /// </summary>
        /// <returns>String describing this direction</returns>
        public override string ToString()
        {
            return  Location.X.ToString() + "," +
                    Location.Y.ToString() + "," +
                    EndLocation.X.ToString() + "," +
                    EndLocation.Y.ToString() + "," +
                    _Size.ToString() + "," + _Name;
        }
    }
}
