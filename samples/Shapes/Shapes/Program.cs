using System;

namespace Shapes
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();

            // Object references can be declared using an interface type
            IShape shape = new Square();
            shape.X = 10;
            shape.Y = 10;
            shape.Color = ConsoleColor.Blue;
            shape.Draw();

            shape = new Rectangle();
            shape.X = 60;
            shape.Y = 60;
            shape.Color = ConsoleColor.Red;
            shape.Draw();

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}