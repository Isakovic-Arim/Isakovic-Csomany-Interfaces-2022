using System;

namespace Shapes
{
    public class Program
    {
        public static void Main()
        {
            // Object references can be declared using an interface type
            IShape shape = new Square();
            shape.X = 10;
            shape.Y = 10;
            shape.Color = ConsoleColor.Blue;
            shape.Draw();

            shape = new Rectangle();
            shape.X = 30;
            shape.Y = 30;
            shape.Color = ConsoleColor.Red;
            shape.Draw();
            
            Console.WriteLine("Zum Schließen beliebige Taste drücken...");
            Console.ReadKey();
        }
    }
}