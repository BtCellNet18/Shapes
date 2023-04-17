namespace Shapes.Model
{
	public class Triangle : Shape
	{
		private readonly double _a;
		private readonly double _b;
		private readonly double _c;

		public Triangle(double a, double b, double c)
		{
			if (a <= 0)
			{
				throw new ArgumentException(nameof(a) + " must be positive");
			}

			if (b <= 0)
			{
				throw new ArgumentException(nameof(b) + " must be positive");
			}

			if (c <= 0)
			{
				throw new ArgumentException(nameof(c) + " must be positive");
			}

			_a = a;
			_b = b;
			_c = c;
		}

		public override string Name
		{
			get
			{
				if (_a.Equals(_b) && _b.Equals(_c))
				{
					return "Equilateral";
				}
				else if (_a.Equals(_b) || _b.Equals(_c) || _a.Equals(_c))
				{
					return "Isosceles";
				}
				else
				{
					return "Scalene";
				}
			}
		}

		public override double Area
		{
			get
			{
				double s = Perimeter / 2;
				return Math.Sqrt(s * (s - _a) * (s - _b) * (s - _c));
			}
		}

		public override double Perimeter
		{
			get { return (_a + _b + _c); }
		}
	}
}
