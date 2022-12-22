
using Lab4Geometric.Classes;

var shapeList = new List<Shape>();

shapeList.Add(new Triangle() { Height = 5, SideLenght = 10 });
shapeList.Add(new Triangle() { Height = 3, SideLenght = 4 });
shapeList.Add(new Rectangle() { SideLenght = 8 });
shapeList.Add(new Rectangle() { SideLenght = 5 });
shapeList.Add(new Circle() { Radius = 3 });

foreach (var sh in shapeList)
{
    Console.WriteLine(sh.Perimeter());
    Console.WriteLine(sh.Square());
    Console.WriteLine();
}
