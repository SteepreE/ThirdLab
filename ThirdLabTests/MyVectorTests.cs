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
    public class MyVectorTests
    {
        [TestMethod()]
        public void SummTest()
        {
            var vec1 = new MyVector(1, 2, 3);
            var vec2 = new MyVector(6, 7, 9);

            Assert.AreEqual(vec1+vec2, new MyVector(7,9,12));
        }

        [TestMethod()]
        public void DiffTest()
        {
            var vec1 = new MyVector(1, 2, 3);
            var vec2 = new MyVector(6, 7, 9);

            Assert.AreEqual(vec1 - vec2, new MyVector(-5, -5, -6));
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            var vec1 = new MyVector(1, 2, 3);
            var vec2 = new MyVector(6, 7, 9);

            Assert.AreEqual(vec1 * vec2, 47);
        }

        [TestMethod()]
        public void CrossTest()
        {
            var vec1 = new MyVector(1, 2, 3);
            var vec2 = new MyVector(6, 7, 9);

            Assert.AreEqual(vec1.CrossProductWith(vec2), new MyVector(-3,9,-5));
        }

        [TestMethod()]
        public void LenTest()
        {
            var vec1 = new MyVector(1, 2, 3);

            Assert.AreEqual(Math.Round(vec1.Length(), 2), 3.74);
        }
    }
}