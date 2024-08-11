using Shapes.Implementations;

namespace Tests.ImplementationTests;

public class TriangleTests
{
    [Theory]
    [InlineData(3d, 3d, 3d, 3.897114d)]
    public void GetArea_ShouldReturn_CorrectValue(double side1, double side2, double side3, double expectedArea)
    {
        // // Arrange.
        // var triangle = new Triangle { Side1 = side1, Side2 = side2, Side3 = side3 };
        //
        // // Act.
        // var area = triangle.GetArea();
        //
        // // Assert.
        // Assert.True(Math.Abs(expectedArea - area) < Constants.Tolerance);
    }
}