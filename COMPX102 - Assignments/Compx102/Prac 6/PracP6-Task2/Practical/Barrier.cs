using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{
    public class Barrier : GameObject
    {
        //fields
        private const int BARRIER_HEIGHT = 60;
        private const int BARRIER_WIDTH = 20;

        /// <summary>
        /// constructor, initlaises variables 
        /// </summary>
        public Barrier (int x, int y) : base(x, y)
        {
            _xPos = x;
            _yPos = y;
            _objectColor = Color.SaddleBrown;
        }
        /// <summary>
        /// Checks if the object is selected, if it is draws brown barrier, else red barrier
        /// </summary>
        /// <param name="paper"></param>
        public override void DrawObject(Graphics paper)
        {
            Color selectedColor = _selectedColor;
            Color baseColor = _objectColor;

            if (_isSelected == true)
            {  
                paper.FillRectangle(new SolidBrush(selectedColor), new Rectangle(_xPos - BARRIER_WIDTH / 2, _yPos - BARRIER_HEIGHT / 2, BARRIER_WIDTH, BARRIER_HEIGHT));
            }
            else
            {
                paper.FillRectangle(new SolidBrush(baseColor), new Rectangle(_xPos - BARRIER_WIDTH / 2, _yPos - BARRIER_HEIGHT / 2, BARRIER_WIDTH, BARRIER_HEIGHT));
            }
        }
        /// <summary>
        /// Checks whether or not the barrier is clicked
        /// </summary>
        /// <param name="x">x postion of the clicked barrier</param>
        /// <param name="y">y position of the clicked barrier</param>
        /// <returns></returns>
        public override bool IsClicked(int x, int y)
        {
            if (x >= _xPos - BARRIER_WIDTH / 2 && x <= _xPos + BARRIER_WIDTH / 2
                && y >= _yPos - BARRIER_HEIGHT / 2 && y <= _yPos + BARRIER_HEIGHT / 2)
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


    }
}
