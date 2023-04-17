using Shapes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Tests
{
	public class QuadrilateralTests
	{
		[Fact]
		public void Negative_Length_Throws_ArgumentException()
		{
			// Arrange
			// Act
			// Assert
			Assert.Throws<ArgumentException>(() => new Quadrilateral(1, -1));
		}

		[Fact]
		public void Negative_Width_Throws_ArgumentException()
		{
			// Arrange
			// Act
			// Assert
			Assert.Throws<ArgumentException>(() => new Quadrilateral(1, -1));
		}

		[Fact]
		public void Positive_Width_And_Length_Calculates_Area()
		{
			// Arrange
			double expected = 16;
			// Act
			Quadrilateral quadrilateral = new Quadrilateral(4, 4);
			// Assert
			Assert.Equal(expected, quadrilateral.Area);
		}

		[Fact]
		public void Positive_Width_And_Length_Calculates_Perimeter()
		{
			// Arrange
			double expected = 22;
			// Act
			Quadrilateral quadrilateral = new Quadrilateral(5, 6);
			// Assert
			Assert.Equal(expected, quadrilateral.Perimeter);
		}

		[Fact]
		public void Width_And_Length_Equal()
		{
			// Arrange
			string expected = "Square";
			// Act
			Quadrilateral quadrilateral = new Quadrilateral(4, 4);
			// Assert
			Assert.Equal(expected, quadrilateral.Name);
		}

		[Fact]
		public void Width_And_Length_Not_Equal()
		{
			// Arrange
			string expected = "Rectangle";
			// Act
			Quadrilateral quadrilateral = new Quadrilateral(5, 6);
			// Assert
			Assert.Equal(expected, quadrilateral.Name);
		}
	}
}
