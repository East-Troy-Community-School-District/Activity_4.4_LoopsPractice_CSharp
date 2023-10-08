/*
 * Greetings
 * Pawelski
 * 10/8/2023
 * Developing Desktop Applications
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greetings
{
    public partial class GreetingsForm : Form
    {
        public GreetingsForm()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            const string GREETING = "Hello, there...";
            int times;
            string greetings = "";

            times = Convert.ToInt32(timesTextBox.Text);
            for (int i = 0; i < times; i++)
            {
                greetings += GREETING + "\n";
            }
            greetingsLabel.Text = greetings;
        }
    }
}
