using Shape;

namespace ShapeTest;
public class CircleTest
{
    [Theory]
    [InlineData(1.18)]
    public void GetSquareTest(double radius)
    {
        //// Arrange
        double expected = Math.PI * Math.Pow(radius, 2);
        IShape shape = new Circle(radius);

        //// Act
        var actual = shape.GetSquare();

        //// Assert
        Assert.Equal(expected, actual);
    }
}