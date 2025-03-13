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

namespace Elections_Votes_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.Filter = "CSV files (*.csv)|*.csv";
                openFileDialog1.Title = "Please select a election results file";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog1.FileName;

                    ProcessFile(fileName);

                }
            }
        }

        private void ProcessFile(string fileName)
        {
            var partyVotes = new Dictionary<string, int>();
            int totalVotes = 0;

            try
            {
                using (var reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split(',');
                        if (parts.Length == 2)
                        {
                            string partyName = parts[0].Trim();
                            if (int.TryParse(parts[1].Trim(), out int votes))
                            {
                                if (partyVotes.ContainsKey(partyName))
                                {
                                    partyVotes[partyName] += votes;
                                }
                                else
                                {
                                    partyVotes[partyName] = votes;
                                }


                                totalVotes += votes;
                            }
                            else
                            {
                                MessageBox.Show($"Invalid vote count for party: {partyName}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading the file: {ex.Message}");
                return;
            }
            listBox1.Items.Clear();
            textBoxTotalVotes.Text = $"Total votes: {totalVotes}";

            const int totalSeats = 120;
            int votesPerSeat = totalVotes > 0 ? totalVotes / totalSeats : 0;
            textBoxVotes.Text = votesPerSeat > 0 ? $"Votes per seat: {votesPerSeat}" : "Votes per seat: N/A";

            foreach (var party in partyVotes)
            {
                int seatsGained = votesPerSeat > 0 ? party.Value / votesPerSeat : 0;
                listBox1.Items.Add($"{party.Key}: {party.Value} votes, {seatsGained} seats");
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBoxVotes.Clear();
            textBoxTotalVotes.Clear();
        }
    }
}