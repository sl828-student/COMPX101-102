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
using System.Net.Sockets;
using System.Data.SqlTypes;

namespace PracticalTest3
{
    public partial class Form1 : Form
    {
        //Id: 
        //Name: 


        public Form1()
        {
            InitializeComponent();
        }

        //the width and height of a seat
        const int SEAT_SIZE = 35;
        //the size of the gap around seats
        const int SEAT_GAP = 2;
        //the number of rows and columns of seats in the theatre
        const int CINEMA_SIZE = 12;

        //Colour variables for the different booking types
        Color ADULT_SEAT_COLOUR = Color.Gold;
        Color CHILD_SEAT_COLOUR = Color.Purple;

        List<string> childList = new List<string>();
        List<string> adultList = new List<string>();
        List<string> seatList = new List<string>();
        List<string> rowList= new List<string>();


        /// <summary>
        /// Draws a seat at position (x,y) with the specified colour on the Graphics object specified.
        /// The seat is a filled rectangle and half circle with a gap around them.
        /// Uses the SeatSize and SeatGap constants for the size of the seat.
        /// </summary>
        /// <param name="paper">The Graphics object to draw on.</param>
        /// <param name="x">The x position of the top left corner of the seat.</param>
        /// <param name="y">The y position of the top left corner of the seat.</param>
        /// <param name="colour">The colour to fill the seat with.</param>
        private void DrawASeat(Graphics paper, int x, int y, Color colour)
        {
            //create a brush of specified colour and fill seat with this colour 
            SolidBrush brush = new SolidBrush(colour);
            paper.FillEllipse(brush, x + SEAT_GAP, y + SEAT_GAP, SEAT_SIZE - SEAT_GAP * 2, SEAT_SIZE - SEAT_GAP * 2);
            paper.FillRectangle(brush, x + SEAT_GAP, y + SEAT_SIZE / 2, SEAT_SIZE - SEAT_GAP * 2, SEAT_SIZE / 2 - SEAT_GAP);
        }

        /// <summary>
        /// calculates and returns the value of y 
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private int CalculateY(int row)
        {
            int y = (row - 1) * SEAT_SIZE;
            return y;
        }

        /// <summary>
        /// Draws a grid of cinema seats on the Graphics object supplied.
        /// Cinema is CinemaSize x CinemaSize squares, each of size SeatSize, 
        /// all chairs are initially drawn Black.
        /// </summary>
        /// <param name="paper">The Graphics object to draw on.</param>
        private void DrawCinema(Graphics paper)
        {
            for (int r = 0; r < CINEMA_SIZE; r++)
                for (int c = 0; c < CINEMA_SIZE; c++)
                    DrawASeat(paper, c * SEAT_SIZE, r * SEAT_SIZE, Color.Black);
        }

        /// <summary>
        /// Converts the seat letter that represents a column into
        /// an x position in the cinema.
        /// </summary>
        /// <param name="column">Seat Letter of the booking</param>
        /// <returns>The x position of the seat in the cinema</returns>
        private int CalculateX(string seatLetter)
        {
            int x = (seatLetter[0] - 'A') * SEAT_SIZE;

            return x;
        }
        /// <summary>
        /// Exits the application when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics paper = pictureBoxCinema.CreateGraphics();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt files (*.csv)| *.csv| All Files (*.*)| *.*";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //display normal grid
                    DrawCinema(paper);

                    //opens the selected file
                    using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
                    {
                        string line;

                        //reads file line by line
                        while ((line = reader.ReadLine()) != null) //while (!reader.EndOfStream)
                        {
                            try
                            {
                                //Splits the lines of values into an array as string
                                string[] csvArray = line.Split(',');

                                //check there is the correct number of elements
                                if (csvArray.Length == 4)
                                {
                                    string seat = csvArray[0];
                                    int row = int.Parse(csvArray[1]);
                                    string patronName = csvArray[2];
                                    string ticketType = csvArray[3];

                                    //Add values to list box
                                    listBoxBookings.Items.Add(seat.PadRight(5) + row.ToString().PadRight(5) + patronName.PadRight(30) + ticketType);//padright not working 

                                    //Adds values to lists
                                    seatList.Add(seat);
                                    rowList.Add(row.ToString());


                                    //checks if ticket is adult, draws if it is 
                                    if (ticketType == "Adult")
                                    {
                                        DrawASeat(paper, CalculateX(seat), CalculateY(row), ADULT_SEAT_COLOUR);
                                        //Adds to the adult list
                                        adultList.Add(ticketType);
                                    }
                                    //checks if ticket is child, draws if it is
                                    else if (ticketType == "Child")
                                    {
                                        DrawASeat(paper, CalculateX(seat), CalculateY(row), CHILD_SEAT_COLOUR);
                                        //Adds to the child list
                                        childList.Add(ticketType);
                                    }
                                    //If not adult or child lets you know where error is 
                                    else
                                    {
                                        Console.WriteLine("Error " + line);
                                    }
                                }

                            }
                            //tracks error and what line of data the error occured
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error processing line: " + line + ". " + ex.Message);
                            }
                        }
                        //Close reader
                        reader.Close();
                    }


                }
                //Handles exceptions 
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Counts the number of bookings for either Adults or Children for a given dataset when selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void countBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //checks that a parameter has been set in the combobox
            if (comboBoxBookings.SelectedItem != null)
            {
                string selectedBookings = comboBoxBookings.SelectedItem.ToString();
                int count = 0;

                //checked if the selected booking is adult or child
               if (selectedBookings == "Adult")
                {
                    count = adultList.Count();
                }
               else if (selectedBookings == "Child")
                {
                    count = childList.Count();
                }
                //display the selected number in a messagebox
                MessageBox.Show("The number of your selected booking type is: " + count.ToString());
                listBoxBookings.Refresh();
            }
            //Handles errors
            else
            {
                MessageBox.Show("No booking type selected!");
            }
        }
        /// <summary>
        /// ignore this method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This method draws a selected booking in the colour red _Bonus Task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxBookings_SelectedIndexChanged(object sender, EventArgs e)
        {
            //creates the graphics to draw the selected booking
            Graphics paper = pictureBoxCinema.CreateGraphics();
            //converts the selected listing to an index number integer to be used in finding row and seat
            int selectedListing = listBoxBookings.SelectedIndex;

            //finds the positon of the selected index in the seat List
            string seatNumber = seatList[selectedListing].ToString();
            //fins the postion of the selected index in the row list
            int rowNumber = int.Parse(rowList[selectedListing]);

            //Draws the selected index seat as red
            DrawASeat(paper, CalculateX(seatNumber), CalculateY(rowNumber), Color.Red);

        }
    }
}
