using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    static class RandomShapeFactory
    {
        //private static Random random = new Random();
        enum shapeTypes
        {
            Circle, Rectangle, Square
        }
        
        public static Shape createRandomShapeObject()
        {
            RandomSingleton randomSingleton = RandomSingleton.Instance;
            Array values = Enum.GetValues(typeof(shapeTypes));
            shapeTypes randomShape = (shapeTypes)values.GetValue(randomSingleton.Random.Next(values.Length));
            return createShapeObject(randomShape);
        }

        private static Shape createShapeObject(shapeTypes shapeType)
        {
            RandomSingleton randomSingleton = RandomSingleton.Instance;
            Shape shape = null;
            switch (shapeType)
            {
                case shapeTypes.Circle:
                    int radius = randomSingleton.Random.Next((int)EnumValue.values.minShapeSize, (int)EnumValue.values.maxShapeSize);
                    shape = new MyCircle(radius);
                    break;
                case shapeTypes.Rectangle:
                    int width = randomSingleton.Random.Next((int)EnumValue.values.minShapeSize, (int)EnumValue.values.maxShapeSize);
                    int height = randomSingleton.Random.Next((int)EnumValue.values.minShapeSize, (int)EnumValue.values.maxShapeSize);
                    shape = new MyRectangle(width, height);
                    break;
                case shapeTypes.Square:
                    width = randomSingleton.Random.Next((int)EnumValue.values.minShapeSize, (int)EnumValue.values.maxShapeSize);
                    shape = new MySquare(width);
                    break;
                default:
                    break;
            }
            shape.Colour = RandomColorFactory.create();//randomColor();
            return shape;
        }
    }
}
