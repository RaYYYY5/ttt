namespace TicTacToetest1
{
    public partial class Form1 : Form
    {

        public enum Player
        {
            X, O
        }

        Player currentPlayer;
        Random random = new Random();
        int playerWinCount = 0;
        int computerWinCount = 0;
        int tieCount = 0;
        List<Button> buttons;
        private string playerName;

        public Form1()
        {
            InitializeComponent();
            NewGame();

        }



        private void PlayClickButton(object sender, EventArgs e)
        {
            var button = (Button)sender;

            currentPlayer = Player.X;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = Color.White;
            buttons.Remove(button);
            CheckGame();
            GameTimer.Start();

        }

        private void ComputerMove(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = random.Next(buttons.Count);
                buttons[index].Enabled = false;
                currentPlayer = Player.O;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].BackColor = Color.White;
                buttons.RemoveAt(index);
                CheckGame();
                GameTimer.Stop();
            }
        }

        private void NewGame(object sender, EventArgs e)
        {
            NewGame();
        }

        private void CheckGame()
        {

            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
                || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
                || button7.Text == "X" && button8.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
                || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
                || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
                || button3.Text == "X" && button5.Text == "X" && button7.Text == "X"
                )
            {
                GameTimer.Stop();
                playerWinCount++;
                winnerAnnounceLabel.Text = $"{playerName} Wins!!!";
                label1.Text = $"{playerName} Wins: " + playerWinCount;
                NewGame();

            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
                || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
                || button7.Text == "O" && button8.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
                || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
                || button3.Text == "O" && button5.Text == "O" && button7.Text == "O"
                )
            {
                GameTimer.Stop();
                computerWinCount++;
                winnerAnnounceLabel.Text = "Computer Win :(";
                label2.Text = "Computer Wins: " + computerWinCount;
                NewGame();
            }
            else if (buttons.Count == 0)
            {
                GameTimer.Stop();
                winnerAnnounceLabel.Text = "It's a tie";
                tieCount++;
                label3.Text = "Tie: " + tieCount;
                NewGame();
            }

        }

        private void NewGame()
        {
            buttons = new List<Button> { button1, button2, button3, button4,
            button5, button6, button7,  button8, button9 };

            foreach (Button x in buttons)
            {
                x.Enabled = true;
                x.Text = "?";
                x.BackColor = DefaultBackColor;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Get the name from TextBox
            if (!string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                playerName = nameTextBox.Text;
            }
            else
            {
                playerName = "Player"; // Default name if not exist
            }

            // Display the greeting message with name on form
            greetingLabel.Text = ($"Welcome, {playerName}! Let's play Tic Tac Toe!");
            label1.Text = $"{playerName} Wins:  ";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Closes the form
        }
    }
}

