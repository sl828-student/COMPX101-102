using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTest
{
    public class Medallist
    {
        //Create private fields here
        private string _country;
        private string _athlete;
        private int _gold;
        private int _silver;
        private int _bronze;

        //Create public properties here
        /// <summary>
        /// Gets and sets the country, checks it is not empty
        /// </summary>
        public string Country
        {
            get { return _country; }
            set
            {
                if (value == "")
                { throw new Exception("The country is an empty string"); }
                else
                { _country = value; }
            }
        }
        /// <summary>
        /// gets and sets the athlete, checks it is not empty
        /// </summary>
        public string Athlete
        {
            get { return _athlete; }
            set
            {
                if (value == "")
                { throw new Exception("The athlete is an empty string"); }
                else
                {
                    _athlete = value;
                }
            }
        }
        /// <summary>
        /// gets and sets the number of gold medals, checks not less than 0
        /// </summary>
        public int Gold
        {
            get { return _gold; }
            set
            {
                if (value < 0) { throw new Exception("Number of Gold medals cannot be less than 0"); }
                else { _gold = value; }
            }
        }
        /// <summary>
        /// gets and sets the number of silver medals, checks not less than 0
        /// </summary>
        public int Silver
        {
            get { return _silver; }
            set
            {
                if (value < 0) { throw new Exception("Number of silver medals cannot be less than 0"); }
                else { _silver = value; }
            }

        }
        /// <summary>
        /// gets and sets the number of silver medals, checks not less than 0
        /// </summary>
        public int Bronze
        {
            get { return _bronze; }
            set
            {
                if (value < 0) { throw new Exception("Numver of bronze medals cannot be less than 0"); }
                else { _bronze = value; }
            }
        }
        /// <summary>
        /// gets the total number of medals
        /// </summary>
        public int TotalMedals
        {
            get { return _gold + _silver + _bronze; }

        }

        //Create constructor here
        /// <summary>
        /// Initialises the object to the values passed in 
        /// </summary>
        /// <param name="country">Is the country of the athlete</param>
        /// <param name="athlete">Is the name of the athlete</param>
        /// <param name="gold">Is the number of gold medals</param>
        /// <param name="silver">Is the number of silver medals</param>
        /// <param name="bronze">Is the number of bronze medals </param>
        public Medallist(string country, string athlete, int gold, int silver, int bronze)
        {
            Country = country;
            Athlete = athlete;
            Gold = gold;
            Silver = silver;
            Bronze = bronze;

        }

        //Create other methods here
        /// <summary>
        /// Overrrides the tostring method to output data nicely
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _country.PadRight(30) + _athlete.PadRight(35) + "   " + _gold.ToString() + "   " + _silver.ToString() + "   " + _bronze.ToString();
        }


    }
}
