using Shapes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace Shapes.Tests
{
	public class TriangleTests
	{
		[Fact]
		public void Negative_Side_A_Throws_ArgumentException()
		{
			// Arrange
			// Act
			// Assert
			Assert.Throws<ArgumentException>(() => new Triangle(-1, 1, 1));
		}

		[Fact]
		public void Negative_Side_B_Throws_ArgumentException()
		{
			// Arrange
			// Act
			// Assert
			Assert.Throws<ArgumentException>(() => new Triangle(1, -1, 1));
		}

		[Fact]
		public void Negative_Side_C_Throws_ArgumentException()
		{
			// Arrange
			// Act
			// Assert
			Assert.Throws<ArgumentException>(() => new Triangle(1, 1, -1));
		}

		[Fact]
		public void Positive_Valid_Sides_Calculates_Area()
		{
			// Arrange
			double expected = 0.4330127018922193;
			// Act
			Triangle triangle = new Triangle(1, 1, 1);
			// Assert
			Assert.Equal(expected, triangle.Area);
		}

		[Fact]
		public void Positive_Valid_Sides_Calculates_Perimiter()
		{
			// Arrange
			double expected = 3;
			// Act
			Triangle triangle = new Triangle(1, 1, 1);
			// Assert
			Assert.Equal(expected, triangle.Perimeter);
		}

		[Fact]
		public void Three_Sides_Equal()
		{
			// Arrange
			string expected = "Equilateral";
			// Act
			Triangle triangle = new Triangle(1, 1, 1);
			// Assert
			Assert.Equal(expected, triangle.Name);
		}

		[Fact]
		public void Two_Sides_Equal()
		{
			// Arrange
			string expected = "Isosceles";
			// Act
			Triangle triangle = new Triangle(1, 2, 2);
			// Assert
			Assert.Equal(expected, triangle.Name);
		}

		[Fact]
		public void No_Sides_Equal()
		{
			// Arrange
			string expected = "Scalene";
			// Act
			Triangle triangle = new Triangle(2, 3, 4);
			// Assert
			Assert.Equal(expected, triangle.Name);
		}
	}
}
