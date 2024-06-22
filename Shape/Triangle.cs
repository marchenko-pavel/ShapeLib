namespace Shape;
public class Triangle : IShape
{
    private readonly double _aSide;
    private readonly double _bSide;
    private readonly double _cSide;

    public Triangle(double aSide, double bSide, double cSide) { (_aSide, _bSide, _cSide) = (aSide, bSide, cSide); }

    public double GetSquare()
    {
        var per = GetPerimeter();
        return Math.Sqrt(per * (per - _aSide) * (per - _bSide) * (per - _cSide));
    }

    private double GetPerimeter() { return (_aSide + _bSide + _cSide) / 2; }

    public bool IsRectangular()
    {
        var sides = new double[] { _aSide, _bSide, _cSide };
        var bigSideVal = sides.Max();
        if (bigSideVal > 0)
        {
            var otherSideVal = sides
                .Where(x => x < bigSideVal)
                .Select(x => Math.Pow(x, 2))
                .Sum();
            return Math.Pow(bigSideVal, 2) == otherSideVal ? true : false;
        }
        else return false;
    }
}
