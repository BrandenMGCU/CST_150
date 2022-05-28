/* Branden M.
 * 05/27/22
 * CST-150 
 * Professor Mark Smithers
 * Grand Canyon University
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

namespace Activity_13_CST_150
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PlayButtons();
        }

        Button[,] GameSquares = new Button[3, 3];
        /* Features a 2D array for the buttons in
         * a 3 x 3 configuration to make 9 squares total
         * for the tic-tac-toe game.
         */

        private void PlayButtons()
        // This function will begin creating the buttons needed for the tic-tac-toe game to work. 
        {
            for (int a = 0; a < 3; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    GameSquares[a, b] = new Button();
                    // This will make the new buttons needed for the game.

                    GameSquares[a, b].Size = new Size(135, 135);
                    // This will set the size of the buttons needed for the game.

                    GameSquares[a, b].Location = new Point(a * 145, b * 145);
                    // This will tell where to place the buttons on the board.

                    GameSquares[a, b].FlatStyle = FlatStyle.Standard;
                    // For this tic-tac-toe game we want flat squares to be shown on the tic-tac-toe board.

                    GameSquares[a, b].Font = new System.Drawing.Font(DefaultFont.FontFamily, 86, FontStyle.Bold);
                    // This will set the font style for the X's and O's on the board.

                    GameSquares[a, b].Click += new EventHandler(ButtonAction);
                    // This will tell the board that the button can be called to be clicked when the game begins.

                    panel1.Controls.Add(GameSquares[a, b]);
                    // This will setup the board with the buttons needed to play the game.
                }
            }
            MessageBox.Show("Let's Begin!", "Showtime!");
            // Present a Welcome Message to the user!
        }

        private void ButtonAction (object sender, EventArgs e)
        {
            // Load the clicked button into a local variable
            Button button = sender as Button;

            // Don't do anything if the block is already marked
            if (button.Text != "")
            {
                return;
            }
            // Mark the block with current players icon.
            button.Text = button1.Text;

            // Utilize the players turn method when selecting a button.
            PlayersTurn();
        }

        private void PlayersTurn()
            // Here to control the Player's Turns.
        {
            GameOver();
            // Call the GameOver Function to check if there's a winner!

            if (button1.Text == "X")
                // Player X will go first.
            {
                button1.Text = "O";
                // Then Player O will go.
            }
            else
            {
                button1.Text = "X";
                // After Player O goes, then it returns back to Player X's Turn.
            }
        }

        private void GameOver()
        // Checking if a player has 3 in a row.
        {
            List<Button> WinningButtons = new List<Button>();

            #region // Vertical Check
            // Start of the Vertical Board Check.
            for (int a = 0; a < 3; a++)
            {
                WinningButtons = new List<Button>();
                for (int b = 0; b < 3; b++)
                {
                    if (GameSquares[a, b].Text != button1.Text)
                    {
                        break;
                    }

                    WinningButtons.Add(GameSquares[a, b]);
                    if (b == 2)
                    {
                        GameWinner(WinningButtons);
                        return;
                    }
                }
            }
            #endregion 
            //End of the Vertical Board Check.


            //Start of the Horizontal check for 3 X's or O's.
            #region // Horizontal Board Check 
            for (int a = 0; a < 3; a++)
            {
                WinningButtons = new List<Button>();
                for (int b = 0; b < 3; b++)
                {
                    if (GameSquares[b, a].Text != button1.Text)
                    {
                        break;
                    }

                    WinningButtons.Add(GameSquares[b, a]);
                    if (b == 2)
                    {
                        GameWinner(WinningButtons);
                        return;
                    }
                }
            }
            #endregion
            // The end of the Horizontal Board Check.

            // Start of Diagonal Board Check #1.
            #region// Diagonal Board Check # 1
            WinningButtons = new List<Button>();
            for (int a = 0, b = 0; a < 3; a++, b++)
            {
                if (GameSquares[a, b].Text != button1.Text)
                {
                    break;
                }

                WinningButtons.Add(GameSquares[a, b]);
                if (b == 2)
                {
                    GameWinner(WinningButtons);
                    return;
                }
            }
            #endregion
            // End of Diagonal Board Check #1.

            // Start of Diagonal Board Check #2.
            #region// Diagonal Board Check #2 
            WinningButtons = new List<Button>();
            for (int a = 2, b = 0; b < 3; a--, b++)
            {
                if (GameSquares[a, b].Text != button1.Text)
                {
                    break;
                }

                WinningButtons.Add(GameSquares[a, b]);
                if (b == 2)
                {
                    GameWinner(WinningButtons);
                    return;
                }
            }
            #endregion

            // Checking if the game box has already been used
            foreach (var button in GameSquares)
            {
                if (button.Text == "")
                    return;
            }

            // If the game ends in a draw the player(s) will have the choice to keep playing or not
            DialogResult dialogResult = MessageBox.Show("No one won!" + "\n" + "\n" + "Try Again?", "DRAW!", MessageBoxButtons.YesNo);

            // If the player selects the 'yes' button then the application will restart and be playable again.
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("REMATCH!", "Not so fast");
                Application.Restart();
            }

            // If the player selects the 'no' button then the application will quit.
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Hope you enjoyed!", "Goodbye");
                Application.Exit(); 
            }
        }


        private void GameWinner (List<Button> WinningButtons)
        {
            // color all the winner blocks
            foreach (var button in WinningButtons)
            {
                button.BackColor = Color.Orange;
                // Whoever wins the game will have their tiles highlighted in orange.

                button.ForeColor = Color.Blue;
                // Whoever wins the game will have their letters highlighted in blue.
            }


            MessageBox.Show("Player: " + button1.Text + " is the winner!"); 
            // This will display who won the game.

            DialogResult dialogResult = MessageBox.Show("Would you like to play again?", "Another?", MessageBoxButtons.YesNo);
            //The player's choice to play again or not.

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("REMATCH!", "Not so fast");
                Application.Restart(); 
                // If the player chooses yes then the game will restart and they can play again.
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Hope you enjoyed!", "Goodbye");
                Application.Exit(); 
                // If the player chooses no then the game will stop.
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I'm just here to keep the players in line!", "Easter Egg!");
            // This button will show visually who's turn it is, it will display either X or O.
        }
    }
}