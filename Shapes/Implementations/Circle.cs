using System.Diagnostics.CodeAnalysis;

namespace Shapes.Implementations;

/// <summary>
/// Circle.
/// </summary>
[SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
public class Circle : IShape
{
    /// <summary>
    /// Radius of the circle.
    /// </summary>
    public double Radius { get; }

    /// <summary>
    /// Create a circle by specifying a radius.
    /// </summary>
    /// <param name="radius">Radius of the circle.</param>
    public Circle(double radius)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(radius);
        Radius = radius;
    }

    /// <summary>
    /// Calculate the area of the circle.
    /// </summary>
    /// <returns>Area of the circle.</returns>
    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}