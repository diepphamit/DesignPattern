// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using CommandPattern;

Fan fan = new Fan();

ICommand turnOnCommand = new TurnOnCommand(fan);
ICommand turnOffCommand = new TurnOffCommand(fan);

Remote remote = new Remote(turnOnCommand, turnOffCommand);

remote.TurnOnButtonClick();
remote.TurnOffButtonClick();