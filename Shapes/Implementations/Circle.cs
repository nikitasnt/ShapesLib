namespace Shapes.Implementations;

/// <summary>
/// Circle.
/// </summary>
public class Circle : IShape
{
    private double _radius;
    
    /// <summary>
    /// Radius of the circle.
    /// </summary>
    public double Radius
    {
        get => _radius;
        set
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value);
            _radius = value;
        }
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