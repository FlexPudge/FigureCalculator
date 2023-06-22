using FigureCalculator.Service;
using System;

namespace FigureCalculator.Figures
{
    public class Triangle : IArea
    {
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide < 0 || secondSide < 0 || thirdSide < 0)
            {
                throw new ArgumentOutOfRangeException("Одна из сторон имеет отрицательное значение");
            }
            if (firstSide + secondSide <= thirdSide || firstSide + thirdSide <= secondSide || secondSide + thirdSide <= firstSide)
            {
                throw new ArgumentException("Это не треугольник");
            }
            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
        }
        public double Area()
        {
            double p = (_firstSide + _secondSide + _thirdSide) / 2;
            double s = Math.Sqrt(p * (p - _firstSide) * (p - _secondSide) * (p - _thirdSide));
            return s;
        }
        public bool IsRightTringle()
        {
            if ((Math.Pow(_firstSide, 2) + Math.Pow(_secondSide, 2)) == Math.Pow(_thirdSide, 2))
            {
                return true;
            }
            return false;
        }
    }
}
