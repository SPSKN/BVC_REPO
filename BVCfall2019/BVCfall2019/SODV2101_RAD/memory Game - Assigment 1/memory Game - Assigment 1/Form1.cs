using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memory_Game___Assigment_1
{
    /*
     The Memory Game
     Scott Patterson
     2019-10-2
     */
    public partial class Form1 : Form
    {
        //********************** Global Variables *******************************

        int cardNumber = 0; // the cardNumber
        int newcardNumber = 0; // another variable for cards
        int[] DeckOfCards = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }; // The 
        public bool doMatch = false; // For matching the 'cards'

        //******************** Game Class *****************************************
        public class Game
        {
            
            int Turns = 1; // This keeps track of the TURNS it takes to finish
            public void nextTurn()
            {
                Turns++;
            }
        }
        //********************** Cards Class ***************************************
        public class Cards
        {
            int totalSets = 10; // the total number of Card sets
            int totalRevealed = 0; // Counter for Revealed sets

            public void revealedCard(bool doMatch)
            {
                //Takes the doMatch
                //If the cards match, track the total sets of revealed cards

                if (doMatch != false)
                {
                    totalRevealed++;
                    if (totalRevealed == totalSets)// check for win
                    {
                        // Player wins
                    }
                    else
                    {
                        //
                    }
                }
                else
                {
                    //
                }
            }
        }

        //*************************** Players Class **********************************

        public class Players
        {
            //player class
            string Name; // Name is entered by Player
            int Score; // Keep score


            public Players(string name)//constructer
            {
                if(name.Length != 0) // checks to make sure its not empty
                {
                    Name = name;
                    Score = 0;
                }else // if empty
                {
                    Name = "Player";
                    Score = 0;
                }
            }
            public string showName() // to show the Players Name
            {
                return this.Name;
            }
            public int showScore() // to show the Players Score
            {
                return this.Score;
            }
            public void addPoints(bool doMatch) // to add points OR minus points depending on if the 'Cards' 'Matched'
            {
                // To add Points to the players score
                if (doMatch != false) // if its true
                {
                    Score += 50; // add 50 points to the players score
                    doMatch = false; // set the value back to false for the new round
                }
                else
                { Score -= 10; } // Else 
            }
        }
        //*********************** Form1 & Event Handlers **************************************
        public Form1()
        {
            InitializeComponent();
        }
            /*
            *****************************
            ***************************** 
            Put all the Events Down Here
            *****************************
            *****************************
             */
        private void Form1_Load(object sender, EventArgs e)
        {
            // Ignore this part here
            // Im too afraid to remove this
            // Bad things happen

            foreach (int number in DeckOfCards)
            {
                testBox.Text = testBox.Text += number.ToString(); // testing
            }


        }
        
        //*********************** ButtonEvents ******************************************
        private void ButtonEvents(object sender, EventArgs e)
        {
            //It will Reveal the Number of the button pressed
            //It will check if the other button matches the first button
            //return a FALSE if not match or TRUE if match
            //nextTurn() is called to change the turn
            Button ButtonEvents = (Button)sender;   //This is the event everytime the button is press
            int tableIndex = ButtonEvents.TabIndex; // the  this is the index of the buttons ** will be used to map the DeckOfCards[] **
           // ButtonEvents.BackColor("ActiveCaptionText");
            // ButtonEvents.Text = tableIndex.ToString();
            // cardNumber = tableIndex + 1;
            //ButtonEvents.Text = cardNumber.ToString();
            cardNumber = tableIndex + 1;
            if(tableIndex + 1 < 10)
            {
                testBox.Text = cardNumber.ToString();
            }else
            {             
                switch(cardNumber)
                {
                    // to make the matching set :)
                    case 11: newcardNumber = 1; break;
                    case 12: newcardNumber = 2; break;
                    case 13: newcardNumber = 3; break;
                    case 14: newcardNumber = 4; break;
                    case 15: newcardNumber = 5; break;
                    case 16: newcardNumber = 6; break;
                    case 17: newcardNumber = 7; break;
                    case 18: newcardNumber = 8; break;
                    case 19: newcardNumber = 9; break;
                    case 20: newcardNumber = 10; break;

                    default: break;

                }                
                testBox.Text = newcardNumber.ToString();
            }
           // testBox.Text = testBox.Text + " " +  ButtonEvents.Text; // testing
        }
        //*********************** Testing ******************************************
        private void Label1_Click(object sender, EventArgs e)
        {
            Players P1 = new Players("");
            testBox.Text = testBox.Text + " " + P1.showName();
        }
        //End of the Line
    }
}
