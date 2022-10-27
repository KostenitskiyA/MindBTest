using Square�alculator.Figures;
using Xunit;

namespace SquareCalculator.Tests
{
    /// <summary>
    /// ������������ �������� ������ � ���������� � �������
    /// </summary>
    public class SquareCalculatorTest
    {
        /// <summary>
        /// ������������ �������� ����� � ���������� ��� ������� � ����������� ����������
        /// </summary>
        /// <param name="radius">������ �����</param>
        /// <param name="expected">��������� ������� �����</param>
        [Theory]
        [InlineData(2, 13)]
        [InlineData(3, 28)]
        [InlineData(5, 79)]
        public void CircleValidValuesTest(double radius, double expected)
        {
            // Arrange
            var circle = new Circle(radius);

            // Act
            var result = Math.Round(circle.CalculateSquare(), 0);

            // Assert
            Assert.Equal(expected, result);
        }

        /// <summary>
        /// ������������ �������� ����� � ������������� ����������
        /// </summary>
        /// <param name="radius">������ �����</param>
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void CircleInvalidValuesTest(double radius)
        {
            // Assert
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        /// <summary>
        /// ������������ �������� ������������ � ���������� ��� ������� � ����������� ����������
        /// </summary>
        /// <param name="sideA">����� ������� A</param>
        /// <param name="sideB">����� ������� B</param>
        /// <param name="sideC">����� ������� C</param>
        /// <param name="expected">��������� ������� ������������</param>
        [Theory]
        [InlineData(1, 3, 4, 0)]
        [InlineData(3, 4, 5, 6)]
        [InlineData(5, 5, 6, 12)]
        public void TriangleValidValuesTest(double sideA, double sideB, double sideC, double expected)
        {
            // Arrange
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            var result = triangle.CalculateSquare();

            // Assert
            Assert.Equal(expected, result);
        }

        /// <summary>
        /// ������������ �������� ������������ � ������������� ����������
        /// </summary>
        /// <param name="sideA">����� ������� A</param>
        /// <param name="sideB">����� ������� B</param>
        /// <param name="sideC">����� ������� C</param>
        [Theory]
        [InlineData(0, 3, 4)]
        [InlineData(-2, 3, 4)]
        public void TriangleInvalidValuesTest(double sideA, double sideB, double sideC)
        {
            // Assert
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        /// <summary>
        /// ������������ ������������ �� ��������������� :)
        /// </summary>
        /// <param name="sideA">����� ������� A</param>
        /// <param name="sideB">����� ������� B</param>
        /// <param name="sideC">����� ������� C</param>
        /// <param name="expected">��������� ���������������</param>
        [Theory]
        [InlineData(3, 4, 5, true)]
        [InlineData(2, 4, 4, false)]
        public void TriangleIsRightAngleTest(double sideA, double sideB, double sideC, bool expected)
        {
            // Arrange
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            var result = triangle.IsRightTriangle;

            // Assert
            Assert.Equal(expected, result);
        }
    }
}