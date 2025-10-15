public class Circle : Shape
{
    private double _radius;

    public double GetRadius()
    {
        return _radius;
    }

    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    public Circle()
    {
    }

    public override double GetArea()
    {
        double pi = Math.PI;
        return pi * Math.Pow(_radius, 2);
    }
}