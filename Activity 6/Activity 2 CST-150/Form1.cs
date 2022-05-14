﻿//Branden M.
//05/13/22
//CST-150
//Activity 6 (Activity 2 Refinement) 
//Earth to Mars Conversion Program
//Grand Canyon University
//Prof. Mark Smithers

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_2_CST_150
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // This will take the user's input weight on Earth.
            try
            {
                double user_weight = double.Parse(textBox1.Text);
            }
            catch (Exception ex)
            {
                textBox1.Clear();
                MessageBox.Show("The forms are now empty. Enter a number!", "Clear!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // This will display the user's weight on Mars.
            textBox2.ReadOnly = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // This will show the user's weight on Mars.
                if (textBox1.Text == String.Empty)
                {
                    MessageBox.Show("Enter your weight on Earth, to get your weight on Mars!", "UH-OH!");
                }

                //Get the input from the Earth weight text box.
                decimal mars_weight = decimal.Parse(textBox1.Text);

                // This will show the answer when the convert button is pressed.
                double answer = Convert.ToDouble(mars_weight) / 9.81 * 3.711;

                // This will display the answer to the Mars text box.
                textBox2.Text = answer.ToString();
                var three_decimal = Math.Round(answer, 3);
                textBox2.Text = three_decimal.ToString();
            }

            catch (Exception ex)
            {
                // This will handle the error and allow the user to try again.
            }
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
