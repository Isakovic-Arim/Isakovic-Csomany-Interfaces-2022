using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    interface IShape
    {
        // due to abstraction no deklarations are necessary
        double X { get; set; }
        double Y { get; set; }
        void Draw();
    }

    // Interfaces can also inherit off of other interfaces, but not from classes
    /*
     * inteface IRotateable
     * {
     *    void Rotate(double theta);
     * }
     * 
     * interface IDrawable : IRotateable
     * {
     *    void Draw();
     * }
     * 
     */
}
