public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public double Length
    {
        get { return _length; }
    }

    public double SetLength(double length)
    {
        _length = length;
        return _length;
    }

    public double Width
    {
        get { return _width; }
    }

    public double SetWidth(double width)
    {
        _width = width;
        return _width;
    }

    public Rectangle()
    {

    }

    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _width * _length;
    }
}