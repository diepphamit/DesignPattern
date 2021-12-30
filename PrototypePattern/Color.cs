using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    internal class Color : ColorPrototype
    {
        int _red;
        int _green;
        int _blue;

        public Color(int red, int green, int blue)
        {
            _red = red; 
            _green = green;
            _blue = blue;   
        }

        public override ColorPrototype Clone()
        {
            Console.WriteLine($"Cloning color RGB: {_red} {_green} {_blue}");

            return this.MemberwiseClone() as ColorPrototype;
        }
    }
}
