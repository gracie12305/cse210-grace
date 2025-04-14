using System;
using System.Drawing;

public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }
    
    public string GetColor()
    {
        return _color;
    }

    public void Shape.SetColor(string color);
    {
        _color = color;

    }

    public abstract double GetArea();
}
