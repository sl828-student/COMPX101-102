using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Practest2
{
    /// <summary>
    /// Stores a design for a wall of a gallery.
    /// It contains a list of paintings and their positions, and a background colour
    /// </summary>
    class Wall
    {
        public Color BackgroundColour;

        public List<Artworks> artworks;

        /// <summary>
        /// Creates a wall of a gallery.
        /// It contains a list of paintings and their positions, and a background colour
        /// </summary>
        public Wall()
        {
            BackgroundColour = Color.White;
            artworks = new List<Artworks>();
        }

        /// <summary>
        /// Adds a artwork to the gallery wall
        /// </summary>
        /// <param name="painting">painting to add to the wall</param>
        public void AddArtwork(Artworks artwork)
        {
            artworks.Add(artwork);
        }

        /// <summary>
        /// adds painting to gallery wall
        /// </summary>
        /// <param name="painting"></param>
        public void AddPainting(Painting painting)
        {
            artworks.Add(painting);
        }

        /// <summary>
        /// Checks if a (mouse) position is 'on' any paintings, and returns the painting if it does.
        /// </summary>
        /// <param name="x">x position to check</param>
        /// <param name="y">y position to check</param>
        /// <returns>painting that x,y is 'on'</returns>
        public Artworks SelectArtwork(int x, int y)
        {
            foreach (Artworks a in artworks)
            {
                if (a.IsMouseOn(x, y))
                {
                    return a;
                }
            }
            return null;
        }
        
        /// <summary>
        /// Displays the gallery wall with any paintings on it.
        /// </summary>
        /// <param name="wall">Graphics object specifying where to draw image</param>
        public void Display(Graphics wall)
        {
            wall.Clear(BackgroundColour);
            foreach (Artworks a in artworks)
            {
                a.Display(wall);
            }
        }

        /// <summary>
        /// Returns a string summarising this wall
        /// </summary>
        /// <returns>String describing this wall</returns>
        public override string ToString()
        {
            return "Wall has " + artworks.Count.ToString() + " paintings.";
        }
    }
}
