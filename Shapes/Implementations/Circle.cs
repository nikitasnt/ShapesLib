﻿namespace Shapes.Implementations;

public class Circle : IShape
{
    public double Radius { get; set; }
    
    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}