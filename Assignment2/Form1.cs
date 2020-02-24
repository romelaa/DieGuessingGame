/// <sumary>
/// Romela Azizyan
/// CS 3280 - Assignment 2 Dice Roll
/// 
/// This program takes a user input and checks to see if the dice rolled matches to the input value.
/// 
/// </sumary>


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        #region Attributes
        /// <summary>
        ///  the number that the user entered in the textbox
        /// </summary>
        private int guess = 0;

        /// <summary>
        /// tracks number of times lost
        /// </summary>
        private int timesLost = 0;
        /// <summary>
        /// tracks number of times played
        /// </summary>
        private int timesPlayed = 0;

        /// <summary>
        /// tracks number of times won
        /// </summary>
        private int timesWon = 0;

        /// <summary>
        /// number of times user chose 1
        /// </summary>
        private int userchoice1 = 0;

        /// <summary>
        /// number of times user chose 2
        /// </summary>
        private int userchoice2 = 0;

        /// <summary>
        /// number of times user chose 3
        /// </summary>
        private int userchoice3 = 0;

        /// <summary>
        /// number of times user chose 4
        /// </summary>
        private int userchoice4 = 0;

        /// <summary>
        /// number of times user chose 5
        /// </summary>
        private int userchoice5 = 0;

        /// <summary>
        /// number of times user chose 6
        /// </summary>
        private int userchoice6 = 0;
        
        /// <summary>
        /// stores the random number of the die
        /// </summary>
        private int randomdie = 0;

        /// <summary>
        /// number of times the correct number was 1
        /// </summary>
        private int countFace1 = 0;

        /// <summary>
        /// number of times the correct number was 2
        /// </summary>
        private int countFace2 = 0;

        /// <summary>
        /// number of times the correct number was 3
        /// </summary>
        private int countFace3 = 0;

        /// <summary>
        /// number of times the correct number was 4
        /// </summary>
        private int countFace4 = 0;

        /// <summary>
        /// number of times the correct number was 5
        /// </summary>
        private int countFace5 = 0;

        /// <summary>
        /// number of times the correct number was 6
        /// </summary>
        private int countFace6 = 0;
        #endregion

        public Form1()
        {
            InitializeComponent();
            dataGrid.Rows.Add(6); //six rows in the data grid of the form
            dataGrid.Columns[2].DefaultCellStyle.Format = "0.00,%";
            lblLost.Text = "0";
            lblPlayed.Text = "0";
            lblWon.Text = "0";
            warningLbl.Visible = false;
        }

        /// <summary>
        /// when the button Roll is clicked the game starts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRoll_Click(object sender, EventArgs e)
        {
            dicePB.SizeMode = PictureBoxSizeMode.StretchImage;
            Random randomNum = new Random();
            Int32.TryParse(guessBox.Text, out guess);
            warningLbl.Visible = false;
            
            if (guess < 1 || guess > 6) // if the guess is less than 1 or greater than 6
            {
                warningLbl.Text = "Invalid input. You must enter a number between 1 through 6";
                warningLbl.Visible = true;
                warningLbl.Refresh();
            }
            else if (string.IsNullOrWhiteSpace(guessBox.Text)) // if no value was entered in the textbox
            {
                warningLbl.Text = "Invalid input. You must enter a number between 1 through 6";
                warningLbl.Visible = true;
                warningLbl.Refresh();
            }

            else { // if the guess is in between 1 and 6 check if the number matches or doesn't

                for (int i = 1; i < 10; i++) // cycles through the random numbers 9 times
                    {
                        randomdie = randomNum.Next(1, 7);
                        warningLbl.Visible = true;
                        // randomly choosing an image
                        dicePB.Image = Image.FromFile("die" + randomdie.ToString() + ".gif");
                        // refreshing the image
                        dicePB.Refresh();
                        // sleep thread - slows down the pace of changing images for the illusion of a dice roll
                        Thread.Sleep(200);

                    if (i == 9) // when the 9th random number is picked check if the guess is correct or not
                    {
                        // keeps track of the count user chose one of the 6 faces
                        // these numbers are later stored in an array to display the number of times guessed column
                        if (guess == 1)
                        {
                            userchoice1++;
                        }
                        else if (guess == 2)
                        {
                            userchoice2++;
                        }
                        else if (guess == 3)
                        {
                            userchoice3++;
                        }
                        else if (guess == 4)
                        {
                            userchoice4++;
                        }
                        else if (guess == 5)
                        {
                            userchoice5++;
                        }
                        else if (guess == 6) {
                            userchoice6++;
                        }
                        
                        // if the guess matches the number then number of times won and the number of times played increment by one
                        if (guess == randomdie)
                        {
                            timesWon++;
                            lblWon.Text = timesWon.ToString();
                            timesPlayed++;
                            lblPlayed.Text = timesPlayed.ToString();
                            warningLbl.Visible = true;
                            warningLbl.Text = "Congratulations you guessed the number " + randomdie + ".";
                        }
                        else //if the guess does not match then the number of times lost and the number of times played increment by one
                        {
                            timesLost++;
                            lblLost.Text = timesLost.ToString();
                            timesPlayed++;
                            lblPlayed.Text = timesPlayed.ToString();
                            warningLbl.Visible = true;
                            warningLbl.Text = "You did not guess this time, try again.";
                        }
                        // adds 1 to count each time one of the cases is "true" (meaning one of the cases is the correct answer)
                        // these numbers are later stored in an array to display the frequencies
                        if (randomdie == 1) {
                            countFace1++;
                        }
                        else if (randomdie == 2)
                        {
                            countFace2++;
                        }
                        else if (randomdie == 3)
                        {
                            countFace3++;
                        }
                        else if (randomdie == 4)
                        {
                            countFace4++;
                        }
                        else if (randomdie == 5)
                        {
                            countFace5++;
                        }
                        else if (randomdie == 6)
                        {
                            countFace6++;
                        }
                    }

                }

                // sets the row values accordingly
                // referenced https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview.rows?view=netframework-4.8
                for (int i = 0; i < 6; i++)
                {
                    int[] countfaces = { countFace1, countFace2, countFace3, countFace4, countFace5, countFace6 };
                    int[] userGuesses = { userchoice1, userchoice2, userchoice3, userchoice4, userchoice5, userchoice6 };
                    dataGrid.Rows[i].Cells[0].Value = i+1; // lists 1-6 in the face column
                    dataGrid.Rows[i].Cells[1].Value = countfaces[i]; // lists the number of times the die was rolled on a number
                    dataGrid.Rows[i].Cells[2].Value = (float)(countfaces[i] / (float)timesPlayed); // Counts the percentage
                    dataGrid.Rows[i].Cells[3].Value = userGuesses[i]; // lists the number of times user chose the specific number
                }

                dataGrid.Refresh();

            }
        }
        
        /// <summary>
        /// when the button Reset is clicked the form resets
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            //resets the number of times played, won, frequencies, and number of times guessed
            // dataGrid.Rows.Clear(); // this actually clears all the data from the data grid so the reset button doesn't work properly
            // this.dataGrid.Refresh();
            timesLost = 0;
            lblLost.Text = timesLost.ToString();
            timesPlayed = 0;
            lblPlayed.Text = timesPlayed.ToString();
            timesWon = 0;
            lblWon.Text = timesWon.ToString();
           

        }
    }
}
