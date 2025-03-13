using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Task_2
{
    public partial class Form1 : Form
    {
        public static List<Student> students = new List<Student>();


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve input from text boxes
                string name = textBoxName.Text;
                int id = int.Parse(textBoxID.Text);
                bool hasPaid = radioButtonHasPaid.Checked;

                // Create new student and add to the list
                Student newStudent = new Student(name, id, hasPaid);
                students.Add(newStudent);

                // Update the listbox
                UpdateListBox();
                textBoxID.Clear();
                textBoxName.Clear();
                radioButtonHasPaid.Checked = false;
            }
            catch(Exception ex ) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateListBox()
        {
            listBox1.Items.Clear();
            foreach (Student student in students)
            {
                listBox1.Items.Add(student.ToString());
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            students.Clear();
            textBoxID.Clear();
            textBoxName.Clear();
            radioButtonHasPaid.Checked = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
