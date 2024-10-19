using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class TreePlant : Plant
{
    private int height;

    public int Height
    {
        get {
            return height;
        }
        set {
            if (value > 0) height = value;
            else throw new ArgumentException("Height should be positive!");
        }
    }

    public TreePlant(int id, string name, string type, double humidityLevel, double fertilityLevel, int height)
        : base(id, name, "tree", humidityLevel, fertilityLevel)
    {
        Height = height;
    }

    public override string ToString()
    {
        return base.ToString() + $"Height: {Height}";
    }
}

