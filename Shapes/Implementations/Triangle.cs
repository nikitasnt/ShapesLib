namespace Shapes.Implementations;

/// <summary>
/// Triangle.
/// </summary>
public class Triangle : IShape
{
    private double _side1;
    private double _side2;
    private double _side3;
    
    /// <summary>
    /// The first side of the triangle.
    /// </summary>
    public required double Side1
    {
        get => _side1;
        set
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value);
            _side1 = value;
        }
    }

    /// <summary>
    /// The second side of the triangle.
    /// </summary>
    public required double Side2
    {
        get => _side2;
        set
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value);
            _side2 = value;
        }
    }
    
    /// <summary>
    /// The third side of the triangle.
    /// </summary>
    public required double Side3
    {
        get => _side3;
        set
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value);
            _side3 = value;
        }
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