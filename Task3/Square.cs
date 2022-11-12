namespace Task3;
public class Square:Rectangle
{
    protected double _side = 1.0;
    public Square(){}
    public Square(double side )
    {
    _side = side;
    }
    public Square(double side,Color color,bool filled )
    {
     _side = side;
    }
    public double GetSide()
    {
        return _side;
    }
    public void SetSide(double side)
    {
        _side = side;
    }
    public void SetWidth(double side)
    {
     _width = side; 
    }
    public void SetLength(double side)
    {
     _length = side;
    }
    public string ToString()
    {
        return $"Square [ Rectangle [ Shape [{_color} {_filled}], {_width},{_length} ] ]";
    }

}