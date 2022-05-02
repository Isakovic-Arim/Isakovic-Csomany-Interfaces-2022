using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    // A class can only inherit from one class, but an unspecified number of interfaces as so:
    // class MyClass : Class1, Interface1, Interface2 ...
    class Square : IShape
    {
        private ConsoleColor _color;
        private int _mX, _mY;

        private readonly int length = new Random().Next(12, 20);

        // A class implementing an interface MUST define all the members declared in the interface
        public void Draw()
        {
            Console.ForegroundColor = Color;
            for (int i = 0; i < Console.WindowHeight - Y; i++)
            {
                Console.WriteLine();
            }
            for (int i = 0; i < length * 0.5; i++) // multiply by 0.5 to make it look more like a square, rather than a rectangle
            {
                for (int j = 0; j < X; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < length; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public ConsoleColor Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public int X
        {
            set { _mX = value; }
            get { return _mX; }
        }

        public int Y
        {
            set { _mY = value; }
            get { return _mY; }
        }
    }
}
