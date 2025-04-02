using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;

namespace BetterColorSpheres
{
    public class Color
    {
        private readonly byte _red;
        private readonly byte _green;
        private readonly byte _blue;
        private byte _alpha;


        public Color(byte red, byte green, byte blue, byte alpha)
        {
            _red = red;
            _green = green;
            _blue = blue;
            _alpha = alpha;
        }

        public Color(byte red, byte green, byte blue)
        {
            _red = red;
            _green = green;
            _blue = blue;
            _alpha = 255;
        }

        public byte GetRed => _red;
        public byte GetGreen => _green;
        public byte GetBlue => _blue;
        public byte GetAlpha => _alpha;



        public byte GetGrey => (byte)((_red + _green + _blue) / 3);

    }

}