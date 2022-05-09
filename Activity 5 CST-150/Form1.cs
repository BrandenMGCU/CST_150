using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Branden M.
 * CST-150
 * Prof. Smithers
 * Grand Canyon University
 * 05/07/22 */

namespace Activity_5_CST_150
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Play a sound when the application begins.
            System.Media.SoundPlayer intro_sound = new System.Media.SoundPlayer(@"C:\Users\Branden\source\repos\Activity 5 CST-150\Sounds\MagicWand.wav");
            intro_sound.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // This is the foundation to opening a file.
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                richTextBox1.Text = sr.ReadToEnd();

                List<string> lines = System.IO.File.ReadAllLines(openFileDialog.FileName).ToList();
                sr.Close();
            }
        }

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {
            // This is the open file dialog.
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // This will save the information in the box to a text file.
            SaveFileDialog save_info = new SaveFileDialog();

            // Show the save file screen and the format that it will be saved as.
            save_info.Filter = "Text File (*.txt)|*.txt";
            save_info.DefaultExt = "txt";




            // Shows where the file will be saved at.
            save_info.InitialDirectory = @"C:\Users\Branden\Documents";

            // This will save the file to the directory.
            if (save_info.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(save_info.FileName, richTextBox1.Text);
            }


            //Shows that the file has been saved and where the file is located.
            MessageBox.Show("The file was saved and is located in: " + save_info.InitialDirectory, "File Saved Successfully!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // This will alphabetically sort the list of information.
            richTextBox1.Lines = richTextBox1.Lines.OrderBy(a => a).ToArray();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // This will make the text in the list box lower case.
            richTextBox1.Text = richTextBox1.Text.ToLower();
        }

        private void button4_Click(object sender, EventArgs e)
        // This will find the longest word inside of the box.
        {
            // String array using the RTB for the text.
            string array = richTextBox1.Text;

            // How we will seperate each word
            string[] words = array.Split(new[] {" "}, StringSplitOptions.None);

            //  This will implement the longest word counter.
            string longest_word = "";
            int word_counter = 0;


            foreach (string s in words)
            {
                if (s.Length > word_counter)
                {
                    word_counter = s.Length;
                    longest_word = s;
                }
            }
            MessageBox.Show("The longest word is: " + longest_word.ToString() + Environment.NewLine, "Longest Word");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // This will tell and show the word with the most vowels.
            var input = richTextBox1.Text;

            // The vowels we are looking for.
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            // Here are the characters we don't want to include.
            char[] dont_want = { ' ', '.', ',', '!', '?', ':', ';', '(', ')', '\t' };

            // The foundation for the word we need.
            string word = "";

            // This will further specify how we will split the words and we will remove any empty space.
            string[] splitter_foundation = input.Split(dont_want, StringSplitOptions.RemoveEmptyEntries);

            // Vowel counter being initalized at 0.
            var mostVowels = 0;


            for (int i = 0; i < splitter_foundation.Length; i++)
            {
                var part = splitter_foundation[i];

                // Counter for the number of vowels inside of the word.
                var numVowels = 0;
                foreach (var vowel in vowels)
                {
                    if (part.Contains(vowel)) numVowels++;
                }

                if (mostVowels < numVowels)
                {
                    mostVowels = i;
                    word = part;
                }
            }
            MessageBox.Show("The word with the most vowels in it is: " + word.ToString(), "Most Vowels");
            return;
        }
    }
}
