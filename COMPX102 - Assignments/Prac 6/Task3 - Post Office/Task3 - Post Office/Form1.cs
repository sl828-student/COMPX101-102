using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3___Post_Office
{
    public partial class Form1 : Form
    {
        //item list at class levbel
        List<PostalItem> itemsList = new List<PostalItem>();

        public Form1()
        {
            InitializeComponent();

            itemsList.Add(new Letter("123 Main St", "Alice", 120, 230, true));
            itemsList.Add(new Postcard("456 Elm St", "Bob", 100, 150, false));
            itemsList.Add(new Parcel("789 Oak St", "Charlie", 150, 200, true, 100,5));

            listBoxData.DataSource = itemsList;
            listBoxData.DisplayMember = "ToString";
        }

        private void buttonCost_Click(object sender, EventArgs e)
        {
            decimal totalCost = 0;
            foreach (PostalItem item in itemsList)
            {
                totalCost += item.Cost(); // Accumulate the cost
            }
            MessageBox.Show($"Total cost: {totalCost:C}"); // Show the total cost
        }
    }
}
