using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Triangle : Shape
    {
        public Triangle(double width, double height):base(width, height)
        {

        }

        public double Area()
        {
            double area = width * height;
            area /= 2;
            return area;
        }

        public double Circumferance()
        {
            double hypotenusa = Math.Sqrt(width * width + height * height);
            double circ = width + height + hypotenusa;
            return circ;
        }
    }
}
