using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Bicycle_Click(object sender, EventArgs e)
        {
            Bicycle_Form bicycleForm = new Bicycle_Form();
            bicycleForm.Show();
            this.Hide();
        }

        private void Mushroom_Click(object sender, EventArgs e)
        {
            Mushroom_Form mushroomForm = new Mushroom_Form();
            mushroomForm.Show();
            this.Hide();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
