// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using PrototypePattern;

ColorManager colormanager = new ColorManager();

//init data
colormanager["red"] = new Color(255, 0, 0);
colormanager["green"] = new Color(0, 255, 0);
colormanager["blue"] = new Color(0, 0, 255);

Color color1 = colormanager["red"].Clone() as Color;