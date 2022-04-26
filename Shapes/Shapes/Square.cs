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
        private double _mX, _mY;

        // A class implementing an interface MUST define all the members declared in the interface
        public void Draw()
        {

        }

        public double X
        {
            set { _mX = value; }
            get { return _mX; }
        }

        public double Y
        {
            set { _mY = value; }
            get { return _mY; }
        }
    }
}
