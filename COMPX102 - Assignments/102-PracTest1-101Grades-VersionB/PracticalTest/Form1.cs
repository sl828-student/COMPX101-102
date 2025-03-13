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
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace PracticalTest
{
    public partial class Form1 : Form
    {
        //Name:  Shokei Leger-Yoshihara
        //ID:    1656804
        const string FILTER = "CSV Files|*.csv|All Files|*.*"; //Filter for the streamreader

        List<Student> studentList = new List<Student>(); // List of the call to store all the student information
      
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Will Close the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This will load a file of student information and display all the student information in the listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            listBoxDisplay.Items.Clear();

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text file (*.txt)|*.txt";
            openFileDialog1.Title = "Select a file of names";

            string line = "";
            string[] csvArray;
            string paperCode = "";
            string trimester = "";
            int id = 0;
            string qualification = "";
            double examMark = 0;
            double finalMark = 0;
            string finalGrade = "";

            //Set the filter for the dialog control
            openFileDialog1.Filter = FILTER;
            //Allow the user to select a file and that they click on the OK button
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(openFileDialog1.FileName);

                //Open the selected file
                reader = File.OpenText(openFileDialog1.FileName);

                //Clear student List
                studentList.Clear();

                
                while (!reader.EndOfStream)
                {
                    try
                    {
                        //Splits CSV file by commas
                        line = reader.ReadLine();
                        csvArray = line.Split(',');
                        if (csvArray.Length == 7)
                        {
                            //Sepaerates information into array
                            paperCode = csvArray[0];
                            trimester = csvArray[1];
                            if (int.TryParse(csvArray[2], out id))
                                {
                                qualification = csvArray[3];
                                if (double.TryParse(csvArray[4], out examMark))
                                {
                                    if (double.TryParse(csvArray[5], out finalMark))
                                    {
                                        finalGrade = csvArray[6];

                                        studentList.Add(new Student (paperCode,trimester, id,qualification, examMark, finalMark, finalGrade));

                                        UpdateListBox();
                                    }
                                }
                            }
                            qualification = csvArray[3];
                            examMark = int.Parse(csvArray[4]);
                            finalMark = int.Parse(csvArray[5]);
                            finalGrade = csvArray[6];
                            //Creates new student using the information from csv
                            Student s = new Student (paperCode, trimester, id, qualification, examMark, finalMark, finalGrade);
                            //Adds new student
                            studentList.Add(s);
                            
                        }
                        else
                        { Console.WriteLine("Error: " + line); }
                    }
                    catch
                    { Console.WriteLine("Error: " + line); }
                    
                }
                //Close the file
                reader.Close();
                UpdateListBox();
            }
            

        }

        /// <summary>
        /// Method to update the listbox
        /// </summary>
        private void UpdateListBox()
        {
            listBoxDisplay.Items.Clear();

            foreach (Student s in studentList)
            {
                listBoxDisplay.Items.Add(s.ToString());
            }
           
        }
        /// <summary>
        /// Method to filter by qualification 
        /// </summary>
        /// <param name="qualification"></param>
        private void FilterByQualification(string qualification)
        {
            listBoxDisplay.Items.Clear();

            foreach (Student item in studentList) 
            {
                if (item.Qualification == textBoxQualification.Text)
                {
                    listBoxDisplay.Items.Add(item.ToString());
                }
            }
            
        }

        /// <summary>
        /// this method will filter the listbox by qualification and papercode gotten from the textboxes
        /// </summary>
        /// <param name="qualification"></param>
        /// <param name="paperCode"></param>
        private void filterByQualificationandPaperCode(string qualification, string paperCode)
        {
            listBoxDisplay.Items.Clear();

            foreach (Student item in studentList)
            {
                if (qualification == textBoxQualification.Text && paperCode == textBoxPaperCode.Text)
                {
                    listBoxDisplay.Items.Add(item.ToString());
                }
            }
            
        }
        /// <summary>
        /// This method will display the average Final Mark for the qualification and paper code specified in the textboxes.
        /// </summary>
        /// <param name="qualification"></param>
        /// <param name="paperCode"></param>
        /// <returns></returns>
        private double CalcAverageFinalMark (string qualification, string paperCode)
        {
            double totalFinalMark = 0;
            double averageFinalMark = 0;
            int counter = 0;

            foreach (Student item in studentList)
            {
                if (item.Papercode == paperCode && item.Qualification == qualification)
                {
                    totalFinalMark += item.FinalMark;
                    counter++;
                }
            }

            averageFinalMark = totalFinalMark / counter;
            return averageFinalMark;

        }

        /// <summary>
        /// This method will filter the listbox by the qualification specified in the textbox by calliong the filter by qualification method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void filterByQualificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterByQualification(textBoxQualification.Text);
        }

        /// <summary>
        /// This method will display info for all students.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayAllStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        /// <summary>
        /// This method will filter the listbox by the qualification and paper code specified in the textboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void filterByQualificationAndPaperCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterByQualificationandPaperCode(textBoxQualification.Text, textBoxPaperCode.Text);
        }

        /// <summary>
        /// This method will display the best student for the qualification and paper code specified in the textboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayBestStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string paperCode = textBoxPaperCode.Text;
            string qualification = textBoxQualification.Text;
            double bestMark = 0;
            int index = 0;

            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].Papercode == paperCode && studentList[i].Qualification == qualification && bestMark < studentList[i].FinalMark)
                {
                    bestMark = studentList[i].FinalMark;
                    index = i;
                }
            }
            MessageBox.Show($"The information of the student with the best final mark is {studentList[index]} with the best mark of {bestMark}");
        }

        /// <summary>
        /// This method will display the average Final Mark for the qualification and paper code specified in the textboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayAverageFinalMarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string paperCode = textBoxPaperCode.Text;
            string qualification = textBoxQualification.Text;

            double averageMark = CalcAverageFinalMark(paperCode, qualification);
            listBoxDisplay.Items.Add($"The average final mark of the paper code {paperCode} and qualification {qualification} was {averageMark}");
        }

        /// <summary>
        /// This method will display the number of students in each qualification.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayStudentCountByQualificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Student s in studentList)
            {
                if(s.Qualification == textBoxQualification.Text)
                {
                    listBoxDisplay.Items.Add(s);
                }
            }
        }

        /// <summary>
        /// Contains testing code for testing your student class.  Comment and uncomment code to test
        /// the various aspects of your class.  Once finished make sure all testing code is commented out.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void testingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Valid student that will display in the listbox
                //Student s1 = new Student("COMPX101-24", "A", 999, "BCompSc", 78.55, 94.36, "A+");
                //listBoxDisplay.Items.Add(s1);

                //Will cause an exception.
                //s1.PaperCode = "";
                //s1.Id = 43;

                //Will cause an exception
                //Student s2 = new Student("", "B", 767, "BDes", 55.78, 50.55, "C-");
                //Student s3 = new Student("COMPX101-24", "A", 23, "BCompSc", 78.55, 94.36, "A+");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
