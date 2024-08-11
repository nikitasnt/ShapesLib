namespace Shapes.Implementations;

/// <summary>
/// Triangle.
/// </summary>
public class Triangle : IShape
{
    /// <summary>
    /// The first side of the triangle.
    /// </summary>
    public double Side1 { get; set; }
    
    /// <summary>
    /// The second side of the triangle.
    /// </summary>
    public double Side2 { get; set; }
    
    /// <summary>
    /// The third side of the triangle.
    /// </summary>
    public double Side3 { get; set; }
    
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