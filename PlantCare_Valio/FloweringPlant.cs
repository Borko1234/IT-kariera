using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class FloweringPlant : Plant
{
    private string color;

    public string Color
    {
        get {
            return color;
        }
        set {
            if (value.Length >= 3 && value.Length <= 30) color = value;
            else throw new ArgumentException("Color should be between 3 and 30 characters!");
        }
    }

    public FloweringPlant(int id, string name, string type, double humidityLevel, double fertilityLevel, string color) : base(id, name, "flower", humidityLevel, fertilityLevel) 
    {
        Color = color;
    }

    public override string ToString()
    {
        return base.ToString() + $"Color: {Color}\n";
    }
}
