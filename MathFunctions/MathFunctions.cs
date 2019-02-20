using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunctions
{
    public class MathFunctionsClass
    {
        // Square is a function that takes a double and returns a double
        public double Square(double value)
        {
            return value * value;
        }

        public double Cube(double value)
        {
            return Math.Pow(value, 3);
        }
    }
}
