using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : IShape
    {
        private ConsoleColor _color;
        private int _mX, _mY;

        private int length = new Random().Next(6, 10);
        private int width = new Random().Next(4, 8);

        public void Draw()
        {
            Console.ForegroundColor = Color;

            for (int i = 0; i < Console.WindowHeight - Y; i++)
            {
                Console.WriteLine();
            }
            for (int i = 0; i < width; i++)
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
