using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxField
{
    public partial class GameScreen : UserControl
    {
        //player1 button control keys
        Boolean leftArrowDown, rightArrowDown;

        //used to draw boxes on screen
        SolidBrush boxBrush = new SolidBrush(Color.Purple);

        //box left list
        List<box> leftBoxes = new List<box>();

         int counter;

        box Hero;

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
            //TODO - set game start values
            box b = new box(4, 36, 10);
            leftBoxes.Add(b);

            Hero = new box(50, 100, 16);
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

        public void gameLoop_Tick(object sender, EventArgs e)
        {
            //TODO - update location of all boxes (drop down screen)
            
            foreach (box b in leftBoxes)
            {
                b.Fall();
                
            }
            
            //TODO - remove box if it has gone of screen

            if (leftBoxes[0].y > this.Height + 200)
            {
                leftBoxes.RemoveAt(0);
            }


            //TODO - add new box if it is time
            counter++;
            if(counter == 5)
            {
                box box = new box(4, 36, 10);
                leftBoxes.Add(box);
                counter = 0;
            }

            if(leftArrowDown)
            {
                Hero.Move("left");
            }
            if (rightArrowDown)
            {
                Hero.Move("right");
            }
            Refresh();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {

        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach (box b in leftBoxes)
            {

                e.Graphics.FillRectangle(boxBrush, b.x, b.y, b.size, b.size);
            }

            e.Graphics.FillRectangle(boxBrush, Hero.x, Hero.y, Hero.size, Hero.size);

            //TODO - draw boxes to screen
            //
        }
    }
}
