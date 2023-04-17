namespace Shapes.Model
{
	public class Quadrilateral : Shape
	{
		private readonly double _width;
		private readonly double _length;

		public Quadrilateral(double width, double length)
		{
			if (width <= 0)
			{
				throw new ArgumentException(nameof(width) + " must be positive");
			}

			if (length <= 0)
			{
				throw new ArgumentException(nameof(length) + " must be positive");
			}

			_width = width;
			_length = length;
		}

		public override string Name
		{
			get
			{
				if (_width.Equals(_length))
				{
					return "Square";
				}
				else
				{
					return "Rectangle";
				}
			}
		}
		public override double Area
		{
			get { return _width * _length; }
		}

		public override double Perimeter
		{
			get { return (_width + _length) * 2; }
		}
	}
}
