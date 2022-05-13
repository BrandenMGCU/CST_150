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
 * 05/12/22
 * CST-150
 * Prof. Mark Smithers
 * Grand Canyon University
 */

namespace Activity_8_CST_150
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Welcome to the calorie counter app!" + "\n" + Environment.NewLine + "Simply input the amount of fat calorites and carb calories to get your result!", "Calorie Counter App");

            int fat_count;
            int fat_total;
        }

        private async void FatCalories_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // This will get the amount for the fat calorie count.
                int fat_count = int.Parse(FatCalories.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("You must put in a number!","ERROR!");
                FatCalories.Clear();
                return;
            }
        }

        private void CarbCalories_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // This will keep track of the calorie count for carbs.
                int calorie_count = int.Parse(CarbCalories.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("You must put in a number!", "ERROR!");
                CarbCalories.Clear();
                return;
            }
        }

        private void CalorieTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // We will finalize the carb count and the fat calorie count.
            int carb_total = int.Parse(CarbCalories.Text) * 4;
            int fat_total = int.Parse(FatCalories.Text) * 9;

            // This will then print out the results to the final textbox.
            CalorieTotal.Text = "Your total amount of fat calories is: " + fat_total + "." + Environment.NewLine + Environment.NewLine
                + '\n' + "Your total amount of carb calories is: " + carb_total + ".";
        }
    }
}
