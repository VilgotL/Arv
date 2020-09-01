using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Rectangle : Shape
    {
        public Rectangle(double width, double height):base(width, height)
        {

        }
        public double Area()
        {
            double area = width * height;
            return area;
        }

        public double Circumferance()
        {
            double circ = width + width + height + height;
            return circ;
        }
    }
}
