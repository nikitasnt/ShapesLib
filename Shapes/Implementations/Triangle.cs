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

    /// <summary>
    /// Create a triangle by specifying sides.
    /// </summary>
    /// <param name="side1">First side of the triangle.</param>
    /// <param name="side2">Second side of the triangle.</param>
    /// <param name="side3">Third side of the triangle.</param>
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
        var p = (Side1 + Side2 + Side3) / 2d; // Half the perimeter.

        return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
    }

    /// <summary>
    /// Is the triangle a right triangle?
    /// </summary>
    /// <param name="tolerance">Since you need to compare the square of the hypotenuse and the sum of the squares of the
    /// legs, you need to introduce an acceptable tolerance due to the specificity of the <see cref="double"/> type.
    /// </param>
    /// <returns><see langword="true"/> if the triangle is right; otherwise <see langword="false"/>.</returns>
    public bool IsRight(double tolerance)
    {
        // The sides of the triangle are in ascending order.
        var sidesInAscendingOrder = new[] { Side1, Side2, Side3 };
        Array.Sort(sidesInAscendingOrder);
        
        // The first and second sides in the array are the legs, and the third is the hypotenuse.
        var leg1 = sidesInAscendingOrder[0];
        var leg2 = sidesInAscendingOrder[1];
        var hypotenuse = sidesInAscendingOrder[2];

        return Math.Abs(hypotenuse * hypotenuse - (leg1 * leg1 + leg2 * leg2)) < tolerance;
    }
}