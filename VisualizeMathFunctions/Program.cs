using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathFunctions;

namespace VisualizeMathFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            MathFunctionsClass mathFunctions = new MathFunctionsClass();
            Console.WriteLine($"{mathFunctions.Cube(Math.PI):F3}");
        }
    }
}
