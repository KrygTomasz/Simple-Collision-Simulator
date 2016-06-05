using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    static class AreaCalculator
    {
        public static double circlesArea(List<Shape> shapesList, int dpi)
        {
            double area = 0;
            double cmPerInch = 2.54;
            foreach (Shape shape in shapesList)
            {
                if (shape.GetType() == typeof(MyCircle))
                    area += shape.CalculateArea();
            }
            area /= (dpi * dpi);
            area *= (cmPerInch * cmPerInch);
            return area;
        }

        public static double squaresArea(List<Shape> shapesList, int dpi)
        {
            double area = 0;
            double cmPerInch = 2.54;
            foreach (Shape shape in shapesList)
            {
                if (shape.GetType() == typeof(MySquare))
                    area += shape.CalculateArea();
            }
            area /= (dpi * dpi);
            area *= (cmPerInch * cmPerInch);
            return area;
        }

        public static double rectanglesArea(List<Shape> shapesList, int dpi)
        {
            double area = 0;
            double cmPerInch = 2.54;
            foreach (Shape shape in shapesList)
            {
                if (shape.GetType() == typeof(MyRectangle))
                    area += shape.CalculateArea();
            }
            area /= (dpi * dpi);
            area *= (cmPerInch * cmPerInch);
            return area;
        }
    }
}
