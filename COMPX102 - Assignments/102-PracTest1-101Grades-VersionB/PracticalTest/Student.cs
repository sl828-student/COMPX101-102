using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticalTest
{
    public class Student
    {
        //Create private fields here
        private string _papercode;
        private string _trimester;
        private int _id;
        private string _qualification;
        private double _examMark;
        private double _finalMark;
        private string _finalGrade;

        private List <Student> _studentsList;


        //Create public properties here
        /// <summary>
        /// Gets and sets the papercode, also checks that it is not an empty string
        /// </summary>
        public string Papercode
        { 
            get { return _papercode; } 
            set {
                if (value == "")
                {
                    throw new Exception("The papercode must not be an empty string");
                }
                else
                {
                    _papercode = value;
                }
            }
        }
        /// <summary>
        /// Gets and sets tghe id checking that it is not less than 100
        /// </summary>
        public int Id
        {
            get { return _id; }
            set
            {
                if (value < 100)
                {
                    throw new Exception("ID cannot be less than 100");
                }
                else
                {
                    _id = value;
                }
            }
        }
        /// <summary>
        /// Gets the trimester
        /// </summary>
        public string Trimester
        {
            get { return _trimester; }
        }
        /// <summary>
        /// Gets the qualification
        /// </summary>
        public string Qualification
        {
            get { return _qualification; }
        }

        /// <summary>
        /// Gets the exam Mark
        /// </summary>
        public double ExamMark
        {
            get { return _examMark; }
        }
        /// <summary>
        /// Gets the final Mark
        /// </summary>
        public double FinalMark
        { get { return _finalMark; } }
        /// <summary>
        /// gets the final grade
        /// </summary>
        public string FinalGrade
        { get { return _finalGrade; } }


        //Create constructor here
        /// <summary>
        /// Initialises the object to the values passed in
        /// </summary>
        /// <param name="paperCode">The code associated with the paper</param>
        /// <param name="trimester">the trimester the papaer was completed within</param>
        /// <param name="id">the id of the student </param>
        /// <param name="qualification">the qualification the student is working towards</param>
        /// <param name="examMark">The mark recieved by the student after the exam</param>
        /// <param name="finalMark">the final mark of the paper</param>
        /// <param name="finalGrade">the final letter grade for the student</param>
        public Student (string paperCode, string trimester, int id, string qualification, double examMark, double finalMark, string finalGrade)
        {
            _papercode = paperCode;
            _trimester = trimester;
            _id = id;
            _qualification = qualification;
            _examMark = examMark;
            _finalMark = finalMark;
            _finalGrade = finalGrade;
        }

        //Create other methods here

        public override string ToString()
        {
            return _papercode.PadRight(12) + _trimester.PadRight(2) + _id.ToString().PadRight(5) + _qualification.PadRight(10) + _examMark.ToString().PadRight(10) + _finalMark.ToString().PadRight(10) + _finalGrade;
        }
        /**public void DisplayStudents(ListBox listBoxDisplay)
        {
            listBoxDisplay.Items.Clear();
            foreach (Student s in _studentsList )
            {
                listBoxDisplay.Items.Add(s);
            }
        }
        **/
        
        public void CheckPaperCode(string paperCode)
        {
            if (string.IsNullOrEmpty(paperCode))
            {
                throw new ArgumentNullException("Papercode is empty");
            }
        }
        public void CheckID(int id)
        {
            if (id < 100)
            {
                throw new ArgumentOutOfRangeException("id");
            }
        }

    }
}
