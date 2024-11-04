using System;
using System.Windows.Forms;

namespace CrapsGame
{
    public partial class MainForm : Form
    {
        private decimal bankBalance = 100.00m; // Initial bank balance
        private int point = 0; // Variable to hold point value

        public MainForm()
        {
            InitializeComponent();
            lblDie1.Text = "";
            lblDie2.Text = "";
            lblBalance.Text = $"Balance: ${bankBalance:F2}";
            lblGameStatus.Text = "";
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            // Check if the bet is valid
            if (decimal.TryParse(txtBet.Text, out decimal betAmount) && betAmount > 0)
            {
                if (betAmount <= bankBalance)
                {
                    CalculateScore(betAmount);
                }
                else
                {
                    MessageBox.Show("Insufficient funds for this bet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid bet amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateScore(decimal betAmount)
        {
            // Generate two random numbers for the dice rolls
            Random random = new Random();
            int die1 = random.Next(1, 7);
            int die2 = random.Next(1, 7);
            int sum = die1 + die2;

            // Display the values of the dice
            lblDie1.Text = die1.ToString();
            lblDie2.Text = die2.ToString();

            // Determine the outcome
            switch (sum)
            {
                case 7:
                case 11:
                    lblGameStatus.Text = "You win!";
                    bankBalance += betAmount; // Add to bank balance
                    break;
                case 2:
                case 3:
                case 12:
                    lblGameStatus.Text = "You lose!";
                    bankBalance -= betAmount; // Subtract from bank balance
                    break;
                default:
                    if (point == 0) // If no point has been set yet
                    {
                        point = sum; // Set the point
                        lblGameStatus.Text = $"Point is {point}";
                    }
                    else if (sum == point)
                    {
                        lblGameStatus.Text = "You win!";
                        bankBalance += betAmount; // Add to bank balance
                        point = 0; // Reset point
                    }
                    else if (sum == 7)
                    {
                        lblGameStatus.Text = "You lose!";
                        bankBalance -= betAmount; // Subtract from bank balance
                        point = 0; // Reset point
                    }
                    break;
            }

            // Update the balance display
            lblBalance.Text = $"Balance: ${bankBalance:F2}";
        }
    }
}
