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
using System.Web;

namespace PracticalTest
{
    public partial class Form1 : Form
    {
        //Name: Shokei Leger-Yoshihara 
        //ID: 1656804

        const string FILTER = "CSV Files|*.csv|All Files|*.*";

        List<Medallist> medallistList = new List<Medallist>();

        List<Medallist> goldList= new List<Medallist>();

        List<Medallist> silverList= new List<Medallist>();

        List<Medallist> bronzeList= new List<Medallist>();


        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Will close the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This will load a file of Medallist information and display all the Medallist information in the listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declare variables required
            StreamReader reader;
            string line = "";
            string[] csvArray;

            string country = "", athlete = "";
            int gold = 0, silver = 0, bronze = 0;

            //Set the filter for the dialog control
            openFileDialog1.Filter = FILTER;
            //Allow the user to select a file and that they click on the OK button
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Open the selected file
                reader = File.OpenText(openFileDialog1.FileName);

                medallistList.Clear();

                while(!reader.EndOfStream)
                {
                    try
                    {
                        line = reader.ReadLine(); //reads line
                        csvArray = line.Split(','); //Splits into array on comma
                        if (csvArray.Length == 5) //checks the data is the correct number of values
                        {
                            country = csvArray[0];
                            athlete = csvArray[1];
                            gold = int.Parse(csvArray[2]);
                            silver = int.Parse(csvArray[3]);
                            bronze = int.Parse(csvArray[4]);

                            medallistList.Add(new Medallist(country, athlete, gold, silver, bronze));

                        }
                        else
                        {
                            Console.WriteLine("Error:  " + line);
                        }
                    }
                    catch
                    { Console.WriteLine("Error:  " + line); }
                }
                //Close the file
                reader.Close();
                UpdateListBox();
            }
        }
        /// <summary>
        /// Updates the listbox to display all atheletes currently in list
        /// </summary>
        private void UpdateListBox()
        {
            listBoxDisplay.Items.Clear();
            foreach (Medallist m in medallistList) //iterates through each medallist in the list
            {
                listBoxDisplay.Items.Add(m.ToString()); //display the data in listbox using overriden tostring
            }
        }

        /// <summary>
        /// method to filter by country
        /// </summary>
        /// <param name="country"></param>
        private void FilterByCountry(string country)
        {
            listBoxDisplay.Items.Clear();

            foreach (Medallist m in medallistList)
            {
                if (m.Country == country)
                {
                    listBoxDisplay.Items.Add(m.ToString());
                }
            }
        }

        /// <summary>
        /// Filters the listbox by country and medal 
        /// </summary>
        /// <param name="country"></param>
        /// <param name="medal"></param>
        private void FilterByCountryAndMedal(string country, string medal)
        {

            listBoxDisplay.Items.Clear();

            for (int i = 0; i < medallistList.Count; i++) //loops through all medallist
            {
                if (medallistList[i].Country == country && textBoxMedal.Text == "Gold") //Checks country is correct and medal
                {
                    if (medallistList[i].Gold > 0)
                    {
                        goldList.Add(medallistList[i]);
                    }
                    foreach (Medallist g in goldList)
                    { listBoxDisplay.Items.Add(g.ToString()); }
                }
                else if (medallistList[i].Country == country && textBoxMedal.Text == "Silver")
                {
                    if (medallistList[i].Silver > 0 )
                    {
                        silverList.Add(medallistList[i]);
                    }
                    foreach (Medallist s in silverList)
                    { listBoxDisplay.Items.Add(s.ToString()); }
                }
                else if (medallistList[i].Country == country && textBoxMedal.Text == "Bronze")
                {
                    if (medallistList[i].Bronze > 0)
                    {
                        bronzeList.Add(medallistList[i]);
                    }
                    foreach (Medallist b in bronzeList)
                    { listBoxDisplay.Items.Add(b.ToString()); }
                }
                //else
                //{
                //    MessageBox.Show("Error: Please enter string for country and medal type starting with a capital");
                //    break;
                //}
            }
        }
        /// <summary>
        /// Calcaulates the average medal count of a country
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        private double CalcAverageMedalCount(string country)
        {
            double total = 0;
            double average = 0;
            int counter = 0;

            foreach(Medallist medallist in medallistList)
            {
                if (medallist.Country == country)
                {
                    total = medallist.Gold + medallist.Silver + medallist.Bronze;
                    counter++;
                }
            }
            average = total / counter;
            return average;
        }

        /// <summary>
        /// This method will display info for all medallists.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayAllMedallistsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        
        /// <summary>
        /// This method will filter the listbox by the country specified in the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void filterByCountryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterByCountry(textBoxCountry.Text);
        }
        
        /// <summary>
        /// This method will filter the listbox by the country and medal specified in the textboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void filterByCountryAndMedalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterByCountryAndMedal(textBoxCountry.Text, textBoxMedal.Text);
        }

        /// <summary>
        /// This method will display the best medallist for the country specified in the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayBestMedallistToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string country = textBoxCountry.Text;
            int goldPoints = 3;
            int silverPoints = 2;
            int bronzePoints = 1;
            int index = 0;
            int points = 0;
            int mostPoints = 0;

            for (int i = 0; i < medallistList.Count; i++) //loops through all medallist
            {
                if (medallistList[i].Country == country) //Checks country is correct
                {
                    //Point system to calculate the value of each medal
                    points = medallistList[i].Gold * goldPoints + medallistList[i].Silver * silverPoints + medallistList[i].Bronze * bronzePoints;
                    if (points > mostPoints)
                    {
                        mostPoints = points;
                        index = i;
                    }
                }
                else
                {
                    MessageBox.Show("Error: Please enter the country you would like to know who the best medallist is for.");
                    break;
                }

            }
            MessageBox.Show($"The best Medalist is: \n\n\n{medallistList[index]}");
        }

        /// <summary>
        /// This method will display the average medal count for the country specified in the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayAverageMedalCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalcAverageMedalCount(textBoxCountry.Text);
        }

        /// <summary>
        /// This method will display the number of medallists in each country.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayMedallistCountByCountryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Contains testing code for testing your medallist class.  Comment and uncomment code to test
        /// the various aspects of your class.  Once finished make sure all testing code is commented out.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void testingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Valid Medallist that will display in the listbox
                //Medallist m1 = new Medallist("Australia", "Rachael Gunn", 0, 0, 0);
                //listBoxDisplay.Items.Add(m1);
                //MessageBox.Show("Total medals won by " + m1.Athlete + " is " + m1.TotalMedals.ToString());

                //Will cause an exception.
                //m1.Country = "";
                //m1.Gold = -1;

                //Will cause an exception
                //Medallist m2 = new Medallist("", "Rachael Gunn", 0, 0, 0);
                //Medallist m3 = new Medallist("Australia", "", 0, 0, 0);
                //Medallist m4 = new Medallist("Australia", "Rachael Gunn", -1, 0, 0);
                //Medallist m5 = new Medallist("Australia", "Rachael Gunn", 0, -1, 0);
                //Medallist m6 = new Medallist("Australia", "Rachael Gunn", 0, 0, -1);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
