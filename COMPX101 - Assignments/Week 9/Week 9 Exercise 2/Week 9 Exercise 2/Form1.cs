using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace Week_9_Exercise_2
{
    public partial class Form1 : Form
    {
        int[] idArray = new int[100];
        int[] markArray = new int[100];
        string[] letterGradeArray = new string[100];
        

        public Form1()
        {
            InitializeComponent();
        }

        private int CalculateBarHeight(int mark)
        {
            int barHeight = pictureBoxDisplay.Height * mark / 100;
            return barHeight;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxData.Items.Clear();
            pictureBoxDisplay.Refresh();
            OpenFileDialog ofd = new OpenFileDialog(); //creates an open file dialog variable
            ofd.Filter = "CSV files (*.csv)|*.csv"; //filters so that the user can only see csv files when using show dialog
            int counter = 0; //keeps track of what line we are currently on so we can reference the correct position in the array

            try
            {
                if (ofd.ShowDialog() == DialogResult.OK) //once the user clicks ok on a file
                {
                    using (StreamReader sr = new StreamReader(ofd.FileName)) //using the streamreader data will be written to the arrays and listbox
                    {
                        while (!sr.EndOfStream) //until we reach the end of stream the program will continue to do this
                        {
                            string line = sr.ReadLine();
                            string[] parts = line.Split(',');

                            if (parts.Length == 2) //checks that there are only 2 data values
                            {
                                if (int.TryParse(parts[0], out idArray[counter])) //adds the id to the idarray
                                {
                                    if (int.TryParse(parts[1], out markArray[counter])) //adds the mark to the markarray
                                    {
                                        for (int i = 0; i < markArray[counter]; i++) //for each mark in the marksarray calculate a letter grade
                                        {
                                            string letterGrade = CalcLetterGrade(i);
                                            letterGradeArray[i] = letterGrade;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show($"There is an error in the formatting on line {counter + 1}");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show($"There is an error in the formatting on line {counter + 1}");
                                }
                            }
                            else
                            {
                                MessageBox.Show($"There is an error in the formatting on line {counter + 1}");
                            }

                            counter++;
                        }
                    }

                    for (int i = 0; i < idArray.Length; i++) //for the length of the idarray add the values to the list box display
                    {
                        if (idArray[i] == 0) //as there are 100 positions once we reach a position with an id = 0 stop this loop
                        {
                            return;
                        }
                        listBoxData.Items.Add($"{idArray[i]}, {markArray[i]}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }


        private void buttonClearGraph_Click(object sender, EventArgs e)
        {
            pictureBoxDisplay.Refresh();
        }

        private void buttonGraphMarks_Click(object sender, EventArgs e)
        {
            int x = 0;
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            SolidBrush br = new SolidBrush(Color.Gray);
            Pen pen1 = new Pen(Color.Black, 2);
            for (int i = 0; i < idArray.Length; i++)
            {
                if (idArray[i] == 0)
                {
                    return;
                }
                int barHeight = CalculateBarHeight(markArray[i]);
                int y = pictureBoxDisplay.Height - barHeight;

                paper.FillRectangle(br, x, y, 5, barHeight);
                paper.DrawRectangle(pen1, x, y, 5, barHeight);
                x += 5;
            }
        }

        private string CalcLetterGrade(int index)
        {
            string letter = "";

            //Converts mark to letter grade
            if (markArray[index] >= 80 && markArray[index] <= 100)
            {
                return letter = "A";
                
            }
            else if (markArray[index] >= 65)
            {
                return letter = "B";
            }
            else if (markArray[index] >= 50)
            {
                return letter = "C";
            }
            else if (markArray[index] >= 35)
            {
                return letter = "D";
            }
            else
            {
                return letter = "E";
            }
           
            



        }

        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "text files (*.txt)|*.txt";
            int counter = 0;
            try
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        sw.WriteLine("{0,-10} {1,-8} {2,-15}", "ID Number", "||   Mark  ", "|| Letter Grade");

                        for (int i = 0; i < idArray.Length; i++) //for the amount of data in the id array generate a row of data
                        {
                            if (idArray[i] == 0)
                            {
                                return;
                            }
                            counter++;
                            sw.WriteLine("{0,-10} {1,-8} {2,-13}", idArray[i], $"||\t{markArray[i]}", $" ||\t{letterGradeArray[i]}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }
    }
}



