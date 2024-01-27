using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint_V4
{
    internal interface Prototype
    {
        Prototype Clone(int x, int y, int width, int height, int borderwidth, Color borderColor);

        string GetColor();
    }

}
