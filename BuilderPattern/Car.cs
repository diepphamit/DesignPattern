using BuilderPattern.CarParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class Car
    {
        public int NumberOfWheels { get; set; }
        public SeatBelt SeatBelt { get; set; }
        public string Color { get; set; }
        public WindScreen Windscreen { get; set; }
        public Engine Engine { get; set; }

        public Car(int numberOfWheels,
                   SeatBelt seatBelt,
                   string color,
                   WindScreen windscreen,
                   Engine engine)
        {
            NumberOfWheels = numberOfWheels;
            SeatBelt = seatBelt;
            Color = color;
            Windscreen = windscreen;
            Engine = engine;
        }

        public override string ToString()
        {
            var content = "";
            content += $"Number of wheels:    \t {NumberOfWheels}\n Color: {Color}";
          
            return content;
        }
    }
}
