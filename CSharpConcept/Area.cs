using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unisys.MathConcept
{
    public class Area
    {
        public static double AreaOfCircle(int r)
        {
            double area = 3.14 * r * r;
            return area;
        }

        public static double AreaOfRectangle(double length, double width)
        {
            return length * width;
        }

        //create a method for AreaOfSquare
        public static double AreaOfSquare(double side)
        {
            return side * side;
        }

        //Create a method for AreaOfTriangle
        public double AreaOfTriangle(double baseLength,double height)
        {
            return (baseLength * height) / 2;
        }

        public String GetAuthorName()
        {
            return "Balaji Dinakaran";
        }

        public void Quit()
        {

        }
    }
}
