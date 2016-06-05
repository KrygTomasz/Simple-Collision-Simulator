using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shapes
{
    static class RandomColorFactory
    {
        //private static Random random = new Random();

        public static Color create()
        {
            RandomSingleton randomSingleton = RandomSingleton.Instance;
            int red = randomSingleton.Random.Next(256);
            int green = randomSingleton.Random.Next(256);
            int blue = randomSingleton.Random.Next(256);
            return Color.FromArgb(red, green, blue);
        }
    }
}
