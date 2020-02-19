using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace BoxField
{
    class box
    {
        public SolidBrush bBrush;

       public int x, y;
       public int size;

        public box(int _x, int _y, int _size)
        {
            x = _x;
            y = _y;
            size = _size;
        }
        public box(SolidBrush _brushbox, int _x, int _y, int _size)
        {
            x = _x;
            y = _y;
            size = _size;
            bBrush = _brushbox;
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
