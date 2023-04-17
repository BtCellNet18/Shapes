namespace Shapes.Model
{
	public class Circle : Shape
	{
		private readonly double _radius;

		public Circle(double radius)
		{
			if (radius <= 0) 
			{ 
				throw new ArgumentException(nameof(radius) + " must be positive");
			}

			_radius = radius;
		}

		public override string Name
		{
			get { return "Circle"; }
		}

		public override double Area
		{
			get { return Math.PI * _radius * _radius; }
		}

		public override double Perimeter
		{
			get { return 2 * Math.PI * _radius; }
		}
	}
}
