using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Mushroom_Form : Form
    {
        // 1. State Machine to track which question we are on
        private enum QuestionState { Gills, Forest, Ring, ConvexCup, Done }
        private QuestionState currentState;
        public Mushroom_Form()
        {
            InitializeComponent();
        }

        private void Mushroom_Form_Load(object sender, EventArgs e)
        {
            StartNewSession();
        }

        private void StartNewSession()
        {
            currentState = QuestionState.Gills;
            richTextChart.Clear();
            richTextChart.SelectionColor = Color.Black;

            // Print the initial menu
            richTextChart.AppendText("=== MUSHROOM IDENTIFIER ===\n");
            richTextChart.AppendText("1. Agaric Jaunissant\n2. Amanite tue-mouche\n3. Cepe de Bordeaux\n");
            richTextChart.AppendText("4. Coprin chevelu\n5. Girolle\n6. Pied bleu\n\n");

            AskQuestion("Does it have gills?");

            // Hide the Try Again button at the start of a session
            TryAgainButton.Visible = false;
        }

        private void AskQuestion(string question)
        {
            // Print the question in blue
            richTextChart.SelectionColor = Color.Blue;
            richTextChart.AppendText("System: " + question + "\n");
            richTextChart.ScrollToCaret();

            // Turn on the answer buttons
            YesButton.Enabled = true;
            NoButton.Enabled = true;
            lblStatus.Text = "Awaiting your answer...";
        }

        private void RecordAnswer(bool isYes)
        {
            // 1. Print the user's answer in green so it STAYS VISIBLE
            richTextChart.SelectionColor = Color.Green;
            richTextChart.AppendText("You: " + (isYes ? "Yes" : "No") + "\n\n");
            richTextChart.ScrollToCaret();

            // 2. Disable buttons temporarily
            YesButton.Enabled = false;
            NoButton.Enabled = false;

            // 3. Process the answer
            switch (currentState)
            {
                case QuestionState.Gills:
                    if (!isYes)
                        Result("Cepe de Bordeaux");
                    else
                    {
                        currentState = QuestionState.Forest;
                        AskQuestion("Does it grow in a forest?");
                    }
                    break;

                case QuestionState.Forest:
                    if (!isYes)
                    {
                        currentState = QuestionState.Ring;
                        AskQuestion("Does it have a ring?");
                    }
                    else
                    {
                        currentState = QuestionState.ConvexCup;
                        AskQuestion("Does it have a convex cup?");
                    }
                    break;

                case QuestionState.Ring:
                    Result(isYes ? "Coprin chevelu" : "Agaric Jaunissant");
                    break;

                case QuestionState.ConvexCup:
                    Result(isYes ? "Amanite tue-mouche or Pied bleu" : "Girolle");
                    break;
            }
        }

        private void Result(string mushroomName)
        {
            currentState = QuestionState.Done;
            lblStatus.Text = "Identification complete.";

            // Show the MessageBox
            MessageBox.Show($"Identified mushroom: {mushroomName}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Print a detailed description in the RichTextBox
            richTextChart.SelectionColor = Color.DarkRed;
            richTextChart.AppendText("🍄 RESULT: " + mushroomName + "\n");
            richTextChart.SelectionColor = Color.Black;
            richTextChart.AppendText(GetDescription(mushroomName) + "\n\n");

            richTextChart.SelectionColor = Color.Purple;
            richTextChart.AppendText("Click 'Try Again' to identify another mushroom, or 'Back' to leave.\n");
            richTextChart.ScrollToCaret();

            // Show the Try Again button now that we are done
            TryAgainButton.Visible = true;
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

        private void richTextChart_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            RecordAnswer(true);
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            RecordAnswer(false);
        }

        private string GetDescription(string name)
        {
            switch (name)
            {
                case "Agaric Jaunissant":
                    return "Description: A yellowish mushroom that stains bright yellow when bruised. Often found in fields, it can be toxic.";
                case "Amanite tue-mouche":
                    return "Description: Also known as the Fly Agaric. Famous for its red cap with white spots. Highly poisonous!";
                case "Cepe de Bordeaux":
                    return "Description: A prized edible mushroom with a thick stem and a brown, sponge-like cap. Highly sought after by chefs.";
                case "Coprin chevelu":
                    return "Description: The Shaggy Inkcap. It has a tall, scaly cap and eventually turns into black ink. Edible when young.";
                case "Girolle":
                    return "Description: The Golden Chanterelle. A bright yellow/orange mushroom with a funnel shape and a fruity smell. Delicious!";
                case "Amanite tue-mouche or Pied bleu":
                    return "Description: You have a mushroom with a convex cup, but the exact match depends on other features. The 'Pied bleu' (Blewit) is edible, but the 'Amanite' is toxic. Be careful!";
                default:
                    return "";
            }
        }

        private void TryAgainButton_Click(object sender, EventArgs e)
        {
            StartNewSession();
        }
    }
}
