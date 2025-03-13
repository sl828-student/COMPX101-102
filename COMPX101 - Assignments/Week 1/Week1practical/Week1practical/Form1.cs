using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1practical
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            ///This will close the application.
            Application.Exit();
        }

        private void buttonHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Warlord of Mars!");
            buttonChangeColour.Enabled = true;
        }

        private void buttonChangeColour_Click(object sender, EventArgs e)
        {
            buttonHello.BackColor = Color.GreenYellow;
            buttonChangeColour.BackColor = Color.Indigo;
            buttonExit.BackColor = Color.LightSalmon;

        }
    }
}
