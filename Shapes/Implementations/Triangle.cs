using System.Diagnostics.CodeAnalysis;

namespace Shapes.Implementations;

/// <summary>
/// Triangle.
/// </summary>
[SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
public class Triangle : IShape
{
    /// <summary>
    /// The first side of the triangle.
    /// </summary>
    public double Side1 { get; }

    /// <summary>
    /// The second side of the triangle.
    /// </summary>
    public double Side2 { get; }
    
    /// <summary>
    /// The third side of the triangle.
    /// </summary>
    public double Side3 { get; }

    public Triangle(double side1, double side2, double side3)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(side1);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(side2);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(side3);

        if (!CanBeCreatedFrom(side1, side2, side3))
        {
            throw new ArgumentException(
                "You cannot create a triangle in which one side is greater than the sum of the other two sides.");
        }
        
        Side1 = side1;
        Side2 = side2;
        Side3 = side3;
    }

    private static bool CanBeCreatedFrom(double side1, double side2, double side3)
    {
        return side1 + side2 > side3 && side2 + side3 > side1 && side3 + side1 > side2;
    }
    
    /// <summary>
    /// Calculate the area of the triangle.
    /// </summary>
    /// <returns>Area of the triangle.</returns>
    public double GetArea()
    {
        var p = (Side1 + Side2 + Side3) / 2; // Half the perimeter.

        return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
    }
}