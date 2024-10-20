using System;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class Form1 : Form
    {
        private char currentPlayer;
        private Button[,] buttons; // 2D array for buttons

        public Form1()
        {
            InitializeComponent();
            currentPlayer = 'X'; // Start with player X
            buttons = new Button[3, 3]
            {
                { btn1, btn2, btn3 },
                { btn4, btn5, btn6 },
                { btn7, btn8, btn9 }
            };
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            // Check if the button is already clicked
            if (clickedButton.Text != "")
            {
                MessageBox.Show("This spot is already taken!");
                return;
            }

            // Update the button text with the current player's symbol
            clickedButton.Text = currentPlayer.ToString();
            clickedButton.Enabled = false;

            // Check for a win or a draw
            if (CheckWin())
            {
                MessageBox.Show($"Player {currentPlayer} wins!");
                ResetGame();
            }
            else if (CheckDraw())
            {
                MessageBox.Show("It's a draw!");
                ResetGame();
            }
            else
            {
                // Switch player
                currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
                lblStatus.Text = $"Player {currentPlayer}'s turn";
            }
        }

        private bool CheckWin()
        {
            // Check rows, columns, and diagonals for a win
            for (int i = 0; i < 3; i++)
            {
                if (buttons[i, 0].Text == currentPlayer.ToString() &&
                    buttons[i, 1].Text == currentPlayer.ToString() &&
                    buttons[i, 2].Text == currentPlayer.ToString())
                {
                    return true; // Row win
                }
                if (buttons[0, i].Text == currentPlayer.ToString() &&
                    buttons[1, i].Text == currentPlayer.ToString() &&
                    buttons[2, i].Text == currentPlayer.ToString())
                {
                    return true; // Column win
                }
            }

            // Check diagonals
            if (buttons[0, 0].Text == currentPlayer.ToString() &&
                buttons[1, 1].Text == currentPlayer.ToString() &&
                buttons[2, 2].Text == currentPlayer.ToString())
            {
                return true; // Diagonal win
            }

            if (buttons[0, 2].Text == currentPlayer.ToString() &&
                buttons[1, 1].Text == currentPlayer.ToString() &&
                buttons[2, 0].Text == currentPlayer.ToString())
            {
                return true; // Diagonal win
            }

            return false; // No win
        }

        private bool CheckDraw()
        {
            foreach (Button button in buttons)
            {
                if (button.Text == "")
                {
                    return false; // If any button is empty, it's not a draw
                }
            }
            return true; // All buttons are filled
        }

        private void ResetGame()
        {
            foreach (Button button in buttons)
            {
                button.Text = "";
                button.Enabled = true;
            }
            currentPlayer = 'X';
            lblStatus.Text = $"Player {currentPlayer}'s turn";
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
