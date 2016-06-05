using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shapes
{
    class MyCircle : Shape
    {
        public MyCircle(int circleDiameter)
        {
            Width = circleDiameter;
            Height = circleDiameter;
            Colour = Color.Blue;
            HoldPoint = new Point(10,10);
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
                return Math.PI * (Width/2 + Height/2); 
            }
        }

        public override double CalculateArea()
        {
            return Math.PI*Width/2*Height/2;
        }

        public override void Paint()
        {
            Field.DrawEllipse(new Pen(Colour),new Rectangle(HoldPoint,new Size(Width,Height)));
        }

    }
}
