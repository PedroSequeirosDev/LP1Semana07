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

        public byte Red => _red;
        public byte Green => _green;
        public byte Blue => _blue;
        public byte Alpha
        {
            get => _alpha;
            set => _alpha = value;
        }


        public byte Grey => (byte)((_red + _green + _blue) / 3);

    }

}