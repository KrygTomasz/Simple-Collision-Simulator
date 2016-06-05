using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Shape
    {
        public Graphics Field { get; set; }
        public Color Colour { get; set; }
        public Point HoldPoint { get; set; }
        public Vector2D ShiftVector { get; set; }
        public bool collisionChecked { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public abstract Point MiddlePoint { get; }
        public abstract double Perimeter { get; }
        public abstract double CalculateArea();
        public abstract void Paint();

        public void moveShape()
        {
            int x = this.HoldPoint.X;
            int y = this.HoldPoint.Y;
            int newX = x + this.ShiftVector.X;
            int newY = y + this.ShiftVector.Y;
            int rightBound = (int)Field.VisibleClipBounds.Width;
            int bottomBound = (int)Field.VisibleClipBounds.Height;
            if (newX < 0) newX = 0;
            if (newX > rightBound - this.Width) newX = rightBound - this.Width;
            if (newY < 0) newY = 0;
            if (newY > bottomBound - this.Height) newY = bottomBound - this.Height;
            this.HoldPoint = new Point(newX, newY);
        }

        public void checkBoundariesCollision()
        {
            int rightBound = (int)Field.VisibleClipBounds.Width;
            int bottomBound = (int)Field.VisibleClipBounds.Height;
            if (this.HoldPoint.X <= 0)
            {
                this.ShiftVector.X = -this.ShiftVector.X;
            }
            if (this.HoldPoint.X >= rightBound - this.Width)
            {
                this.ShiftVector.X = -this.ShiftVector.X;
            }
            if (this.HoldPoint.Y <= 0)
            {
                this.ShiftVector.Y = -this.ShiftVector.Y;
            }
            if (this.HoldPoint.Y >= bottomBound - this.Height)
            {
                this.ShiftVector.Y = -this.ShiftVector.Y;
            }
        }

        public void checkCollisionWithShapeList(List<Shape> shapes)
        {
            foreach (Shape shape in shapes)
            {
                checkCollisionWithShape(shape);
            }
            foreach (Shape shape in shapes)
            {
                shape.collisionChecked = false;
            }
        }

        public void checkCollisionWithShape(Shape shape)
        {
            if (this != shape)
            {
                if (pointsDistance(this.MiddlePoint, shape.MiddlePoint) <= this.Width / 2 + shape.Width / 2 && this.collisionChecked==false && shape.collisionChecked==false)
                {
                    int temp1X = this.ShiftVector.X;
                    int temp1Y = this.ShiftVector.Y;
                    int temp2X = shape.ShiftVector.X;
                    int temp2Y = shape.ShiftVector.Y;
                    double area1 = this.CalculateArea();
                    double area2 = shape.CalculateArea();

                    Vector2D vectorAfterCollision = new Vector2D();

                    vectorAfterCollision.X = (int)((temp1X * (area1 - area2) + 2 * area2 * temp2X)/(area1+area2));
                    vectorAfterCollision.Y = (int)((temp1Y * (area1 - area2) + 2 * area2 * temp2Y) / (area1 + area2));
                    this.ShiftVector.X = vectorAfterCollision.X;
                    this.ShiftVector.Y = vectorAfterCollision.Y;
                    vectorAfterCollision.X = (int)((temp2X * (area2 - area1) + 2 * area1 * temp1X) / (area1 + area2));
                    vectorAfterCollision.Y = (int)((temp2Y * (area2 - area1) + 2 * area1 * temp1Y) / (area1 + area2));
                    shape.ShiftVector.X = vectorAfterCollision.X;
                    shape.ShiftVector.Y = vectorAfterCollision.Y;
                    this.collisionChecked = true;
                    shape.collisionChecked = true;
                }
            }
        }

        private double pointsDistance(Point x, Point y)
        {
            return Math.Sqrt(Math.Pow((x.X - y.X), 2) + Math.Pow((x.Y - y.Y), 2));
        }
    }
}
