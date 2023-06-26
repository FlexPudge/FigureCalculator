using FigureCalculator.Figures;

namespace FigureCalculatorTest
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void AreaTrianglResult()
        {
            Triangle triangle = new Triangle(5, 5, 6);
            double result = triangle.Area();
            Assert.AreEqual(12, result);
        }
        [TestMethod]
        public void ExistenceTriangleСheck()
        {
            Triangle triangle = new Triangle(1, 5, 7);
            double result = triangle.Area();
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void RectangularTriangleСheck()
        {
            Triangle triangle = new Triangle(4, 5, 3);
            bool result = triangle.IsRightTringle();
            Assert.AreEqual(false, result);
        }
    }
}
