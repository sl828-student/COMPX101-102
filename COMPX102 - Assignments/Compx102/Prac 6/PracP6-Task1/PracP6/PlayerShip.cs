using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracP6
{
    public class PlayerShip : Sprite 
    {
        //constants fior the ships appearance and size
        private const int WIDTH = 50;
        private const int HEIGHT = 20;
        private const int GUN_HEIGHT = 10;
        private const int SPEED = 5;

        private int _moveDirection = 0;

        private PictureBox pictureBox_;



        //Constructor to create a playership object
        public PlayerShip(int startX, int startY) : base(startX-WIDTH/2, startY, WIDTH, HEIGHT)
        {
          
        }

        //Public Methods:

        public void setDirection(int direction)
        {
            _moveDirection = direction;
        }

        public override void Move()
        {
            X += _moveDirection * SPEED;

            


        }
        

        public override void Draw(Graphics graphics)
        {
            graphics.FillRectangle(Brushes.Green, X, Y, WIDTH, HEIGHT);
            graphics.FillRectangle(Brushes.Green, X + WIDTH/3, Y - HEIGHT/2, 20, GUN_HEIGHT);
            graphics.DrawLine(Pens.Green, X + WIDTH / 2, Y, X + WIDTH / 2, Y - GUN_HEIGHT);
        }
    }
}
