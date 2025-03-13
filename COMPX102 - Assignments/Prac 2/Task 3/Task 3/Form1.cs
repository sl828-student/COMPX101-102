using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// opens and processes txt file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text file (*.txt)|*.txt";
            openFileDialog1.Title = "Select a file of names";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;

                List<string> allNames = ReadFile(selectedFileName);
                List<string> uniqueNames = new List<string>();
                List<int> nameCount = new List<int>();

                foreach (string name in allNames)//processes all names in into a all names list
                {
                    if (!uniqueNames.Contains(name))//checks if unique names list doesnt contains name, if it doesnt the nname gets added
                    {
                        uniqueNames.Add(name);
                        nameCount.Add(1);
                    }
                    else
                    {
                        nameCount[uniqueNames.IndexOf(name)]++;//if the name already exists adds to the count of the name
                    }
                }
                foreach (string uniquename in uniqueNames) //processes all the names in unique names
                {
                    int index = uniqueNames.IndexOf(uniquename); //creates index position of the names in unique names
                    listBox1.Items.Add(uniquename + " " + nameCount[index]); //displays name and count to the listbox
                }
            }
        }
        /// <summary>
        /// method reads the file into list of names
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private List<string> ReadFile(string fileName)
        {
            List<string> names = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        names.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading the file: " + ex.Message);
            }
            return names;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

        }
    }
}
