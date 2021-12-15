// See https://aka.ms/new-console-template for more information
using StrategyPattern;

Console.WriteLine("Start getting tickets");

var random = new Random();

for(int i = 1; i <= 5; i++)
{
    var strategyIndex = random.Next(0, 4);
    var ticket = new Ticket();
    ticket.name ="Ticket " + i.ToString();
    ticket.price = 50 * i;
    switch(strategyIndex)
    {
        case 0:
            ticket.promotedStrategy = new NoDiscountStrategy();
            break;
        case 1:
            ticket.promotedStrategy = new QuaterDiscountStrategy();
            break;
        case 2:
            ticket.promotedStrategy = new HalfDiscountStrategy();
            break;
        default:
            ticket.promotedStrategy = new EightyDiscountStrategy();
            break;
    }

    Console.WriteLine(ticket.name + ": " + ticket.GetPromotedPrice() + ", Type: " + ticket.promotedStrategy.GetType().Name);
}

//Specially, you can set the promoted discount in runtime.

