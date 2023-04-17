using Shapes.Interfaces;
using Shapes.Model;

namespace Shapes
{
	public class ShapeFile
	{
		private readonly IFormatShape _formatter;
		public ShapeFile(IFormatShape formatter)
		{
			_formatter = formatter;
		}

		public void Save(List<Shape> shapes, string path) 
		{
			if (File.Exists(path))
			{
				File.Delete(path);
			}

			string contents = _formatter.Format(shapes);
			File.WriteAllText(path, contents);
		}
	}
}
