using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Branden M.
 * Activity 14
 * CST-150
 * Prof. Mark Smithers
 * Grand Canyon University
 */

namespace Activity_14_CST_150
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* List box will act as a queue for what is currently playing
             * and what is up next.
             */

            if (listBox1.SelectedIndex == 0)
            {
                axWindowsMediaPlayer1.URL = "C:/Users/Branden/source/repos/Activity 14 CST-150/Sample Videos/Movie 1.mp4";
            }

            if  (listBox1.SelectedIndex == 1)
            {
                axWindowsMediaPlayer1.URL = "C:/Users/Branden/source/repos/Activity 14 CST-150/Sample Videos/Movie 2.mp4";
            }

            if (listBox1.SelectedIndex == 2)
            {
                axWindowsMediaPlayer1.URL = "C:/Users/Branden/source/repos/Activity 14 CST-150/Sample Videos/Movie 3.mp4";
            }
        }

            private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // This will show a label for the Movie Name if checked.

            label5.Visible = false;

            if (listBox1.SelectedIndex == 0)
            {
                label5.Text = "Movie Example 1";
                label5.Visible = true;
                label5.Update();
            }

            if (listBox1.SelectedIndex == 1)
            {
                label5.Text = "Movie Example 2";
                label5.Visible = true;

            }

            if (listBox1.SelectedIndex == 2)
            {
                label5.Text = "Movie Example 3";
                label5.Visible = true;
            }


            // If not checked, this will hide the Movie Name.

            if (!checkBox1.Checked)
            {
                label5.Visible = false;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // This will be the like button and show a message that you've like this movie.

            if (radioButton1.Checked)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                radioButton1.Checked = false;
                MessageBox.Show("I'll recommend more content like this!");
            }
            return;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // This will be the dislike button.
            if (radioButton2.Checked)
            {
                listBox3.Items.Add(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox1.SelectedItem);
                radioButton2.Checked = false;
                MessageBox.Show("I will not recommend more content like this!");
            }
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("C:/Users/Branden/source/repos/Activity 14 CST - 150/Sample Videos/Movie 1.mp4");
            listBox1.Items.Add("C:/Users/Branden/source/repos/Activity 14 CST - 150/ Sample Videos/ Movie 2.mp4");
            listBox1.Items.Add("C:/Users/Branden/source/repos/Activity 14 CST - 150/Sample Videos/Movie 3.mp4");
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            // This is the reference to the W.M.P.
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // This button will change the background to black for a better view.
            if (checkBox2.Checked)
            {
                BackColor = System.Drawing.Color.Black;
                radioButton1.ForeColor = Color.White;
                radioButton2.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                listBox2.BackColor = Color.Black;
                listBox3.BackColor = Color.Black;
            }

            /* If the dimmed background box isn't checked then the form
             * will revert to the default background. 
             */
            if (!checkBox2.Checked)
            {
                BackColor = DefaultBackColor;
                radioButton1.ForeColor = DefaultForeColor;
                radioButton2.ForeColor = DefaultForeColor;
                label5.ForeColor = DefaultForeColor;
                listBox2.BackColor = DefaultBackColor;
                listBox3.BackColor = DefaultBackColor;
            }

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
