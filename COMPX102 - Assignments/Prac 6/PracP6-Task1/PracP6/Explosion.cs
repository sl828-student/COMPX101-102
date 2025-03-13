using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracP6
{
    public class Explosion : Sprite
    {

        private int radius_;

        private int lifeSpan_ = 15; // Controls how long the explosion lasts

        public bool IsExpired => lifeSpan_ <= 0;
        public Explosion(int x, int y) : base(x, y, 30, 30)
        {
            radius_ = 30;
        }

        public override void Move()
        {
            //radius_ -= 2;
            //if (radius_ <= 0)
            //{
            //    // Remove the explosion from the sprite list
            //}
            radius_ -= 2;
            lifeSpan_--;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillEllipse(Brushes.Red, X - radius_ / 2, Y - radius_ / 2, radius_, radius_);
        }
    }
}
