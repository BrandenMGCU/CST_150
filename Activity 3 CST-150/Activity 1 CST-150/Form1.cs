//Branden M.
//04/26/22
//CST-150
//Activity 3
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

namespace Activity_1_CST_150
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // This will be the reset button for the form itself
            txtbox_firstname.Text = string.Empty;
            txtbox_fos.Text = string.Empty;
            txtbox_WHYGCU.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // This will check to make sure the user has entered information into each textbox
            if (txtbox_firstname.Text == string.Empty || txtbox_fos.Text == string.Empty || txtbox_WHYGCU.Text == string.Empty)
            {
                System.Media.SoundPlayer error = new System.Media.SoundPlayer();
                error.SoundLocation = @"C:\Users\Branden\source\repos\Activity 1 CST-150\Sounds\error.wav";
                error.Play();
                MessageBox.Show("You must fill every box with the required information!","ERROR!");
                return;
            }

            DialogResult = MessageBox.Show("The information you entered was: " + "\n" + "\n" + "First Name: " + txtbox_firstname.Text + "\n" + "\n" + "Field of Study is: " + txtbox_fos.Text + "\n" + "\n" +
                "Why Grand Canyon University: " + txtbox_WHYGCU.Text, "Information Check");

            // This will play a sound after the submit button has been pressed
            System.Media.SoundPlayer musicplayer = new System.Media.SoundPlayer();
            musicplayer.SoundLocation = @"C:\Users\Branden\source\repos\Activity 1 CST-150\Sounds\that_was_easy.wav";
            musicplayer.Play();

            // This will show the user a thank you message for submitting some of the information for this assignment!
            MessageBox.Show("Thank you for submitting this information for the Activity 1 assignment for CST-150!" + "\n" + "\n" + "This information is not saved or stored and is destroyed when the application is closed!", "Completed!");

            // This will empty all the text boxes above
            txtbox_firstname.Text = string.Empty;
            txtbox_fos.Text = string.Empty;
            txtbox_WHYGCU.Text = string.Empty;
        }
    }
}
