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
        public const int comboSize = 2;

        // General Global Varibles
        int tickCounter = 1;
        int sameGenCounter = 0;
        Boolean gameLost = false;
        Boolean paused = true;

        // Score varibles
        int totalScore = 0;
        int totalDispatches = 0;
        int averageDispatches = 0;

        // Box Related Globals
        int currentXPos = 0;
        int currentYPos = 0;
        int currentBoxType = 0;
        int nextBoxType = 0;

        // Belt Realated Globals
        int currentBeltXPos = 0;

        // User Click Cords
        int userX;
        int userY;

        // Create an array of buttons (This is the grid)
        Button[,] btn = new Button[gameBoardHeight, gameBoardWidth];

        public GameForm()
        {
            InitializeComponent();

            // Some of this code is from the lab 2 sheet
            for (int x = 0; x < btn.GetLength(0) ; x++)
            {
                for (int y = 0; y < btn.GetLength(0); y++)
                {
                    // Create button in array posistion [x,y]
                    btn[x, y] = new Button();

                    // Set the size of the button and the link the event handler
                    btn[x, y].SetBounds(60 * x, 60 * y, 62, 62);
                    btn[x, y].Click += new EventHandler(this.btnEvent_Click);

                    // Set the image background of the button & other design settings
                    btn[x, y].FlatStyle = FlatStyle.Flat;
                    btn[x, y].FlatAppearance.BorderSize = 0;
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

            // When the form has loaded we mark out the parts of the grid for the belt
            for (int x = 0; x < gameBoardWidth; x++)
            {
                for (int y = 0; y < 2; y++)
                {
                    btn[x, y].BackgroundImage = BoxGame.Properties.Resources.beltarea;
                }
            }

            // We then place the belt
            btn[currentBeltXPos, 0].BackgroundImage = BoxGame.Properties.Resources.beltstart;
            btn[currentBeltXPos, 1].BackgroundImage = BoxGame.Properties.Resources.EMPTYbelt;

            // And we generate the type of the first box to be spawned
            GenerateNextBox();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            // The following three lines were taken from StackOverflow on the 03/02/2019
            // The line placing X & Y to string to be parsed was also taken. Total of 4 lines
            // These lines allow us to figure out where the user has clicked the mouse so we can move the belt
            https://stackoverflow.com/questions/14172617/prind-index-of-2d-array-using-the-click-event

            Button ButtonToIndex = (Button)sender;
            userX = int.Parse(ButtonToIndex.Name.Split()[1]);
            userY = int.Parse(ButtonToIndex.Name.Split()[3]);

            // On every click we need to refresh the belts location in the grid because the user might have moved it
            CreateBelt();
        }

        private void PrimaryTimer_Tick(object sender, EventArgs e)
        {
            // We keep refreshing the belt on every tick to keep it upto date
            CreateBelt();

            string temp = totalScore.ToString();
            TotalScoreLabel.Text = temp;
            TotalDispatch.Text = totalDispatches.ToString();
            AverageDispatchSize.Text = averageDispatches.ToString();

            // We keep track of timer ticks to measure a boxes lifetime, with each tick we count up
            tickCounter += 1;

            // If this is the first tick then we must spawn a new box as its a new box lifetime
            if (tickCounter < 2)
            {
                SpawnBox();
                GenerateNextBox();
            }

            // We now know this is not a fresh spawn box so lets process how to use it
            else
            {
                ProcessBox();
            }
        }

        private void GenerateNextBox()
        {
            // Store the last box type
            int oldBoxType = currentBoxType;

            // Generate random box type
            Random rnd = new Random();

            // Box type is represented by a number between 1 and 3
            nextBoxType = rnd.Next(1, 4);

            // We dont want the same box appearing (That would make it too easy now :D)
            if (nextBoxType == oldBoxType)
            {
                sameGenCounter++;
            }

            // If the same box has been generated more then twice we need to mix it up
            while(sameGenCounter >= 2 && nextBoxType == oldBoxType)
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
            string spawnBoxType = (string)btn[currentXPos, 2].Tag;

            if (spawnBoxType == "prime" || spawnBoxType == "ups" || spawnBoxType == "fedex")
            {
                PrimaryTimer.Stop();
                gameLost = true;
            }

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
            btn[currentBeltXPos, 0].BackgroundImage = BoxGame.Properties.Resources.beltarea;
            btn[currentBeltXPos, 1].BackgroundImage = BoxGame.Properties.Resources.beltarea;

            currentBeltXPos = userX;

            if (nextBoxType == 1)
            {
                btn[currentBeltXPos, 0].BackgroundImage = BoxGame.Properties.Resources.beltstart;
                btn[currentBeltXPos, 1].BackgroundImage = BoxGame.Properties.Resources.primeonbelt;
            }

            if (nextBoxType == 2)
            {
                btn[currentBeltXPos, 0].BackgroundImage = BoxGame.Properties.Resources.beltstart;
                btn[currentBeltXPos, 1].BackgroundImage = BoxGame.Properties.Resources.upsonbelt;
            }

            if (nextBoxType == 3)
            {
                btn[currentBeltXPos, 0].BackgroundImage = BoxGame.Properties.Resources.beltstart;
                btn[currentBeltXPos, 1].BackgroundImage = BoxGame.Properties.Resources.fedexonbelt;
            }
        }

        private void ProcessBox()
        {
            // We must first check that the box is still able to move in the array
            if (currentYPos != (gameBoardHeight - 1))
            {
                // Before we can move the box down we need to what is below it
                int belowBox = currentYPos;

                // We check the lower box by moving the current Ypos by 1
                belowBox += 1;

                // We shall store the lower box type in this string (We store the type of box in a tag)
                string lowerBoxType = (string)btn[currentXPos, belowBox].Tag;

                // Lets now check the tag and see how to treat it, in this case is it a game item?
                if (lowerBoxType == "prime" || lowerBoxType == "ups" || lowerBoxType == "fedex")
                {
                    // We now know a game item is below this box which means it can no longer move around, we must now check for combos
                    CheckVertical();
                    CheckHorizontal();

                    // Now we know this box has reached the end of its active lifespan so we can reset the tick counter to start the process all over again.
                    tickCounter = 0;
                }
                // The box below is not a game item so it must be empty, we can now move it down safely.
                else
                {
                    MoveBoxDown();
                }
            }

            // We are on the bounds of the array so we must now stop before we go out of bounds.
            else
            {
                // Are we at the bottom of the gameboard? If so there can be horizontal combos.
                if(currentYPos == (gameBoardHeight - 1))
                {
                    CheckHorizontal();
                    tickCounter = 0;
                }
                
                else
                {
                    tickCounter = 0;
                }
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
    
        private void CheckVertical()
        {
            // Total number of matches so far
            int upMatchCount = 0;
            int downMatchCount = 0;

            // Scan control
            Boolean scanUp = true;
            Boolean scanDown = true;

            // Get the current xpos
            int boxChecker;
            boxChecker = currentYPos;

            Console.WriteLine("I am starting at box");
            Console.WriteLine(boxChecker);

            while (scanUp && boxChecker != 0)
            {
                Console.WriteLine("I am scanning up");

                // First box to the left
                boxChecker -= 1;

                Console.WriteLine("I am checking the box =");
                Console.WriteLine(boxChecker);

                // Is the box to the left the same as this the current box?
                string boxType = (string)btn[currentXPos, boxChecker].Tag;

                // If so, then add one to the combo
                if (boxType == "prime" && currentBoxType == 1)
                {
                    Console.WriteLine("I have a prime match");
                    upMatchCount += 1;
                }
                else if (boxType == "ups" && currentBoxType == 2)
                {
                    Console.WriteLine("I have a ups match");
                    upMatchCount += 1;
                }
                else if (boxType == "fedex" && currentBoxType == 3)
                {
                    Console.WriteLine("I have a fedex match");
                    upMatchCount += 1;
                }

                // Not the same box so we stop scanning left here
                else if (boxType != "prime" || boxType != "ups" || boxType != "fedex")
                {
                    Console.WriteLine("No More Matches Found, up Matches Are =");
                    Console.WriteLine(upMatchCount);
                    scanUp = false;
                }
            }

            // Reset boxChecker back to center
            boxChecker = currentYPos;
            
            Console.WriteLine("I am starting at box");
            Console.WriteLine(boxChecker);

            while (scanDown && (boxChecker != gameBoardHeight - 1))
            {
                Console.WriteLine("I am scanning down");

                // First box to the right
                boxChecker += 1;

                Console.WriteLine("I am checking the box =");
                Console.WriteLine(boxChecker);

                // Is the box to the right the same as this the current box?
                string boxType = (string)btn[currentXPos, boxChecker].Tag;

                // If so, then add one to the combo
                if (boxType == "prime" && currentBoxType == 1)
                {
                    Console.WriteLine("I have a prime match");
                    downMatchCount += 1;
                }
                else if (boxType == "ups" && currentBoxType == 2)
                {
                    Console.WriteLine("I have a ups match");
                    downMatchCount += 1;
                }
                else if (boxType == "fedex" && currentBoxType == 3)
                {
                    Console.WriteLine("I have a fedex match");
                    downMatchCount += 1;
                }

                // Not the same box so we stop scanning right here
                else if (boxType != "prime" || boxType != "ups" || boxType != "fedex")
                {
                    Console.WriteLine("No More Matches Found, Down Matches Are =");
                    Console.WriteLine(downMatchCount);
                    scanDown = false;
                }
            }

            Console.WriteLine("Total Matches Are =");
            Console.WriteLine(downMatchCount + upMatchCount);
            Console.WriteLine("---------------------------------------------");


            // If we got at least one match on each side we know thats a combo
            if (upMatchCount >= 1 && downMatchCount >= 1 || upMatchCount >= 2 || downMatchCount >= 2)
            {
                boxChecker = currentYPos;

                Console.WriteLine("WE GOTTA COMBOOOO =");

                // Move left by total match count minus one due to addition in loop

                boxChecker = boxChecker - upMatchCount - 1;

                Console.WriteLine("We are going to loop for a total of = ");
                Console.WriteLine(upMatchCount + downMatchCount + 1);

                totalDispatches++;

                for (int x = 0; x <= (upMatchCount + downMatchCount); x++)
                {
                    Console.WriteLine("BoxChecker = ");
                    Console.WriteLine(boxChecker);

                    boxChecker += 1;

                    // Go to each left image and replace with empty
                    btn[currentXPos, boxChecker].BackgroundImage = BoxGame.Properties.Resources.emptyslot;
                    btn[currentXPos, boxChecker].Tag = "empty";

                    totalScore++;

                }
                averageDispatches = totalScore / totalDispatches;
                //Plays a sound when a combo is made
                System.Media.SoundPlayer comboMusic = new System.Media.SoundPlayer(BoxGame.Properties.Resources.ComboMusicFile);
                comboMusic.Play();
            }
        }

        private void CheckHorizontal()
        {
            // Total number of matches so far
            int leftMatchCount = 0;
            int rightMatchCount = 0;

            // Scan control
            Boolean scanLeft = true;
            Boolean scanRight = true;

            // Get the current xpos
            int boxChecker;
            boxChecker = currentXPos;

            Console.WriteLine("I am starting at box");
            Console.WriteLine(boxChecker);

            while (scanLeft && boxChecker != 0)
            {
                Console.WriteLine("I am scanning left");

                // First box to the left
                boxChecker -= 1;

                Console.WriteLine("I am checking the box =");
                Console.WriteLine(boxChecker);

                // Is the box to the left the same as this the current box?
                string boxType = (string)btn[boxChecker, currentYPos].Tag;

                // If so, then add one to the combo
                if (boxType == "prime" && currentBoxType == 1)
                {
                    Console.WriteLine("I have a prime match");
                    leftMatchCount += 1;
                }
                else if (boxType == "ups" && currentBoxType == 2)
                {
                    Console.WriteLine("I have a ups match");
                    leftMatchCount += 1;
                }
                else if (boxType == "fedex" && currentBoxType == 3)
                {
                    Console.WriteLine("I have a fedex match");
                    leftMatchCount += 1;
                }

                // Not the same box so we stop scanning left here
                else if (boxType != "prime" || boxType != "ups" || boxType != "fedex")
                {
                    Console.WriteLine("No More Matches Found, Left Matches Are =");
                    Console.WriteLine(leftMatchCount);
                    scanLeft = false;
                }
            }

            // Reset boxChecker back to center
            boxChecker = currentXPos;

            Console.WriteLine("I am starting at box");
            Console.WriteLine(boxChecker);

            while (scanRight && (boxChecker != gameBoardWidth - 1))
            {
                Console.WriteLine("I am scanning right");

                // First box to the right
                boxChecker += 1;

                Console.WriteLine("I am checking the box =");
                Console.WriteLine(boxChecker);

                // Is the box to the right the same as this the current box?
                string boxType = (string)btn[boxChecker, currentYPos].Tag;

                // If so, then add one to the combo
                if (boxType == "prime" && currentBoxType == 1)
                {
                    Console.WriteLine("I have a prime match");
                    rightMatchCount += 1;
                }
                else if (boxType == "ups" && currentBoxType == 2)
                {
                    Console.WriteLine("I have a ups match");
                    rightMatchCount += 1;
                }
                else if(boxType == "fedex" && currentBoxType == 3)
                {
                    Console.WriteLine("I have a fedex match");
                    rightMatchCount += 1;
                }

                // Not the same box so we stop scanning right here
                else if (boxType != "prime" || boxType != "ups" || boxType != "fedex")
                {
                    Console.WriteLine("No More Matches Found, Right Matches Are =");
                    Console.WriteLine(rightMatchCount);
                    scanRight = false;
                }
            }

            Console.WriteLine("Total Matches Are =");
            Console.WriteLine(rightMatchCount + leftMatchCount);
            Console.WriteLine("---------------------------------------------");


            // If we got at least one match on each side we know thats a combo
            if (leftMatchCount >= 1 && rightMatchCount >= 1 || leftMatchCount >= 2 || rightMatchCount >= 2)
            {
                boxChecker = currentXPos;

                Console.WriteLine("WE GOTTA COMBOOOO =");

                // Move left by total match count minus one due to addition in loop

                boxChecker = boxChecker - leftMatchCount -1;

                Console.WriteLine("We are going to loop for a total of = ");
                Console.WriteLine(leftMatchCount + rightMatchCount + 1);

                totalDispatches++;

                for (int x = 0; x <= (leftMatchCount+rightMatchCount); x++)
                {
                    Console.WriteLine("BoxChecker = ");
                    Console.WriteLine(boxChecker);

                    boxChecker += 1;

                    // Go to each left image and replace with empty
                    btn[boxChecker, currentYPos].BackgroundImage = BoxGame.Properties.Resources.emptyslot;
                    btn[boxChecker, currentYPos].Tag = "empty";

                    totalScore++;

                }

                averageDispatches = totalScore / totalDispatches;
                //Plays a sound when a combo is made
                System.Media.SoundPlayer comboMusic = new System.Media.SoundPlayer(BoxGame.Properties.Resources.ComboMusicFile);
                comboMusic.Play();
            }
        }

        private void resetGame()
        {
            totalScore = 0;
            totalDispatches = 0;
            averageDispatches = 0;
            gameLost = false;

            PrimaryTimer.Stop();

            for(int x = 0; x < gameBoardHeight; x++)
            {
                for(int y = 0; y < gameBoardWidth; y++)
                {
                    btn[x, y].BackgroundImage = BoxGame.Properties.Resources.emptyslot;
                    btn[x, y].Tag = "empty";
                }
            }

            // When the form has loaded we mark out the parts of the grid for the belt
            for (int x = 0; x < gameBoardWidth; x++)
            {
                for (int y = 0; y < 2; y++)
                {
                    btn[x, y].BackgroundImage = BoxGame.Properties.Resources.beltarea;
                }
            }
            tickCounter = 0;
            PrimaryTimer.Start();
        }

        private void MainMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            MainMenuPanel.Visible = false;
            resetGame();
            PrimaryTimer.Start();
        }

        private void LearnBtn_Click(object sender, EventArgs e)
        {
            LearnPnl.Visible = true;
            LearnPnl.BringToFront();
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            ExitConfirmation.Visible = true;
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            ExitConfirmation.Visible = false;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            LearnPnl.Visible = false;
        }

        private void QuitJobBtn_Click(object sender, EventArgs e)
        {
            MainMenuPanel.Visible = true;
            PrimaryTimer.Stop();
        }

        private void StartOverBtn_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(paused)
            {
                paused = false;
                pauseButton.BackgroundImage = BoxGame.Properties.Resources.pausebutton;
                PrimaryTimer.Start();
            }
            else
            {
                paused = true;
                pauseButton.BackgroundImage = BoxGame.Properties.Resources.unpausebutton;
                PrimaryTimer.Stop();
            }
        }
    }
}
