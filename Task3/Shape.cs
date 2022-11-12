abstract public class Shape
{
    public Color _color;
    public bool _filled = true;
    public Shape(){}
    public Shape(Color color, bool filled)
    {
      _color = color;
      _filled = filled;
    }
    public Enum GetColor()
    {
        return _color;
    }
    public void SetColor(Color color)
    {
        _color = color;
    }
    public abstract double GetArea();
    public abstract double GetPerimeter();
    public string ToString()
    {
        return $"Shape [{_color} {_filled} ]";
    }
}
public enum Color{
    Red,
    Blue,
    Yellow,
    Black
}