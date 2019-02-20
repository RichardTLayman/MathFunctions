using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunctions.Tests
{
    [TestClass()]
    public class MathFunctionsClassTests
    {
        MathFunctionsClass objectUnderTest = new MathFunctionsClass();

        [TestMethod()]
        public void SquareTest()
        {
            Assert.AreEqual(36, objectUnderTest.Square(-6));
            Assert.AreEqual(0, objectUnderTest.Square(0));
            Assert.AreEqual(4, objectUnderTest.Square(2));
        }

        [TestMethod()]
        public void CubeTest()
        {
            Assert.AreEqual(8, objectUnderTest.Cube(2));
        }
    }
}