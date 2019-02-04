using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace BoxGame
{
    public partial class GameForm : Form
    {
        // Constant Values
        public const int gameBoardHeight = 10;
        public const int gameBoardWidth = 10;

        // Global Varibles
        int tickCounter = 1;
        int sameGenCounter = 0;

        // Box Related Globals
        Boolean play = true;

        int currentXPos = 0;
        int currentYPos = 0;
        int currentBoxType = 0;
        int nextBoxType = 0;

        // Belt Realated Globals
        int currentBeltXPos = 0;

        // User Click Cords
        int userX;
        int userY;

        // Create an array of buttons
        Button[,] btn = new Button[gameBoardHeight, gameBoardWidth];

        public GameForm()
        {
            InitializeComponent();

            for (int x = 0; x < btn.GetLength(0); x++)
            {
                for (int y = 0; y < btn.GetLength(1); y++)
                {
                    // Create button in array posistion [x,y]
                    btn[x, y] = new Button();

                    // Set the size of the button and the link the event handler
                    btn[x, y].SetBounds(57 * x, 57 * y, 60, 60);
                    btn[x, y].Click += new EventHandler(this.btnEvent_Click);

                    // Set the image background of the button
                    btn[x, y].BackgroundImage = BoxGame.Properties.Resources.emptyslot;
                    btn[x, y].BackgroundImageLayout = ImageLayout.Stretch;
                    btn[x, y].Tag = "empty";
                    btn[x, y].Name = "X: " + x + " " + "Y: " + y;
                    
                    // Add the button to the form
                    Controls.Add(btn[x, y]);
                }
            }
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            for (int x = 0; x < gameBoardWidth; x++)
            {
                for (int y = 0; y < 2; y++)
                {
                    btn[x, y].BackgroundImage = BoxGame.Properties.Resources.emptyempty;
                }
            }

            btn[currentBeltXPos, 0].BackgroundImage = BoxGame.Properties.Resources.startbelt;
            btn[currentBeltXPos, 1].BackgroundImage = BoxGame.Properties.Resources.emptybelt_;

            GenerateNextBox();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
        // The following three lines were taken from StackOverflow on the 03/02/2019. 
        //The Line Placing X & Y to string to be parsed was also taken. Total of 4 lines
        https://stackoverflow.com/questions/14172617/prind-index-of-2d-array-using-the-click-event

            Button ButtonToIndex = (Button)sender;
            userX = int.Parse(ButtonToIndex.Name.Split()[1]);
            userY = int.Parse(ButtonToIndex.Name.Split()[3]);

            PrimaryTimer.Start();

            CreateBelt();
        }

        private void PrimaryTimer_Tick(object sender, EventArgs e)
        {
            // Add one to the tick counter
            tickCounter += 1;

            // If this is the first tick, spawn a random box type on the board
            if (tickCounter < 2)
            {
                SpawnBox();
                GenerateNextBox();
            }

            // This is not the first tick so we treat it like an already spawned game object
            else
            {
                CreateBelt();

                // If the box is going to stay in the array bounds we can move it
                if (currentYPos != (gameBoardHeight - 1))
                {
                    CheckPos();
                }

                // We need to stop now or we will leave the array bounds
                else
                {
                    tickCounter = 0;
                }
            }
        }

        private void GenerateNextBox()
        {
            // Store the last box type
            int oldBoxType = currentBoxType;

            // Generate random box type
            Random rnd = new Random();
            nextBoxType = rnd.Next(1, 4);

            if (nextBoxType == oldBoxType)
            {
                sameGenCounter++;
            }

            while(sameGenCounter >= 3 && nextBoxType == oldBoxType)
            {
                nextBoxType = rnd.Next(1, 4);

                if(nextBoxType != oldBoxType)
                {
                    sameGenCounter = 0;
                }
            }

            
        }

        private void SpawnBox()
        {
            // Box Type 1 - Spawn Prime Box
            if (nextBoxType == 1)
            {
                // Spawn a new box (Change the image of an existing button)
                btn[userX, 2].BackgroundImage = BoxGame.Properties.Resources.primebox;
                btn[nextBoxType, 2].Tag = "prime";
                currentBoxType = 1;
            }

            // Box Type 2 - Spawn UPS Box
            if (nextBoxType == 2)
            {
                // Spawn a new box (Change the image of an existing button)
                btn[userX, 2].BackgroundImage = BoxGame.Properties.Resources.upsbox;
                btn[nextBoxType, 2].Tag = "ups";
                currentBoxType = 2;
            }

            // Box Type 3 - Spawn fedEx Box
            if (nextBoxType == 3)
            {
                // Spawn a new box (Change the image of an existing button)
                btn[userX, 2].BackgroundImage = BoxGame.Properties.Resources.fedexbox;
                btn[nextBoxType, 2].Tag = "fedex";
                currentBoxType = 3;
            }

            // Set the last xPos to be the new spawn value
            currentXPos = (userX);
            currentYPos = 2;
        }

        private void CreateBelt()
        {
            btn[currentBeltXPos, 1].BackgroundImage = BoxGame.Properties.Resources.emptyempty;
            btn[currentBeltXPos, 0].BackgroundImage = BoxGame.Properties.Resources.emptyempty;

            currentBeltXPos = userX;

            if (nextBoxType == 1)
            {
                btn[currentBeltXPos, 0].BackgroundImage = BoxGame.Properties.Resources.startbelt;
                btn[currentBeltXPos, 1].BackgroundImage = BoxGame.Properties.Resources.primeonbelt;
            }

            if (nextBoxType == 2)
            {
                btn[currentBeltXPos, 0].BackgroundImage = BoxGame.Properties.Resources.startbelt;
                btn[currentBeltXPos, 1].BackgroundImage = BoxGame.Properties.Resources.upsonbelt;
            }

            if (nextBoxType == 3)
            {
                btn[currentBeltXPos, 0].BackgroundImage = BoxGame.Properties.Resources.startbelt;
                btn[currentBeltXPos, 1].BackgroundImage = BoxGame.Properties.Resources.fedonbelt;
            }
        }

        private void MoveBoxDown()
        {
            // Set the previous box to be empty
            btn[currentXPos, currentYPos].BackgroundImage = BoxGame.Properties.Resources.emptyslot;
            btn[currentXPos, currentYPos].Tag = "empty";

            // Increase the last position by one to represent downwards movement
            currentYPos += 1;

            // Box Type 1 - Spawn Prime Box
            if (currentBoxType == 1)
            {
                // Spawn a new box (Change the image of an existing button)
                btn[currentXPos, currentYPos].BackgroundImage = BoxGame.Properties.Resources.primebox;
                btn[currentXPos, currentYPos].Tag = "prime";
            }

            // Box Type 2 - Spawn UPS Box
            if (currentBoxType == 2)
            {
                // Spawn a new box (Change the image of an existing button)
                btn[currentXPos, currentYPos].BackgroundImage = BoxGame.Properties.Resources.upsbox;
                btn[currentXPos, currentYPos].Tag = "ups";
            }

            // Box Type 3 - Spawn fedEx Box
            if (currentBoxType == 3)
            {
                // Spawn a new box (Change the image of an existing button)
                btn[currentXPos, currentYPos].BackgroundImage = BoxGame.Properties.Resources.fedexbox;
                btn[currentXPos, currentYPos].Tag = "fedex";
            }
        }

        private void CheckPos()
        {
            // Before we can move the box down we need to check the lower box
            int belowBox = currentYPos;
            belowBox += 1;

            // We shall store the lower box type in this string
            string lowerBoxType = (string)btn[currentXPos, belowBox].Tag;

            // Before we move the box lets check its local area for things that might stop it
            if (lowerBoxType == "prime" || lowerBoxType == "ups" || lowerBoxType == "fedex")
            {
                CheckVertical();
                tickCounter = 0;
            }
            else
            {
                MoveBoxDown();
            }
        }

        private void CheckVertical()
        {
            int comboCount = 0;

            Console.WriteLine("Check performed");

            // Check box below current box
            int boxChecker = currentYPos;

            for(int x = 1; x == 3; x++)
            {
                boxChecker = +1;
                Console.WriteLine("Loop Run");
                Console.WriteLine(currentBoxType);
                // Store that box type
                string boxType = (string)btn[currentXPos, boxChecker].Tag;

                if (boxType == "prime" && currentBoxType == 1)
                {
                    Console.WriteLine("Match Prime");
                    comboCount += 1;
                }
                if (boxType == "ups" && currentBoxType == 2)
                {
                    Console.WriteLine("Match Ups");
                    comboCount += 1;
                }
                if (boxType == "fedex" && currentBoxType == 3)
                {
                    Console.WriteLine("Match Fedexs");
                    comboCount += 1;
                }
            }

            if(comboCount == 2)
            {
                Console.WriteLine("Combo");
            }
        }

        private void CheckHorizontal()
        {

        }

        private void HoldMyBeer()
        {
            // Before we can move the box down we need to check the lower box
            int belowBox = currentYPos;
            belowBox += 1;

            // We shall store the lower box type in this string
            string lowerBoxType = (string)btn[currentXPos, belowBox].Tag;

            // Before we move the box lets check its local area for things that might stop it
            if (lowerBoxType == "prime" || lowerBoxType == "ups" || lowerBoxType == "fedex")
            {
                tickCounter = 0;
            }
        }
    }
}
