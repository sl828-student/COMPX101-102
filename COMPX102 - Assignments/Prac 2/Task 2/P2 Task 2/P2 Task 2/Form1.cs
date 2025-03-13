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

namespace P2_Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            OpenFileDialog openFileDialog1= new OpenFileDialog();
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            openFileDialog1.Title = "Select a file with words";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;

                List<string> words = ReadFile(selectedFileName);
                bool hasValue100 = false;

                foreach (string word in words)//checks words in list
                {
                    int totalValue = 0;
                    totalValue += CalculateWordValue(word);

                    if(totalValue >= 90 && totalValue <= 110) // checks value is between 90 and110
                    {
                        listBox1.Items.Add($"{word} - {totalValue}");
                        if (totalValue == 100)
                        {
                            hasValue100= true;
                        }
                    }

                    
                }
                if (hasValue100)
                {
                    MessageBox.Show("There is at least one word with value 100");
                }
                else
                {
                    MessageBox.Show("There are no words with value 100");
                }
            }
        }
        /// <summary>
        /// method reads file
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private List<string> ReadFile(string path)
        {
            List<string> words = new List <string>();

            try
            {
                using (StreamReader sr =  new StreamReader(path))
                {
                    string line;
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();  
                        words.Add (line.Trim());
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error reading the file: " + ex.Message);
            }
            return words;
        }
        /// <summary>
        /// method calculates word value
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        static int CalculateWordValue(string word)
        {
            int totalValue = 0;
            foreach (char c in word.ToLower())//checks the value of charachters in words and adds each character to the total
                if (char.IsLetter(c))
                {
                    totalValue += c - 'a' + 1;
                }
            return totalValue;
        }

    }
}
