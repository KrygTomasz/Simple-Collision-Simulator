using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shapes
{
    class Line
    {
        private double a;
        private double b;
        private double c;

        public Line(double a, double b, double c) //linia postaci ax + by + c = 0
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public Line(Point x, Point y)
        {
            //(y.X-x.X)*(y-x.Y)=(y.Y-x.Y)*(x-x.X);
            this.a = -(y.Y - x.Y);
            this.b = (y.X - x.X);
            this.c = b * (-x.Y) + a * (-x.X);
        }

        //public Point mirrorPoint(Point point)
        //{
        //    Line normalLine = this.normalLineThroughPoint(point);
        // //teraz trzeba wyznaczyc układ równań: this i normalLine
        //}

        public Line normalLineThroughPoint(Point point)
        {
            double a = 1 / this.a;
            double b = 1 / this.b;
            double c = a * point.X - b * point.Y;
            return new Line(a, b, c);
            //return normalLine;
        }
    }
}
