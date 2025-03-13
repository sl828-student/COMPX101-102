using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2___Zombie_Dice
{
    public partial class WinBox : Form
    {
        private Label labelMessage = new Label();
        public WinBox(string message)
        {
            InitializeComponent();
            label1.Text = message;

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
