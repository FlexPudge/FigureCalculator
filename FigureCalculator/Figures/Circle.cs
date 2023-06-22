using FigureCalculator.Service;

namespace FigureCalculator.Figures
{
    public class Circle : IArea
    {
        private double _radius;
        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentOutOfRangeException("Отрицательное значение радиуса");
            }
            _radius = radius;
        }
        public double Area()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
