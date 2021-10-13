using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThirdLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLab.Tests
{
    [TestClass()]
    public class CoordinatesTests
    {
        [TestMethod()]
        public void SummTest()
        {
            var coordinates1 = new Coordinates(1, 2, 3);
            var coordinates2 = new Coordinates(1, 2, 3);

            Assert.AreEqual(coordinates1 + coordinates2, new Coordinates(2, 4, 6));
        }

        [TestMethod()]
        public void DiffTest()
        {
            var coordinates1 = new Coordinates(1, 2, 3);
            var coordinates2 = new Coordinates(1, 2, 3);

            Assert.AreEqual(coordinates1 - coordinates2, new Coordinates(0,0,0));
        }
    }
}