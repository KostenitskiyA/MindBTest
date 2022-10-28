namespace SquareСalculator.Figures
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : Figure
    {
        /// <summary>
        /// Массив сторон треугольника
        /// </summary>
        private readonly double[] _sides;

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        private readonly bool _isRightTriangle;

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool IsRightTriangle { get { return _isRightTriangle; } }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="sideA">Сторона A</param>
        /// <param name="sideB">Сторона B</param>
        /// <param name="sideC">Сторона C</param>
        /// <exception cref="ArgumentException">Ни одна из сторон не может равняться нуню или иметь отрицательное значение</exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA == 0
                || sideA < 0
                || sideB == 0
                || sideB < 0
                || sideC == 0
                || sideC < 0)
                throw new ArgumentException();

            _sides = new double[] { sideA, sideB, sideC };
            _isRightTriangle = RightTriangleCheck();
        }

        /// <summary>
        /// Проверка треугольника на прямоугольность
        /// </summary>
        /// <returns>Является ли прямоугольным</returns>
        private bool RightTriangleCheck()
        {
            var maxSide = _sides.Max();
            var otherSides = _sides.ToList();
            otherSides.Remove(maxSide);

            return Math.Pow(otherSides[0], 2) 
                + Math.Pow(otherSides[1], 2) 
                == Math.Pow(maxSide, 2);
        }

        /// <summary>
        /// Вычисление площади треугольника
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        public sealed override double CalculateSquare()
        {
            var semiPerimeter = (_sides[0] + _sides[1] + _sides[2]) / 2;

            _square = Math.Sqrt(semiPerimeter
                * (semiPerimeter - _sides[0])
                * (semiPerimeter - _sides[1])
                * (semiPerimeter - _sides[2]));

            return _square;
        }
    }
}
