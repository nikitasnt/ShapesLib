using System.Diagnostics.CodeAnalysis;
using Shapes.Implementations;

namespace Tests.ImplementationTests;

[SuppressMessage("ReSharper", "ConvertToLocalFunction")]
public class CircleTests
{
    /// <summary>
    /// Due to the nature of <see cref="double"/>, there needs to be a tolerance up to which results and expected values
    /// are equivalent.
    /// </summary>
    private const double Tolerance = 0.000001d;
    
    [Theory]
    [InlineData(3d, 28.274334d)]
    [InlineData(10.111d, 321.172309d)]
    [InlineData(123.456d, 47882.219804d)]
    public void GetArea_ShouldReturn_CorrectValue(double radius, double expectedArea)
    {
        // Arrange.
        var circle = new Circle { Radius = radius };

        // Act.
        var area = circle.GetArea();

        // Assert.
        Assert.True(Math.Abs(expectedArea - area) < Tolerance);
    }

    [Theory]
    [InlineData(0d)]
    [InlineData(-1d)]
    [InlineData(-123.456d)]
    public void RadiusSetter_ShouldThrowException_ForBadRadius(double badRadius)
    {
        // Arrange.
        var circle = new Circle { Radius = 1d };
        
        // Act.
        Action act = () => circle.Radius = badRadius;
        
        // Assert.
        Assert.Throws<ArgumentOutOfRangeException>(act);
    }
}