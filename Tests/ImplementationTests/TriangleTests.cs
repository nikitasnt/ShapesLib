using System.Diagnostics.CodeAnalysis;
using Shapes.Implementations;

namespace Tests.ImplementationTests;

[SuppressMessage("ReSharper", "ConvertToLocalFunction")]
public class TriangleTests
{
    [Theory]
    [InlineData(3d, 3d, 3d, 3.897114d)]
    [InlineData(22.155d, 34.657d, 12.543d, 14.037223d)]
    [InlineData(10d, 15d, 20d, 72.618438d)]
    public void GetArea_ShouldReturn_CorrectValue(double side1, double side2, double side3, double expectedArea)
    {
        // Arrange.
        var triangle = new Triangle(side1, side2, side3);
        
        // Act.
        var area = triangle.GetArea();
        
        // Assert.
        Assert.True(Math.Abs(expectedArea - area) < Constants.Tolerance);
    }

    [Theory]
    [InlineData(0d, 0d, 0d)]
    [InlineData(-1d, 3d, 3d)]
    [InlineData(3d, -1d, -1d)]
    [InlineData(-1d, 3d, -1d)]
    [InlineData(-1d, -1d, -1d)]
    public void Constructor_ShouldThrowException_ForBadSide(double side1, double side2, double side3)
    {
        // Arrange.
        // Isn't needed.

        // Act.
        var act = () => new Triangle(side1, side2, side3);

        // Assert.
        Assert.Throws<ArgumentOutOfRangeException>(act);
    }

    [Theory]
    [InlineData(1d, 1d, 10d)]
    [InlineData(1d, 10d, 1d)]
    [InlineData(10d, 1d, 1d)]
    public void Constructor_ShouldThrowException_ForNonExistentTriangleBySides(double side1, double side2, double side3)
    {
        // Arrange.
        // Isn't needed.

        // Act.
        var act = () => new Triangle(side1, side2, side3);

        // Assert.
        Assert.Throws<ArgumentException>(act);
    }
}