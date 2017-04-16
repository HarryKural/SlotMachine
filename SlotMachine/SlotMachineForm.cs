using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace SlotMachine
{
    public partial class SlotMachineForm : Form
    {
        private int playerMoney = 1000;
        private int winnings = 0;
        private int jackpot = 5000;
        private float turn = 0.0f;
        private int playerBet = 10;
        private float winNumber = 0.0f;
        private float lossNumber = 0.0f;
        private string[] spinResult;
        private string fruits = "";
        private float winRatio = 0.0f;
        private float lossRatio = 0.0f;
        private int grapes = 0;
        private int bananas = 0;
        private int oranges = 0;
        private int cherries = 0;
        private int bars = 0;
        private int bells = 0;
        private int sevens = 0;
        private int blanks = 0;

        private Random random = new Random();

        public SlotMachineForm()
        {
            InitializeComponent();
        }
        
        /* Utility function to show Player Stats */
        private void showPlayerStats()
        {
            winRatio = winNumber / turn;
            lossRatio = lossNumber / turn;
            string stats = "";
            stats += ("Jackpot: " + jackpot + "\n");
            stats += ("Player Money: " + playerMoney + "\n");
            stats += ("Turn: " + turn + "\n");
            stats += ("Wins: " + winNumber + "\n");
            stats += ("Losses: " + lossNumber + "\n");
            stats += ("Win Ratio: " + (winRatio * 100) + "%\n");
            stats += ("Loss Ratio: " + (lossRatio * 100) + "%\n");
            MessageBox.Show(stats, "Player Stats");
        }
        
        /* Utility function to reset all fruit tallies*/
        private void resetFruitTally()
        {
            grapes = 0;
            bananas = 0;
            oranges = 0;
            cherries = 0;
            bars = 0;
            bells = 0;
            sevens = 0;
            blanks = 0;
        }

        /* Utility function to reset the player stats */
        private void resetAll()
        {
            playerMoney = 1000;
            winnings = 0;
            jackpot = 5000;
            turn = 0;
            playerBet = 10;
            winNumber = 0;
            lossNumber = 0;
            winRatio = 0.0f;

            // reset textBox
            WinnerPaidTextBox.Text = null;
            BetTextBox.Text = playerBet.ToString();
            TotalCreditsTextBox.Text = playerMoney.ToString();
            JackpotTextBox.Text = jackpot.ToString();

            // reset the Reel pictureboxes
            ReelFirstPictureBox.Image = Properties.Resources.blank;
            ReelSecondPictureBox.Image = Properties.Resources.blank;
            ReelThirdPictureBox.Image = Properties.Resources.blank;
        }

        /* Check to see if the player won the jackpot */
        private void checkJackPot()
        {
            /* compare two random values */
            var jackPotTry = this.random.Next(51) + 1;
            var jackPotWin = this.random.Next(51) + 1;
            if (jackPotTry == jackPotWin)
            {
                MessageBox.Show("You Won the $" + jackpot + " Jackpot!!", "Jackpot!!");
                playerMoney += jackpot;
                jackpot = 1000;
                // set the text of jackpot textBox
                JackpotTextBox.Text = jackpot.ToString();
            }
        }

        /* Utility function to show a win message and increase player money */
        private void showWinMessage()
        {
            playerMoney += winnings;
            WinnerPaidTextBox.Text = "$ " + winnings;
         // MessageBox.Show("You Won: $" + winnings, "Winner!");
            resetFruitTally();
            checkJackPot();
        }

        /* Utility function to show a loss message and reduce player money */
        private void showLossMessage()
        {
            playerMoney -= playerBet;
            WinnerPaidTextBox.Text = "You Lost!";
         // MessageBox.Show("You Lost!", "Loss!");
            resetFruitTally();
        }

        /* Utility function to check if a value falls within a range of bounds */
        private bool checkRange(int value, int lowerBounds, int upperBounds)
        {
            return (value >= lowerBounds && value <= upperBounds) ? true : false;

        }

        /* When this function is called it determines the betLine results.
            e.g. Bar - Orange - Banana */
        private string[] Reels()
        {
            string[] betLine = { " ", " ", " " };
            int[] outCome = { 0, 0, 0 };

            // create array of PictureBox to popluate them
            PictureBox[] setReel = new PictureBox[] { ReelFirstPictureBox, ReelSecondPictureBox, ReelThirdPictureBox };

            for (var spin = 0; spin < 3; spin++)
            {
                outCome[spin] = this.random.Next(65) + 1;

                if (checkRange(outCome[spin], 1, 27))
                {  // 41.5% probability
                    betLine[spin] = "blank";
                    setReel[spin].Image = Properties.Resources.blank;
                    blanks++;
                }
                else if (checkRange(outCome[spin], 28, 37))
                { // 15.4% probability
                    betLine[spin] = "Grapes";
                    setReel[spin].Image = Properties.Resources.grapes;
                    grapes++;
                }
                else if (checkRange(outCome[spin], 38, 46))
                { // 13.8% probability
                    betLine[spin] = "Banana";
                    setReel[spin].Image = Properties.Resources.banana;
                    bananas++;
                }
                else if (checkRange(outCome[spin], 47, 54))
                { // 12.3% probability
                    betLine[spin] = "Orange";
                    setReel[spin].Image = Properties.Resources.orange;
                    oranges++;
                }
                else if (checkRange(outCome[spin], 55, 59))
                { //  7.7% probability
                    betLine[spin] = "Cherry";
                    setReel[spin].Image = Properties.Resources.cherry;
                    cherries++;
                }
                else if (checkRange(outCome[spin], 60, 62))
                { //  4.6% probability
                    betLine[spin] = "Bar";
                    setReel[spin].Image = Properties.Resources.bar;
                    bars++;
                }
                else if (checkRange(outCome[spin], 63, 64))
                { //  3.1% probability
                    betLine[spin] = "Bell";
                    setReel[spin].Image = Properties.Resources.bell;
                    bells++;
                }
                else if (checkRange(outCome[spin], 65, 65))
                { //  1.5% probability
                    betLine[spin] = "Seven";
                    setReel[spin].Image = Properties.Resources.seven;
                    sevens++;
                }

            }
            return betLine;
        }

        /* This function calculates the player's winnings, if any */
        private void determineWinnings()
        {
            if (blanks == 0)
            {
                if (grapes == 3)
                {
                    winnings = playerBet * 10;
                }
                else if (bananas == 3)
                {
                    winnings = playerBet * 20;
                }
                else if (oranges == 3)
                {
                    winnings = playerBet * 30;
                }
                else if (cherries == 3)
                {
                    winnings = playerBet * 40;
                }
                else if (bars == 3)
                {
                    winnings = playerBet * 50;
                }
                else if (bells == 3)
                {
                    winnings = playerBet * 75;
                }
                else if (sevens == 3)
                {
                    winnings = playerBet * 100;
                }
                else if (grapes == 2)
                {
                    winnings = playerBet * 2;
                }
                else if (bananas == 2)
                {
                    winnings = playerBet * 2;
                }
                else if (oranges == 2)
                {
                    winnings = playerBet * 3;
                }
                else if (cherries == 2)
                {
                    winnings = playerBet * 4;
                }
                else if (bars == 2)
                {
                    winnings = playerBet * 5;
                }
                else if (bells == 2)
                {
                    winnings = playerBet * 10;
                }
                else if (sevens == 2)
                {
                    winnings = playerBet * 20;
                }
                else if (sevens == 1)
                {
                    winnings = playerBet * 5;
                }
                else
                {
                    winnings = playerBet * 1;
                }
                winNumber++;
                showWinMessage();
            }
            else
            {
                lossNumber++;
                showLossMessage();
            }
        }

        private void _pictureBoxButtonHandler(object sender, EventArgs e)
        {
            PictureBox PictureClickHandler = sender as PictureBox;

            switch (PictureClickHandler.Tag.ToString())
            {
                case "Spin":

                    if (playerMoney == 0)
                    {
                        if (MessageBox.Show("You ran out of Money! \nDo you want to play again?", "Out of Money!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            resetAll();
                            showPlayerStats();
                        }
                    }
                    else if (playerBet > playerMoney)
                    {
                        MessageBox.Show("You don't have enough Money to place that bet.", "Insufficient Funds");
                    }
                    else if (playerBet <= 0)
                    {
                        MessageBox.Show("All bets must be a positive $ amount.", "Incorrect Bet");
                    }
                    else if (playerBet <= playerMoney)
                    {
                        spinResult = Reels();
                        determineWinnings();
                        turn++;
                        TotalCreditsTextBox.Text = playerMoney.ToString();
                        // fruits = spinResult[0] + " - " + spinResult[1] + " - " + spinResult[2];
                        // MessageBox.Show(fruits);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid bet amount");
                    }
                    break;
                
                case "Reset":
                    // showing up confirm message when reset (picture) button clicked
                    DialogResult reset = MessageBox.Show("Are You Sure you want to reset the game?" + Environment.NewLine + "Your current progress will be lost." , "Reset the Game", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    // Closes the program if OK clicked
                    if (reset == DialogResult.OK)
                    {
                        resetAll();
                    }
                    break;
                
                case "Power":
                    // showing up confirm message when power (picture) button clicked
                    DialogResult exit = MessageBox.Show("Are You Sure you want to exit the game?", "Exit the game", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    // Closes the program if OK clicked
                    if (exit == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                    break;
            }
        }
        
        private void _buttonHandler(object sender, EventArgs e)
        {
            Button ButtonClickHandler = sender as Button;

            switch (ButtonClickHandler.Tag.ToString())
            {
                case "Player Stats":
                    showPlayerStats();
                    break;

                case "Reset Bet":
                    playerBet = 0;
                    BetTextBox.Text = playerBet.ToString();
                    break;
            }
        }

        private void _betHandler(object sender, EventArgs e)
        {
            PictureBox PlaceBet = sender as PictureBox;

            playerBet = Int16.Parse(PlaceBet.Tag.ToString());
            
            BetTextBox.Text = playerBet.ToString();
        }

        private void SlotMachineForm_Load(object sender, EventArgs e)
        {
            // display text in jackpot & credits textBoxes
            JackpotTextBox.Text = jackpot.ToString();
            TotalCreditsTextBox.Text = playerMoney.ToString();
            BetTextBox.Text = playerBet.ToString();

            // set the Reel pictureboxes as BLANK image
            ReelFirstPictureBox.Image = Properties.Resources.blank;
            ReelSecondPictureBox.Image = Properties.Resources.blank;
            ReelThirdPictureBox.Image = Properties.Resources.blank;
        }
    }
}
