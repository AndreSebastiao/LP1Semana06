using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Color
    {
        private readonly byte red, green, blue, alpha;

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            red = GetRed();
            green = GetGreen();
            blue = GetBlue();
            alpha = GetAlpha();
        }

        public Color(byte red, byte green, byte blue)
        {
            red = GetRed();
            green = GetGreen();
            blue = GetBlue();
            alpha = 255;
        }

        private byte GetRed()
        {
            return red;
        }

        private byte GetGreen()
        {
            return green;
        }

        private byte GetBlue()
        {
            return blue;
        }

        private byte GetAlpha()
        {
            return alpha;
        }

        private byte GetGrey()
        {
            return (byte)((red + green + blue) / 3);
        }
    }
}