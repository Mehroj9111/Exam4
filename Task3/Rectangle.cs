namespace Task3;
public class Rectangle :Shape
{
    protected double _width = 1.0;
    protected double _length = 1.0;
    public Rectangle(){}
    public Rectangle(double width, double length)
    {
        _width = width;
        _length = length;
    }
    public Rectangle(double width, double length, Color color,bool filled)
    {
        _width = width;
        _length = length;
    }
    public double GetWidth()
    {
        return _width;
    }
    public void SetWidth(double width)
    {
        _width = width;
    }
    public double GetLength()
    {
        return _length;
    }
    public void SetLength(double length)
    {
        _length = length;
    }
    public double GetArea()
    {
        return _width*_length;
    }
    public double GetPerimeter()
    {
        return 2*(_width*_length);
    }
    public string ToString()
    {
        return $"Rectangle [Shape[{_color},{_filled}]{_width} {_length}]";
    }
}