using Shape;

namespace ShapeTest;
public class TriangelTest
{
    [Theory]
    [InlineData(3, 4, 5)]
    public void GetSquareTest(double aSide, double bSide, double cSide)
    {
        //// Arrange
        double expected = 6;
        IShape shape = new Triangle(aSide, bSide, cSide);

        //// Act
        var actual = shape.GetSquare();

        //// Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(3, 4, 5)]
    public void IsRectangularTest(double aSide, double bSide, double cSide)
    {
        //// Arrange
        bool expected = true;
        Triangle shape = new Triangle(aSide, bSide, cSide);

        //// Act
        var actual = shape.IsRectangular();

        //// Assert
        Assert.Equal(expected, actual);
    }
}
