/*
 * Branden M.
 * 06.02.22
 * Activity 15
 * CST-150
 * Prof. Mark Smithers
 * Grand Canyon University 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_15_CST_150
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This will handle the birth year. 

            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = @"C:\Users\technologyhyper\source\repos\Activity 15 CST-150\Sounds\selection.wav";
            player.Load();
            player.Play();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This will handle the birth month.
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = @"C:\Users\technologyhyper\source\repos\Activity 15 CST-150\Sounds\selection.wav";
            player.Load();
            player.Play();


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This will handle the birth day.
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = @"C:\Users\technologyhyper\source\repos\Activity 15 CST-150\Sounds\selection.wav";
            player.Load();
            player.Play();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This will handle the favorite color.

            if (comboBox4.SelectedIndex == 0)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = @"C:\Users\technologyhyper\source\repos\Activity 15 CST-150\Sounds\selection.wav";
                player.Load();
                player.Play();
                comboBox4.ForeColor = Color.Red;
                button1.ForeColor = Color.Red;
                this.ForeColor = Color.Red;
            }

            if (comboBox4.SelectedIndex == 1)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = @"C:\Users\technologyhyper\source\repos\Activity 15 CST-150\Sounds\selection.wav";
                player.Load();
                player.Play();
                comboBox4.ForeColor = Color.Blue;
                button1.ForeColor = Color.Blue;
                this.ForeColor = Color.Blue;
            }

            if (comboBox4.SelectedIndex == 2)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = @"C:\Users\technologyhyper\source\repos\Activity 15 CST-150\Sounds\selection.wav";
                player.Load();
                player.Play();
                comboBox4.ForeColor = Color.Green;
                button1.ForeColor = Color.Green;
                this.ForeColor = Color.Green;
            }

            if (comboBox4.SelectedIndex == 3)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = @"C:\Users\technologyhyper\source\repos\Activity 15 CST-150\Sounds\selection.wav";
                player.Load();
                player.Play();
                comboBox4.ForeColor = Color.Yellow;
                button1.ForeColor = Color.Yellow;
                this.ForeColor = Color.Yellow;
            }

            if (comboBox4.SelectedIndex == 4)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = @"C:\Users\technologyhyper\source\repos\Activity 15 CST-150\Sounds\selection.wav";
                player.Load();
                player.Play();
                comboBox4.ForeColor = Color.Orange;
                button1.ForeColor = Color.Orange;
                this.ForeColor = Color.Orange;
            }

            if (comboBox4.SelectedIndex == 5)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = @"C:\Users\technologyhyper\source\repos\Activity 15 CST-150\Sounds\selection.wav";
                player.Load();
                player.Play();
                comboBox4.ForeColor = Color.Black;
                button1.ForeColor = Color.Black;
                this.ForeColor = Color.Black;
            }

            if (comboBox4.SelectedIndex == 6)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = @"C:\Users\technologyhyper\source\repos\Activity 15 CST-150\Sounds\selection.wav";
                player.Load();
                player.Play();
                comboBox4.ForeColor = Color.Purple;
                button1.ForeColor = Color.Purple;
                this.ForeColor = Color.Purple;
            }

            if (comboBox4.SelectedIndex == 7)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = @"C:\Users\technologyhyper\source\repos\Activity 15 CST-150\Sounds\selection.wav";
                player.Load();
                player.Play();
                comboBox4.ForeColor = Color.Pink;
                button1.ForeColor = Color.Pink;
                this.ForeColor = Color.Pink;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // This will handle the lucky button form.
            Form2 FormNumber2 = new Form2();
            FormNumber2.Show();
            System.Media.SoundPlayer player2 = new System.Media.SoundPlayer();
            player2.SoundLocation = @"C:\Users\technologyhyper\source\repos\Activity 15 CST-150\Sounds\selection.wav";

            if (comboBox4.SelectedIndex == 0)
            {
                
                player2.Load();
                player2.Play();
                comboBox4.ForeColor = Color.Red;
                button1.ForeColor = Color.Red;
                FormNumber2.BackColor = Color.Red;
            }

            if (comboBox4.SelectedIndex == 1)
            {
               
                player2.Load();
                player2.Play();
                comboBox4.ForeColor = Color.Blue;
                button1.ForeColor = Color.Blue;
                FormNumber2.BackColor = Color.Blue;
            }

            if (comboBox4.SelectedIndex == 2)
            {
               
                player2.Load();
                player2.Play();
                comboBox4.ForeColor = Color.Green;
                button1.ForeColor = Color.Green;
                FormNumber2.BackColor = Color.Green;
            }

            if (comboBox4.SelectedIndex == 3)
            {
               
                player2.Load();
                player2.Play();
                comboBox4.ForeColor = Color.Yellow;
                button1.ForeColor = Color.Yellow;
                FormNumber2.BackColor = Color.Yellow;
            }

            if (comboBox4.SelectedIndex == 4)
            {
                player2.Load();
                player2.Play();
                comboBox4.ForeColor = Color.Orange;
                button1.ForeColor = Color.Orange;
                FormNumber2.BackColor = Color.Orange;
            }

            if (comboBox4.SelectedIndex == 5)
            {
                player2.Load();
                player2.Play();
                comboBox4.ForeColor = Color.Black;
                button1.ForeColor = Color.Black;
                FormNumber2.BackColor = Color.Black;
            }

            if (comboBox4.SelectedIndex == 6)
            {
                player2.Load();
                player2.Play();
                comboBox4.ForeColor = Color.Purple;
                button1.ForeColor = Color.Purple;
                FormNumber2.BackColor = Color.Purple;
            }

            if (comboBox4.SelectedIndex == 7)
            {
                player2.Load();
                player2.Play();
                comboBox4.ForeColor = Color.Pink;
                button1.ForeColor = Color.Pink;
                FormNumber2.BackColor = Color.Pink;
            }

        }
    }
}
