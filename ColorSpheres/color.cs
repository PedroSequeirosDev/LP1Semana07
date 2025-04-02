using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Color
    {
        private byte _red;
        private byte _green;
        private byte _blue;
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

        public byte GetRed()
        {
            return _red;
        }
        public byte GetGreen()
        {
            return _green;
        }
        public byte GetBlue()
        {
            return _blue;
        }
        public byte GetAlpha()
        {
            return _alpha;
        }

        public byte GetGrey()
        {
            return (byte)((_red + _green + _blue) / 3);
        }
    }

    public class Sphere
    {
        private float _radius;
        private Color color;
        private int _bounces;



        public Sphere(float radius, Color color)
        {
            _radius = radius;
            this.color = color;
            _bounces = 0;
        }

        public void Pop()
        {
            _radius = 0;
        }

        public void Throw()
        {
            if (_radius > 0)
            {
                _bounces++;
            }
        }

        public int GetTimesThrown()
        {
            return _bounces;
        }
    }

}