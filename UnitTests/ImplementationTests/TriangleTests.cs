using System.Diagnostics.CodeAnalysis;
using Shapes.Implementations;

namespace Tests.UnitTests.ImplementationTests;

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

    [Theory]
    [InlineData(3d, 4d, 5d)]
    [InlineData(5d, 12d, 13d)]
    [InlineData(8d, 15d, 17d)]
    public void IsRight_ShouldReturn_True_ForRightTriangle(double side1, double side2, double side3)
    {
        // Arrange.
        var triangle = new Triangle(side1, side2, side3);
        
        // Act.
        var result = triangle.IsRight(Constants.Tolerance);
        
        // Assert.
        Assert.True(result);
    }
    
    [Theory]
    [InlineData(3d, 4d, 6d)]
    [InlineData(5d, 12d, 14d)]
    [InlineData(8d, 15d, 18d)]
    public void IsRight_ShouldReturn_False_ForNotRightTriangle(double side1, double side2, double side3)
    {
        // Arrange.
        var triangle = new Triangle(side1, side2, side3);
        
        // Act.
        var result = triangle.IsRight(Constants.Tolerance);
        
        // Assert.
        Assert.False(result);
    }
}