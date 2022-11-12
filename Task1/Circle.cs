public class Circle
{
    public double _radius;
    public double _PI = 3.14;
    public Circle(){}
    public Circle(double radius)
    {
        _radius = radius;
    }
    public double GetRadius()
    {
        return _radius;
    }
    public void  SetRadius(double radius)
    {
      _radius = radius;
    }
    public double GetArea()
    {
        return  _PI*_radius*_radius;
    }
    public double GetCircumference()
    {
        return 2*_PI*_radius;
    }
    public string ToString()
    {
        return $"Circle {_radius}";
    }
}