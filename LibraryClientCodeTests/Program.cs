/*
 * Here we present testing of the library as the code of a certain client (user) of this library in a console
 * application.
 */

using Shapes;
using Shapes.Implementations;

namespace Tests.LibraryClientCodeTests;

internal static class Program
{
    // The client creates his own figure.
    private class Square(double side) : IShape
    {
        public double Side { get; } = side;

        public double GetArea()
        {
            return Side * Side;
        }
    }

    // Client method that returns a random shape.
    private static IShape GetRandomShape()
    {
        var random = new Random();
        
        return random.Next(0, 3) switch
        {
            0 => new Circle(1),
            1 => new Triangle(1, 1, 1),
            2 => new Square(1),
            _ => throw new ArgumentOutOfRangeException()
        };
    }
    
    private static void Main()
    {
        var randomShape = GetRandomShape();
        
        // Calculating the area of a shape whose type is not known in compile-time.
        var shapeArea = randomShape.GetArea();
        
        Console.WriteLine($"Shape type name: {randomShape.GetType().Name}. Its area: {shapeArea}.");
    }
}