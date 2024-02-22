using System;

namespace Structs{
    struct Point{
        public double x;
        public double y;
        public void DisplayCoordinates(){
            Console.WriteLine($"The point's coordinates are {x}, {y}.");

        }
    }
}