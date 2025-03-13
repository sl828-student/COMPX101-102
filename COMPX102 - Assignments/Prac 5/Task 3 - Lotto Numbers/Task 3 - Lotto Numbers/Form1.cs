using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3___Lotto_Numbers
{
    public partial class Form1 : Form
    {
        private List<LottoLine> lottoLines = new List<LottoLine>();

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] lines = System.IO.File.ReadAllLines(openFileDialog.FileName);
                foreach (var line in lines)
                {
                    string[] csvArray = line.Split(',');
                    if (csvArray.Length == 6)
                    {
                        lottoLines.Add(new LottoLine(csvArray));
                    }
                    else if (csvArray.Length == 7)
                    {
                        lottoLines.Add(new PowerBallLine(csvArray));
                    }
                }
                UpdateListBox();
            }
        }

        private void UpdateListBox()
        {
            listBox1.Items.Clear();
            int[] winNumsArray = { 29, 10, 12, 8, 32, 27 };
            int winPowerball = 18;

            foreach (var lottoLine in lottoLines)
            {
                if (lottoLine is PowerBallLine powerballLine)
                {
                    int matchCount = powerballLine.CheckNumbers(winNumsArray, winPowerball);
                    listBox1.Items.Add($"{powerballLine} Matches: {matchCount}");
                }
                else
                {
                    int matchCount = lottoLine.CheckNumbers(winNumsArray);
                    listBox1.Items.Add($"{lottoLine} Matches: {matchCount}");
                }
            }
        }
        
    }
}
