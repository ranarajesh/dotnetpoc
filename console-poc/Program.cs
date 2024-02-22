// See https://aka.ms/new-console-template for more information

using console_poc;
using Structs;

Console.WriteLine("Hello, World!!!!");

(int, int) someTuple = new Package().returnTupple();
System.Console.WriteLine(someTuple.Item1);
System.Console.WriteLine(someTuple.Item2);

Point point = new Point();
point.x = 4;
point.y = 10;
System.Console.WriteLine(point.x);
point.DisplayCoordinates();

Car myCar = new Car();
myCar.Model = "Lexus";
myCar.Price = 1000000;
System.Console.WriteLine($"My car model is{myCar.Model}---{myCar.Price}");

