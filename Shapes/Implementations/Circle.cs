namespace Shapes.Implementations;

/// <summary>
/// Circle.
/// </summary>
public class Circle : IShape
{
    /// <summary>
    /// Radius of the circle.
    /// </summary>
    public double Radius { get; set; }
    
    /// <summary>
    /// Calculate the area of the circle.
    /// </summary>
    /// <returns>Area of the circle.</returns>
    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}