using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint_V4
{
    internal class MyRectangle : Prototype
    {
        private int _x, _y, _width, _height, _borderwidth;
        private Color _borderColor;

        internal MyRectangle()
        {
        }

        public MyRectangle(int x, int y, int width, int height, int borderwidth, Color borderColor)
        {
            _x=x;
            _y=y;
            _width=width;
            _height=height;
            _borderwidth=borderwidth;
            _borderColor=borderColor;
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public Prototype Clone(int x, int y, int width, int height, int borderwidth, Color borderColor)
        {
            return new MyRectangle(x, y, width, height, borderwidth, borderColor);
        }

        public void Draw(Graphics g)
        {
            Pen p = new Pen(_borderColor, _borderwidth);
            Rectangle r = new Rectangle(_x, _y, _width, _height);
            g.DrawRectangle(p, r);
        }

        public string GetColor()
        {
            return _borderColor.Name;
        }
    }
}
