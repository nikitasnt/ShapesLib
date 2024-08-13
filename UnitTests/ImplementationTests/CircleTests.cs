using System.Diagnostics.CodeAnalysis;
using Shapes.Implementations;

namespace Tests.UnitTests.ImplementationTests;

[SuppressMessage("ReSharper", "ConvertToLocalFunction")]
public class CircleTests
{
    [Theory]
    [InlineData(3d, 28.274334d)]
    [InlineData(10.111d, 321.172309d)]
    [InlineData(123.456d, 47882.219804d)]
    public void GetArea_ShouldReturn_CorrectValue(double radius, double expectedArea)
    {
        // Arrange.
        var circle = new Circle(radius);

        // Act.
        var area = circle.GetArea();

        // Assert.
        Assert.True(Math.Abs(expectedArea - area) < Constants.Tolerance);
    }

    [Theory]
    [InlineData(0d)]
    [InlineData(-1d)]
    [InlineData(-123.456d)]
    public void Constructor_ShouldThrowException_ForBadRadius(double badRadius)
    {
        // Arrange.
        // Isn't needed.

        // Act.
        var act = () => new Circle(badRadius);
        
        // Assert.
        Assert.Throws<ArgumentOutOfRangeException>(act);
    }
}