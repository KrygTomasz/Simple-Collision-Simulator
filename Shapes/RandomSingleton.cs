using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class RandomSingleton
    {
        public static RandomSingleton instance;
        public Random Random { get; private set; }
        private RandomSingleton()
        {
            Random = new Random();
        }

        public static RandomSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RandomSingleton();
                }
                return instance;
            }
        }
    }
}
