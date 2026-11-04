using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Bicycle_Form : Form
    {
        private int wrong = 0;
        public Bicycle_Form()
        {
            InitializeComponent();
        }

        private void Bicycle_Form_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void StartTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EndTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // 1. Check if maximum wrong attempts are reached
            if (wrong >= 7)
            {
                MessageBox.Show("You have used all 7 wrong attempts.", "Locked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string startNo = StartTextBox.Text.Trim();
            string endNo = EndTextBox.Text.Trim();

            // 2. Validate Start Time (0-23)
            if (!int.TryParse(startNo, out int start) || start < 0 || start > 23)
            {
                wrong++;
                MessageBox.Show("Please enter start time as a number from 0 to 23.", "Invalid Start Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Validate End Time (1-24)
            if (!int.TryParse(endNo, out int end) || end < 1 || end > 24)
            {
                wrong++;
                MessageBox.Show("Please enter an end time as a number from 1 to 24.", "Invalid End Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Validate Time Order
            if (start >= end)
            {
                wrong++;
                MessageBox.Show("Ending time must be greater than starting time.", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 5. Calculate Cost (Hardcoded rules exactly as console)
            int cost = 0;
            string breakdown = "=== CALCULATION BREAKDOWN ===\r\n";

            for (int h = start; h < end; h++)
            {
                int hourlyRate;

                if (h < 7 || h >= 21)
                {
                    hourlyRate = 500;
                    breakdown += $"Hour {h}:00 - {h + 1}:00 => 500 RWF (Night/Early Rate)\r\n";
                }
                else if (h < 14 || h >= 19)
                {
                    hourlyRate = 1000;
                    breakdown += $"Hour {h}:00 - {h + 1}:00 => 1000 RWF (Mid Rate)\r\n";
                }
                else
                {
                    hourlyRate = 1500;
                    breakdown += $"Hour {h}:00 - {h + 1}:00 => 1500 RWF (Peak Rate)\r\n";
                }

                cost += hourlyRate;
            }

            breakdown += "=============================\r\n";
            breakdown += $"Total Cost: {cost} RWF";

            // 6. Display Results
            TotalTextBox.Text = cost + " RWF";    // Update the TextBox (as seen in your image)
            Details.Text = breakdown;       // Show breakdown below

            // Show the MessageBox exactly as required
            MessageBox.Show(
                $"===== BICYCLE RENTAL =====\n" +
                $"Starting time: {start}:00\n" +
                $"Ending time:   {end}:00\n" +
                $"Rental time:   {end - start} hour(s)\n" +
                $"Total cost:    {cost} RWF\n" +
                $"==========================",
                "Rental Result",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }


        private void ResetButton_Click(object sender, EventArgs e)
        {
            StartTextBox.Clear();
            EndTextBox.Clear();
            TotalTextBox.Clear();
            Details.Text = "";
            StartTextBox.Focus();
        }

        private void TotalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Details_Click(object sender, EventArgs e)
        {

        }
    }

}
