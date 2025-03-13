using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_Test2_Practice
{
    public partial class Form1 : Form
    {
        const int MIN_SQUARES = 6;
        const int MAX_SQUARES = 20;
        const int SQUARE_HEIGHT = 50;
        const int SQUARE_WIDTH = 50;

        public Form1()
        {
            InitializeComponent();
            //sets focus to textbox
            textBoxInputNumber.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxInputNumber.Clear();
            textBoxInputNumber.Focus();
            pictureBoxDisplay.Refresh();

        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            Pen pen1 = new Pen(Color.Black, 2);
            SolidBrush brush1 = new SolidBrush(Color.LightBlue);

            int displaySize = int.Parse(textBoxInputNumber.Text);

        }
    }
}
