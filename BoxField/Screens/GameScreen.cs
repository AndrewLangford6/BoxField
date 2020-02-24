using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//namespace BoxField
//{
//    public partial class GameScreen : UserControl
//    {
//        //player1 button control keys
//        Boolean leftArrowDown, rightArrowDown;

//        //used to draw boxes on screen
//        SolidBrush boxBrush = new SolidBrush(Color.PaleGoldenrod);

//        SolidBrush red = new SolidBrush(Color.Red);
//        SolidBrush blue = new SolidBrush(Color.Blue);

//        SolidBrush green = new SolidBrush(Color.Green);
//        SolidBrush orange = new SolidBrush(Color.Orange);
//        SolidBrush purple = new SolidBrush(Color.Purple);

//        //box left list
//        List<box> leftBoxes = new List<box>();

//        List<box> rightBoxes = new List<box>();

//        int counter;
//        int counter2;

//        Random ranGen = new Random();

//        box Hero;

//        public GameScreen()
//        {
//            InitializeComponent();
//            OnStart();
//        }

//        /// <summary>
//        /// Set initial game values here
//        /// </summary>
//        public void OnStart()
//        {
//            //TODO - set game start values
//            box b = new box(red,4, 36, 10);
//            leftBoxes.Add(b);

//            box b2 = new box(red, 30, 36, 10);
//            rightBoxes.Add(b2);



//            Hero = new box(this.Width/2, this.Height/2, 16);
//        }

//        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
//        {
//            //player 1 button presses
//            switch (e.KeyCode)
//            {
//                case Keys.Left:
//                    leftArrowDown = true;
//                    break;
//                case Keys.Right:
//                    rightArrowDown = true;
//                    break;           
//            }
//        }

//        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
//        {
//            //player 1 button releases
//            switch (e.KeyCode)
//            {
//                case Keys.Left:
//                    leftArrowDown = false;
//                    break;
//                case Keys.Right:
//                    rightArrowDown = false;
//                    break;
//            }
//        }

//        public void gameLoop_Tick(object sender, EventArgs e)
//        {
//            //TODO - update location of all boxes (drop down screen)

//            foreach (box b in leftBoxes)
//            {
//                b.Fall();

//            }
//            foreach (box b in rightBoxes)
//            {
//                b.Fall();

//            }

//            //TODO - remove box if it has gone of screen

//            if (leftBoxes[0].y > this.Height)
//            {
//                leftBoxes.RemoveAt(0);
//            }
//            if (rightBoxes[0].y > this.Height)
//            {
//                rightBoxes.RemoveAt(0);
//            }


//            //TODO - add new box if it is time


//            counter++;
//            counter2++;
//            if(counter == 1)
//            {
//                counter = 0;
//                int rand2 = ranGen.Next(1, 6);

//                if (rand2 == 1)
//                {
//                    int rando = ranGen.Next(-1000, 2000);
//                    box box = new box(red, this.Width / 2 - 10, this.Height / 2, 10);
//                    leftBoxes.Add(box);

//                }
//                else if (rand2 == 2)
//                {
//                    int rando = ranGen.Next(-1000, 2000);
//                    box box = new box(blue, this.Width / 2 - 10, this.Height / 2, 10);
//                    leftBoxes.Add(box);

//                }
//                else if (rand2 == 3)
//                {
//                    int rando = ranGen.Next(-1000, 2000);
//                    box box = new box(orange , this.Width / 2 - 10, this.Height / 2, 10);
//                    leftBoxes.Add(box);

//                }
//                else if (rand2 == 4)
//                {
//                    int rando = ranGen.Next(-1000, 2000);
//                    box box = new box(green, this.Width / 2 - 10, this.Height / 2, 10);
//                    leftBoxes.Add(box);

//                }
//                else if (rand2 == 5)
//                {
//                    int rando = ranGen.Next(-1000, 2000);
//                    box box = new box(purple, this.Width / 2 - 10, this.Height / 2, 10);
//                    leftBoxes.Add(box);

//                }


//            }

//            //right
//            if (counter2 == 1)
//            {
//                counter2 = 0;
//                int rand2 = ranGen.Next(1, 6);

//                if (rand2 == 1)
//                {
//                    int rando = ranGen.Next(-1000, 2000);
//                    box rbox = new box(red, this.Width / 2 + 10, this.Height / 2, 10);
//                    rightBoxes.Add(rbox);

//                }
//                else if (rand2 == 2)
//                {
//                    int rando = ranGen.Next(-1000, 2000);
//                    box rbox = new box(blue, this.Width / 2 + 10, this.Height / 2, 10);
//                    rightBoxes.Add(rbox);

