using BuilderPattern.CarParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal interface ICarBuilder
    {
        CarBuilder AddWheels(int numberOfWheels);
        CarBuilder AddSeatBelts(SeatBelt seatBelt);
        CarBuilder Paint(string color);
        CarBuilder AddWinScreen(WindScreen windScreen);
        CarBuilder AddEngine(Engine engine);
        Car Build();
    }
}
