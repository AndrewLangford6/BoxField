using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


//namespace BoxField
//{
//    class box
//    {
//        public SolidBrush bBrush;


//        public int x, y;
//       public int size;

//        public box(int _x, int _y, int _size)
//        {
//            x = _x;
//            y = _y;
//            size = _size;
//        }
//        public box(SolidBrush _brushbox, int _x, int _y, int _size)
//        {
//            x = _x;
//            y = _y;
//            size = _size;
//            bBrush = _brushbox;
//        }

//        public void Fall()
//        {
//            y = y + 3;
//        }
//        public void Move(string direction)
//        {
//            if (direction == "left")
//            {
//                x = x - 5;
//            }
//            if (direction == "right")
//            {
//                x = x + 5;
//            }
//        }

//    }
//}
namespace BoxField
{
    class box
    {
        public SolidBrush boxBrush;
        public int x, y, size;
        Random randGen = new Random();

        public box(int _x, int _y, int _size)
        {
            x = _x;
            y = _y;
            size = _size;

            int randValue = randGen.Next(1, 3);

            if (randValue == 1)
            {
                boxBrush = new SolidBrush(Color.Red);
            }
            else if (randValue == 2)
            {
                boxBrush = new SolidBrush(Color.Orange);
            }
        }

        public box(SolidBrush _boxBrush, int _x, int _y, int _size)
        {
            x = _x;
            y = _y;
            size = _size;
            boxBrush = _boxBrush;
        }

        public void Fall()
        {
            y = y + 3;
        }

        public void Move(string direction)
        {
            if (direction == "left")
            {
                x = x - 5;
            }

            if (direction == "right")
            {
                x = x + 5;
            }

        }

    }
}
