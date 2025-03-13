using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracP6
{
    /// <summary>
    /// A simple game of space invaders.
    /// </summary>
    public partial class SpaceInvaders : Form
    {
        //####################################################################
        //# Instance Variables
        /// <summary>
        /// List of all sprites.
        /// </summary>
        private List<Sprite> sprites_;
        /// <summary>
        /// The alien ship. It is also included in the list of sprites,
        /// but the separate variable helps to invoke the alien's special
        /// method to drop bombs.
        /// </summary>
        private AlienShip alien_;

        //####################################################################
        //# Constructor
        /// <summary>
        /// Initialise the Space Invaders game.
        /// </summary>
        /// 

        ///
        private PlayerShip playerShip_; // Added this declaration

        public SpaceInvaders()
        {
            InitializeComponent();
            MinimumSize = Size;
            MaximumSize = Size;
            sprites_ = new List<Sprite>();
            alien_ = new AlienShip(pictureBox_.Width);
            sprites_.Add(alien_);

            // Initialize the player's ship and add it to the sprite list
            playerShip_ = new PlayerShip(pictureBox_.Width / 2, pictureBox_.Height - 50);
            sprites_.Add(playerShip_);

            // Set up the key event handlers for player movement
            this.KeyDown += SpaceInvaders_KeyDown;
            this.KeyUp += SpaceInvaders_KeyUp;
        }

        //####################################################################
        //# Event Handlers
        /// <summary>
        /// Tick handler of animation timer.
        /// This code is executed repeatedly at regular time intervals.
        /// </summary>
        private void animationTimer__Tick(object sender, EventArgs e)
        {
            // Move all sprites.
            foreach (Sprite sprite in sprites_.ToList())
            {
                sprite.Move();
            }
            // Check whether the alien wants to drop a bomb.
            AlienBomb bomb = alien_.LaunchBomb();
            if (bomb != null)
            {
                sprites_.Add(bomb);
            }
            // Make sure all changes are displayed.
            Refresh();
            // Check for collisions.
            foreach (Sprite sprite in sprites_.ToList())
            {
                if (sprite.HasCollidedWith(alien_))
                {
                    sprites_.Add(new Explosion(alien_.X, alien_.Y));
                    animationTimer_.Stop();
                    MessageBox.Show("The alien ship has been hit! Player wins.");
                    Application.Exit();
                }
                else if (sprite.HasCollidedWith(playerShip_) && sprite is AlienBomb)
                {
                    sprites_.Add(new Explosion(playerShip_.X, playerShip_.Y));
                    animationTimer_.Stop();
                    MessageBox.Show("Player ship has been hit! Game over.");
                    Application.Exit();
                }
            }
            sprites_.RemoveAll(sprite => sprite is Explosion explosion && explosion.IsExpired);
        }

        /// <summary>
        /// Paint event handler. This is called when the form needs repainting,
        /// or in response to the Refresh() method call above. It simply displays
        /// all sprites in the correct graphics context.
        /// </summary>
       private void pictureBox__Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.Clear(Color.Black);
            foreach (Sprite sprite in sprites_)
            {
                sprite.Draw(graphics);
            }
        }

        private void SpaceInvaders_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                playerShip_.setDirection(-1);
            }
            else if (e.KeyCode == Keys.Right)
            {
                playerShip_.setDirection(1);
            }
        }

        private void SpaceInvaders_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                playerShip_.setDirection(0);
            }
        }
    }
}
