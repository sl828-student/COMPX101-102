using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{
    public abstract class GameObject
    {
        //Feilds
        protected int _xPos;
        protected int _yPos;
        protected bool _isSelected;
        protected Color _objectColor;
        protected Color _selectedColor;
        /// <summary>
        /// Cosntructor, initialises the variables and will create the objects
        /// </summary>
        /// <param name="xPos">the x position of the object</param>
        /// <param name="yPos">the y position of the object</param>
        public GameObject(int xPos, int yPos)
        {
            _xPos = xPos;
            _yPos = yPos;
            _isSelected = false;
            _selectedColor = Color.Red;
        }

        /// <summary>
        /// Abstract method to draw the object
        /// </summary>
        /// <param name="paper">the graphics passed into the method</param>
        public abstract void DrawObject(Graphics paper);

        /// <summary>
        /// abstract method to determine whether an object is clicked
        /// </summary>
        /// <param name="x">x position of the clicked object</param>
        /// <param name="y">y position of the clicked object</param>
        /// <returns></returns>
        public abstract bool IsClicked(int x, int y);

        /// <summary>
        /// Method to deselect the object
        /// </summary>
        /// <returns></returns>
        public bool DeselectObject()
        { return _isSelected = false; }

        /// <summary>
        /// Move the object to new position
        /// </summary>
        /// <param name="x">new x position of object</param>
        /// <param name="y">new y postion of object</param>
        public void MoveObject(int x, int y)
        {
            if(_isSelected == true)
            {
                _xPos= x;
                _yPos= y;
            }
        }
    }

}
