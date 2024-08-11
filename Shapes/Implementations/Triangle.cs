namespace Shapes.Implementations;

public class Triangle : IShape
{
    public double Side1 { get; set; }
    
    public double Side2 { get; set; }
    
    public double Side3 { get; set; }
    
    public double GetArea()
    {
        var p = (Side1 + Side2 + Side3) / 2; // Half the perimeter.

        return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
    }
}