using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Color
    {
        private byte red, green, blue, alpha;

        private Color(byte red, byte green, byte blue, byte alpha)
        {
            red = SetRed(r);
            green = SetGreen(g);
            blue = SetBlue(b);
            alpha = SetAlpha(alpha);
        }

        private Color(byte red, byte green, byte blue)
        {
            red = SetRed(r);
            green = SetGreen(g);
            blue = SetBlue(b);
            alpha = 255;
        }
    }
}