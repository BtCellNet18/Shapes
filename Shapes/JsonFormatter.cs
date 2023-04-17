using Shapes.Interfaces;
using Shapes.Model;
using System.Text.Json;

namespace Shapes
{
	public class JsonFormatter : IFormatShape
	{
		public string Format(List<Shape> shapes)
		{
			return JsonSerializer.Serialize(shapes);
		}
	}
}
