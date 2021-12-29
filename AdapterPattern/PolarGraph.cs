using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class PolarGraph
    {
        public void Point(double r, double t)
        {
            Console.WriteLine("Polar Coordinate Point: P(" + r + ", " + t + ")");
        }
    }
}
