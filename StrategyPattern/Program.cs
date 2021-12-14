// See https://aka.ms/new-console-template for more information
using StrategyPattern;

var x = new Ticket(new QuaterDiscountStrategy());
x.price = 50;
x.name = "Diep";
Console.WriteLine(x.GetPromotedPrice());
x.promotedStrategy = new NoDiscountStrategy();
Console.WriteLine(x.GetPromotedPrice());

