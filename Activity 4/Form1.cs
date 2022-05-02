using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Media.SoundPlayer Jarvis = new System.Media.SoundPlayer(@"C:\Users\Branden\source\repos\Activity 4\Sounds\working-on-a-secret-project-are-we-sir (1) (1).wav");
            Jarvis.Play();

            // the needed calculations seperated
            int minutes = 60;
            int hour = minutes / minutes;
            int days = 86400 / minutes;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Tells the seconds.

            if (textBox1.Text == string.Empty)
            {
                DialogResult = MessageBox.Show("Please enter a number, either 60 or higher!" , "Heads Up!");
            }

            else if (textBox1.Text == "60")
            {
                System.Media.SoundPlayer good_to_go = new System.Media.SoundPlayer(@"C:\Users\Branden\source\repos\Activity 4\Sounds\coin.wav");
                good_to_go.Play();
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Tells the minutes.
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Tells the hours.
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // Tells the days.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // This will reset the whole form.

            // Empty txtbox 1
            textBox1.Text = string.Empty;
           
            // Empty txtbox 2
            textBox2.Text = string.Empty;

            // Empty txtbox 2
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // This will be the submit button and will calculate the number given.


            // Grab the user's number for seconds.
            double userseconds;
            if (double.TryParse(textBox1.Text, out userseconds))
                userseconds = userseconds;
            textBox1.Text = userseconds.ToString();


            // Divide the number by 60 to get the minutes
            double minutecalculation;
            double minutes = 60;
            if (double.TryParse(textBox1.Text, out minutecalculation))
            minutecalculation = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(minutes);
            textBox2.Text = minutecalculation.ToString();


            // Get the amount of hours.
            double hourcalculation;
            double hours = minutes / userseconds;
            if (double.TryParse(textBox1.Text, out hourcalculation))
            hourcalculation = Convert.ToDouble(userseconds) / Convert.ToDouble(60) / 60;
            textBox3.Text = hourcalculation.ToString();


            // Get the amount of days.
            double daycalculation;
            double days = 86400;
            if (double.TryParse(textBox1.Text, out daycalculation))
                daycalculation = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(days); 
            textBox4.Text = daycalculation.ToString();

        }
    }
}
