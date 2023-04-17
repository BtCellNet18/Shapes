using Shapes;
using Shapes.Model;

static List<Shape> GetShapes()
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

try
{
	List<Shape> shapes = GetShapes();

	List<Shape> orderedByArea = shapes.OrderBy(x => x.Area).ToList();
	List<Shape> orderedByPerimeter = shapes.OrderBy(x => x.Perimeter).ToList();

	Dictionary<string, int> shapeCount = shapes.GroupBy(x => x.GetType().Name)
		.ToDictionary(keySelector: g => g.Key, elementSelector: g => g.Count());

	ShapeFile shapeFile = new ShapeFile(new JsonFormatter());
	shapeFile.Save(shapes, "c:\\Output\\Shapes.json");
}
catch (Exception ex)
{
	Console.WriteLine(ex);
}

Console.WriteLine("Done!");