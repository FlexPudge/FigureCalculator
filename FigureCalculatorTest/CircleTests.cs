using FigureCalculator.Figures;

namespace FigureCalculatorTest
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void AreaCircleResult()
        {
            Circle circle = new Circle(5);
            double result = circle.Area();
            Assert.AreEqual(78.54, Math.Round(result, 2));
        }
    }
}