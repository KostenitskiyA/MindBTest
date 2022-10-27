namespace SquareСalculator.Figures
{
    /// <summary>
    /// Фигура
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Площадь фигуры
        /// </summary>
        protected double _square;

        /// <summary>
        /// Вычисление площади фигуры
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        public abstract double CalculateSquare();
    }
}