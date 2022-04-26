using System;

namespace Shapes
{
    public class Program
    {
        public static void Main()
        {
            // Object references can be declared using an interface type
            IShape shape = new Square();
            shape.Draw();
        }
    }
}