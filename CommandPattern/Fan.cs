using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class Fan
    {
        public void TurnOn()
        {
            Console.WriteLine("Turn on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turn off");
        }
    }
}
