using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shapes
{
    class MyRectangle : Shape
    {
        public MyRectangle(int rectWidth, int rectHeight)
        {
            Height = rectHeight;
            Width = rectWidth;
            Colour = Color.Blue;
            HoldPoint = new Point(10, 10);
            ShiftVector = new Vector2D();
            ShiftVector.randomize((int)EnumValue.values.minVectorShift, (int)EnumValue.values.maxVectorShift);
        }

        public override Point MiddlePoint
        {
            get
            {
                return new Point(HoldPoint.X + Width / 2, HoldPoint.Y + Height / 2);
            }
        }

        public override double Perimeter
        {
            get
            {
                return 2 * Height + 2 * Width;
            }
        }

        public override double CalculateArea()
        {
            return Height * Width;
        }

        public override void Paint()
        {
            Size size = new Size(Width, Height);
            Rectangle rectangle = new Rectangle(HoldPoint, size);
            Field.DrawRectangle(new Pen(Colour), rectangle);
        }
    }
}
