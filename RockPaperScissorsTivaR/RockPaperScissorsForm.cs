using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Created by: Tiva Rait
 * Created on: 26-03-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #17 - Rock, Paper, Scissors
 * This is a game of Rock Paper Scissors
*/

namespace RockPaperScissorsTivaR
{
    public partial class frmRockPaperScissors : Form
    {
        // Global Variables and Constants are declared here
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 3;
        Random randomNumberGenerator;

        public frmRockPaperScissors()
        {
            InitializeComponent();

            // Creating Random Number Object
            randomNumberGenerator = new Random();
        }

        private void lblPlay_Click(object sender, EventArgs e)
        {
            //Declaring local variables and constants
            int playerChoice, computerChoice;
            const int rock = 1;
            const int paper = 2;
            const int scissors = 3;

            // get the user's selection if no selection set to 0
            if (radRockP.Checked == true) 
            {
                playerChoice = rock;
            } 
            else if (radPaperP.Checked == true) 
            {
                playerChoice = paper;
            }
            else if (radScissorsP.Checked == true)
            {
                playerChoice = scissors;
            }
            else 
            {
                playerChoice = 0;
            }

            // Generate the computers choice randomly
            computerChoice = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);

            // Set Radio Button for the Computers choice
            if (computerChoice == rock)
            {
                this.radRockC.Checked = true;
            }
            else if (computerChoice == paper) ;
            {

            }

           

        }
    }
}
