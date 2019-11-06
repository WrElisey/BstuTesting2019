using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Lab3
{
    [TestFixture]
    public class TriangleTest
    {
        [Test]
        public void CorrectTriangleTest()
        {
            bool expected = Triangle.IsExists(1, 1, 1);
            Assert.IsTrue(expected);
        }

        [TestCase(200, 1, 300)]
        public void IncorrectTriangleTest(float a, float b, float c)
        {
            bool expected = Triangle.IsExists(a, b, c);
            Assert.IsTrue(!expected);
        }

        [TestCase(1.1f, 2.2f, 3.3f, ExpectedResult = true)]
        [TestCase(287, 450, 200, ExpectedResult = true)]
        [TestCase(368, 250, 200, ExpectedResult = true)]
        [TestCase(546, 708, 200, ExpectedResult = true)]
        [TestCase(0, 0, 0, ExpectedResult = false)]
        [TestCase(5.1f, 1.2f, 3.3f, ExpectedResult = false)]
        [TestCase(546, 708, 98, ExpectedResult = false)]
        [TestCase(368, 250, 900, ExpectedResult = false)]
        [TestCase(234, 2301, 200, ExpectedResult = false)]
        [TestCase(776, 221, 200, ExpectedResult = false)]
        [TestCase(133, 2275, 32, ExpectedResult = false)]
        public bool MultiCaseTrinagleTestSequence(float a, float b, float c)
        {
            bool expected = Triangle.IsExists(a, b, c);
            return expected;
        }
    }
}
