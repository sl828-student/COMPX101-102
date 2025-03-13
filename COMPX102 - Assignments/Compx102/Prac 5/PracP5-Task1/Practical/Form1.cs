using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical
{
    public partial class Form1 : Form
    {
        // The number of balls to display
        private const int NUM_BALLS = 16;

        // List to hold the balls
        private List<Ball> balls = new List<Ball>();

        // Random object
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        /// <summary>
        /// Initialize the ball list and start the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGo_Click(object sender, EventArgs e)
        {
            balls = new List<Ball>();

            //generate balls in random positions, at random speeds
            //while loop since we don't want to generate two balls that overlap
            int i = 0;
            while (i < NUM_BALLS)
            {
                Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                ColorPoolBall newBall = new ColorPoolBall(random.Next(233), random.Next(117), random.Next(7) - 3, random.Next(7) - 3, randomColor);

                // Check if overlaps any existing balls
                if (!CheckOverlaps(newBall))
                {
                    balls.Add(newBall);
                    i++;
                }

            }

            //start timer for movement
            timerTime.Enabled = true;
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            Graphics paper = pictureBoxTable.CreateGraphics();
            pictureBoxTable.Refresh();


            // Update position of each ball
            foreach (MovingBall b in balls)
            {
                //move the ball
                b.Move();

                //check if ball is colliding to change their direction
                CheckCollisions(b);

                // draw the ball
                b.Display(paper);
            }
        }

        private void CheckCollisions(MovingBall ball)
        {
            // Make list of balls to check collisions against
            List<MovingBall> collisionList = new List<MovingBall>();
            foreach (MovingBall b in balls)
            {
                collisionList.Add(b);
            }

            // Remove ball as we don't need to see if ball collides with itself
            collisionList.Remove(ball);

            // Check for collision with every other ball
            foreach (MovingBall b2 in collisionList)
            {
                if (ball.CollidesWith(b2))
                {
                    ball.Touching(b2);
                    //bounce both balls - this is not very accurate :-(
                    ball.XSpeed *= -1;
                    ball.YSpeed *= -1;

                    b2.XSpeed *= -1;
                    b2.YSpeed *= -1;
                }
            }
        }

        private bool CheckOverlaps(MovingBall ball)
        {
            //check if overlaps any existing balls
            foreach (MovingBall b in balls)
            {
                if (ball.CollidesWith(b))
                {
                    ball.Touching(b);
                    return true; //found an overlap
                }
            }
            return false; //got to end of loop, so no overlaps
        }
    }
}
