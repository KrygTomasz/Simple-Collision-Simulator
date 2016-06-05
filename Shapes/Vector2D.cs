using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Vector2D
    {
        //public List<int> coordinates { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Vector2D()
        {
            //coordinates = new List<int>();
            //for(int i = 0; i < dimension; i++)
            //{
            //    coordinates.Add(0);
            //}
            X = 0;
            Y = 0;
        }

        public Vector2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void randomize(int minShift, int maxShift)
        {
            RandomSingleton randomSingleton = RandomSingleton.Instance;
            //int dimension = coordinates.Count;
            //for (int i = 0; i < dimension; i++)
            //{
                X = randomSingleton.Random.Next(minShift, maxShift);
                Y = randomSingleton.Random.Next(minShift, maxShift);
            //}
        }
    }
}
