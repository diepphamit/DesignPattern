using BuilderPattern.CarParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class CarBuilder : ICarBuilder
    {
        public Engine Engine { get; set; }
        public string Color { get; set; }
        public SeatBelt SeatBelt { get; set; }
        public WindScreen WindScreen { get; set; }
        public int NumberOfWheels { get; set; }
        public CarBuilder AddEngine(Engine engine)
        {
            Engine = engine;
            return this;
        }

        public CarBuilder AddSeatBelts(SeatBelt seatBelt)
        {
            SeatBelt = seatBelt;    
            return this;
        }

        public CarBuilder AddWheels(int numberOfWheels)
        {
            NumberOfWheels = numberOfWheels;
            return this;
        }

        public CarBuilder AddWinScreen(WindScreen windScreen)
        {
            WindScreen = windScreen;
            return this;
        }


        public CarBuilder Paint(string color)
        {
            Color = color;
            return this;
        }

        public Car Build()
        {
            return new Car(NumberOfWheels, SeatBelt, Color, WindScreen, Engine);
        }
    }
}
