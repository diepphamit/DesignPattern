// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using DecoratorPattern;
using DecoratorPattern.Base;
using DecoratorPattern.Decorators;

IPizza pizza = new Pizza();
Console.WriteLine(pizza.doPizza());

CheeseDecorator cheesePizza = new CheeseDecorator(pizza);
Console.WriteLine(cheesePizza.doPizza());

PepperDecorator pepperPizza = new PepperDecorator(cheesePizza);
Console.WriteLine(pepperPizza.doPizza());