//                }
//                else if (rand2 == 3)
//                {
//                    int rando = ranGen.Next(-1000, 2000);
//                    box rbox = new box(orange, this.Width / 2 + 10, this.Height / 2, 10);
//                    rightBoxes.Add(rbox);

//                }
//                else if (rand2 == 4)
//                {
//                    int rando = ranGen.Next(-1000, 2000);
//                    box rbox = new box(green, this.Width / 2 + 10, this.Height / 2, 10);
//                    rightBoxes.Add(rbox);

//                }
//                else if (rand2 == 5)
//                {
//                    int rando = ranGen.Next(-1000, 2000);
//                    box rbox = new box(purple, this.Width/2 + 10, this.Height / 2, 10);
//                    rightBoxes.Add(rbox);

//                }


//            }

//            if (leftArrowDown)
//            {
//               // Hero.Move("left");
//                foreach (box b in leftBoxes)
//                {
//                    b.Move("right");

//                }
//                foreach (box b in rightBoxes)
//                {
//                    b.Move("right");

//                }

//            }
//            if (rightArrowDown)
//            {
//                //Hero.Move("right");
//                foreach (box b in leftBoxes)
//                {
//                    b.Move("left");

//                }
//                foreach (box b in rightBoxes)
//                {
//                    b.Move("left");

//                }
//            }
//            Refresh();
//        }

//        private void GameScreen_Load(object sender, EventArgs e)
//        {

//        }

//        private void GameScreen_Paint(object sender, PaintEventArgs e)
//        {
//            foreach (box b in leftBoxes)
//            {

//                e.Graphics.FillRectangle(b.bBrush, b.x, b.y, b.size, b.size);
//            }

//            //right
//            foreach (box b in rightBoxes)
//            {

//                e.Graphics.FillRectangle(b.bBrush, b.x, b.y, b.size, b.size);
//            }

//            e.Graphics.FillRectangle(boxBrush, Hero.x, Hero.y, Hero.size, Hero.size);

//            //TODO - draw boxes to screen
//            //
//        }
//    }
//}
namespace BoxField
{
    public partial class GameScreen : UserControl
    {

        Random randGen = new Random();

        //player1 button control keys
        Boolean leftArrowDown, rightArrowDown;

        //used to draw boxes on screen
        SolidBrush whiteBrush = new SolidBrush(Color.White);

        //create a list to hold a column of boxes        
        List<box> boxesLeft = new List<box>();
        List<box> boxesRight = new List<box>();

        int boxSize = 20;
        int boxLeftX = 100;
        int boxGap = 200;
        int boxXOffset = 5;


        //counts to see when its time to create a new box
        int counter = 0;
        int newBoxCounter = 0;
        int patternAmount = 10;

        //create hero values
        box hero;

        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }

        /// <summary>
        /// Set initial game values here
        /// </summary>
        public void OnStart()
        {
            //set game start values
            box b1 = new box(boxLeftX, 0, boxSize);
            boxesLeft.Add(b1);

            box b2 = new box(boxLeftX + boxGap, 0, boxSize);
            boxesRight.Add(b2);

            newBoxCounter++;

            hero = new box(50, 300, 20);
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //player 1 button presses
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //player 1 button releases
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
            }
        }

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            //update location of all boxes (drop down screen)
            foreach (box b in boxesLeft)
            {
                b.Fall();
            }

            foreach (box b in boxesRight)
            {
                b.Fall();
            }

            //remove box if it has gone of screen
            if (boxesLeft[0].y > 400)
            {
                boxesLeft.RemoveAt(0);
                boxesRight.RemoveAt(0);
            }

            //add new box if it is time
            counter++;
            if (counter == 9)
            {
                newBoxCounter++;

                boxLeftX += boxXOffset;

                box b1 = new box(boxLeftX, 0, boxSize);
                boxesLeft.Add(b1);

                box b2 = new box(boxLeftX + boxGap, 0, boxSize);
                boxesRight.Add(b2);

                counter = 0;

                if (newBoxCounter == patternAmount)
                {
                    boxXOffset = -boxXOffset;
                    newBoxCounter = 0;

                    patternAmount = randGen.Next(1, 8);
                }
            }

            //move hero
            if (leftArrowDown)
            {
                hero.Move("left");
            }

            if (rightArrowDown)
            {
                hero.Move("right");
            }

            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //draw boxes to screen
            foreach (box b in boxesLeft)
            {
                e.Graphics.FillRectangle(b.boxBrush, b.x, b.y, b.size, b.size);
            }

            foreach (box b in boxesRight)
            {
                e.Graphics.FillRectangle(b.boxBrush, b.x, b.y, b.size, b.size);
            }

            e.Graphics.FillRectangle(whiteBrush, hero.x, hero.y, hero.size, hero.size);
        }
    }
}
