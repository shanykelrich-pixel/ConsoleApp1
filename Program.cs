using ConsoleApp1;

Console.WriteLine("Hello, World!");
static void Main(string[] args)
{
    Rectangle rectangle = new Rectangle(10, 5);
    Circle circle = new Circle(7);
    Triangle triangle = new Triangle(3, 4, 5);

    List<Shape> shapes = new List<Shape>();

    shapes.Add(rectangle);
    shapes.Add(circle);
    shapes.Add(triangle);

    foreach (Shape shape in shapes)
    {
        Console.WriteLine(shape);
    }

    rectangle.Sharpen();
    triangle.Sharpen();
}
