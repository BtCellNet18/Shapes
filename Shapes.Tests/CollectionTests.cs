using Shapes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Tests
{
	public class CollectionTests
	{
		[Fact]
		public void Sort_By_Area()
		{
			// Arrange
			List<double> expected = new List<double>()
			{
				0.4330127018922193,
				0.9682458365518543,
				2.9047375096555625,
				3.141592653589793,
				16, 30
			};

			// Act
			List<Shape> shapes = GetShapes().OrderBy(x => x.Area).ToList();
			List<double> actual = shapes.Select(x => x.Area).ToList();

			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void Sort_By_Perimeter()
		{
			// Arrange
			List<double> expected = new List<double>() { 3, 5, 6.283185307179586, 9, 16, 22 };

			// Act
			List<Shape> shapes = GetShapes().OrderBy(x => x.Perimeter).ToList();
			List<double> actual = shapes.Select(x => x.Perimeter).ToList();

			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void Count_Shapes_By_Class()
		{
			// Arrange
			Dictionary<string, int> expected = new Dictionary<string, int>() 
			{
				{ "Circle", 1 },
				{ "Triangle", 3 },
				{ "Quadrilateral", 2 }

			};

			// Act
			Dictionary<string, int> actual = GetShapes().GroupBy(x => x.GetType().Name)
				.ToDictionary(keySelector: g => g.Key, elementSelector: g => g.Count());

			// Assert
			Assert.Equal(expected, actual);
		}

		private List<Shape> GetShapes() 
		{
			return new List<Shape>() {
				new Circle(1),
				new Triangle(1, 1, 1),
				new Triangle(1, 2, 2),
				new Triangle(2, 3, 4),
				new Quadrilateral(4, 4),
				new Quadrilateral(5, 6)
			};
		}
	}
}
