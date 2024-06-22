namespace Shape;
public class Circle : IShape
{
    private readonly double _radius;
    private const double pi = Math.PI;
    public Circle(double radius) { _radius = radius; }

    public double GetSquare() { return pi * Math.Pow(_radius, 2); }
}
