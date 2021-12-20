// See https://aka.ms/new-console-template for more information
using BuilderPattern;
using BuilderPattern.CarParts;

Console.WriteLine("Hello, World!");

var car = new CarBuilder()
    .AddEngine(new Engine())
    .AddSeatBelts(new SeatBelt())
    .AddWheels(2)
    .AddWinScreen(new WindScreen())
    .Paint("Blue")
    .Build();   

Console.WriteLine(car.ToString());