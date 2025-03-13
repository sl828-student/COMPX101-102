using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{
    public class LoveCannon : GameObject
    {
        /// <summary>
        /// The fields
        /// </summary>
        private int _range;
        private int _cannonWidth;
        private int _cannonHeight;
        /// <summary>
        /// Constructror, initialises the variables
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="range"></param>
        public LoveCannon(int x, int y, int range) : base(x, y)
        {
            _range = range;
            _xPos= x;
            _yPos= y;
            _objectColor = Color.Blue;
            _cannonWidth = 50;
            _cannonHeight = 10;
        }
        /// <summary>
        /// Draws the object, is passed in graphics
        /// </summary>
        /// <param name="paper"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void DrawObject(Graphics paper)
        {
            Color baseColor = _objectColor;
            Color selectedColor = _selectedColor;

            paper.FillRectangle(new SolidBrush(baseColor), new Rectangle(_xPos - _cannonWidth / 2, _yPos - _cannonHeight / 2, _cannonWidth, _cannonHeight));
            paper.DrawEllipse(Pens.Black, _xPos - _range / 2, _yPos - _range / 2, _range, _range);

            if (_isSelected == true)
            {
                //if the cannon is selected the cannon is redrawn in the selected color
                paper.FillRectangle(new SolidBrush(selectedColor), new Rectangle(_xPos - _cannonWidth / 2, _yPos - _cannonHeight / 2, _cannonWidth, _cannonHeight));
                //the selected cannon will then have an elipse drawn 
                paper.DrawEllipse(new Pen(selectedColor), _xPos -_range/2, _yPos - _range/2, _range, _range);
            }
        }
        /// <summary>
        /// Method checks if the cannon is clicked by checking that the y and x position of the click is the same as the cannon position
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public override bool IsClicked(int x, int y)
        {
            if (x >= _xPos - _cannonWidth / 2 && x <= _xPos + _cannonWidth / 2
                && y >= _yPos - _cannonHeight / 2 && y <= _yPos + _cannonHeight / 2)
            {
                _isSelected = true;
                return true;
            }
            else
            {
                _isSelected = false;
                return false;
            }
        }
        /// <summary>
        /// upgrades the cannon by increasing the range of the cannon by 10
        /// </summary>
        public void UpgradeCannon()
        {
            _range += 10;

            Console.WriteLine($"Cannon upgraded. New range: {_range}");
        }
    }
}
