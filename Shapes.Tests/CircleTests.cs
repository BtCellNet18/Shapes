using Shapes.Model;

namespace Shapes.Tests
{
	public class CircleTests
	{
		[Fact]
		public void Negative_Radius_Throws_ArgumentException()
		{
			// Arrange
			// Act
			// Assert
			Assert.Throws<ArgumentException>(() => new Circle(-1));
		}

		[Fact]
		public void Positive_Radius_Calculates_Area()
		{
			// Arrange
			double expected = 3.141592653589793;
			// Act
			Circle circle = new Circle(1);
			// Assert
			Assert.Equal(expected, circle.Area);
		}

		[Fact]
		public void Positive_Radius_Calculates_Perimeter()
		{
			// Arrange
			double expected = 6.283185307179586;
			// Act
			Circle circle = new Circle(1);
			// Assert
			Assert.Equal(expected, circle.Perimeter);
		}
	}
}