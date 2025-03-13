using System;
using System.Windows.Forms;

//Shokei Leger-Yoshihara
//1656804

namespace Chlorine_Calculator___Purity_Swimming_Pools
{
    public partial class FormDepthUnit : Form
    {
        public FormDepthUnit()

           

        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormDepthUnit_Load(object sender, EventArgs e)
        {
   


        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxRadius.Clear();
            textBoxDepth.Clear();
            textBoxChlorineBags.Clear();
            textBoxChlorineKg.Clear();  
            textBoxCost.Clear();
            textBoxPoolVolume.Clear();



        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            //Declare Variables
            double radius = 0;
            double depth = 0;
            double poolVolume = 0;
            double chlorineRequiredKg = 0;
            double chlorineRequiredBags = 0;
            decimal costOfChlorine = 0;
            const double PI = 3.141592653589;



            try
            {
                //Get radius of the swimming pool
                radius = double.Parse(textBoxRadius.Text);

                //Get depth of swimming pool
                depth = double.Parse(textBoxDepth.Text);

                //calculate the volume of water in swimming pool
                poolVolume = PI * radius * radius * depth;

                //Calculate the kgs of chlorine required kg
                chlorineRequiredKg = poolVolume * 0.1;

                //Calculate the bags of chlorine required
                chlorineRequiredBags = chlorineRequiredKg / 2.0;


                //Calculate the total cost of the chlorine
                costOfChlorine = (Decimal)chlorineRequiredBags * 5.50m;

                //Display the volume of water (to 3dp)
                textBoxPoolVolume.Text = poolVolume.ToString("N3");

                //Display the number of kg of chlorine required (to 3dp)
                textBoxChlorineKg.Text = chlorineRequiredKg.ToString("N3");

                //Display the number of bags of chlorine required
                textBoxChlorineBags.Text = Math.Ceiling(chlorineRequiredBags).ToString();

                //Display the cost of the bags formatted as currency 
                textBoxCost.Text = costOfChlorine.ToString("c");
            }
            catch (Exception ex)
            {
                //Display error message
                MessageBox.Show(ex.Message);
                //Clear all input and display textboxes
                textBoxRadius.Clear();
                textBoxDepth.Clear();
                textBoxChlorineBags.Clear();
                textBoxChlorineKg.Clear();
                textBoxCost.Clear();
                textBoxPoolVolume.Clear();
                //set focus to first textbox
                textBoxRadius.Focus();
            }

            }

        }
    }

