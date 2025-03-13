using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace map
{
    /// <summary>
    /// Stores a treasure map.
    /// It contains a list of directions, and a background image
    /// </summary>
    class Map
    {
        public Bitmap Background;

        public List<Features> featuresList;

        /// <summary>
        /// Creates a treasure map.
        /// It contains a list of directions, and a background image
        /// </summary>
        public Map()
        {
            Background = null;
            featuresList = new List<Features>();
        }

        /// <summary>
        /// Adds a direction to the map
        /// </summary>
        /// <param name="landmark">direction to add to the map</param>
        public void AddFeatures(Features landmark)
        {
            featuresList.Add(landmark);
        }

        /// <summary>
        /// Checks if a (mouse) position is 'on' any direction, and returns the direction if it does.
        /// </summary>
        /// <param name="x">x position to check</param>
        /// <param name="y">y position to check</param>
        /// <returns>direction that x,y is 'on'</returns>
        public Features SelectFeature(int x, int y)
        {
            foreach (Features f in featuresList)
            {
                if (f.IsMouseOn(x, y))
                {
                    return f;
                }
            }
            return null;
        }
        
        /// <summary>
        /// Displays the map of directions.
        /// </summary>
        /// <param name="paper">Graphics object specifying where to draw map</param>
        public void Display(Graphics paper)
        {
            paper.Clear(Color.White);

            // Display selected background image
            if (Background != null)
                paper.DrawImage(Background, 0, 0, paper.ClipBounds.Width,paper.ClipBounds.Height);
            // Display each stored direction
            foreach (Features d in featuresList)
            {
                d.Display(paper);
            }
        }

        /// <summary>
        /// Returns a string summarising this map
        /// </summary>
        /// <returns>string describing this map</returns>
        public override string ToString()
        {
            return "Treasure map has " + featuresList.Count.ToString() + " directions stored.";
        }   
    }
}
