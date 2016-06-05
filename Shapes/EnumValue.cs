using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    static class EnumValue
    {
        public enum values
        {
            Circle, Rectangle, Square,
            minShapeSize = 20,
            maxShapeSize = 50,
            minVectorShift = -10,
            maxVectorShift = 11
        }
    }
}
