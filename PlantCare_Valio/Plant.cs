using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public abstract class Plant
{
    private int id;

    public int Id
    {
        get {
            return id;
        }
        set {
            id = value;
        }
    }

    private string name;

    public string Name
    {
        get {
            return name;
        }
        set
        {
            if (value.Length >= 3 && value.Length <= 30) name = value;
            else throw new ArgumentException("Name should be between 3 and 30 characters!");
        }
    }

    private string type;

    public string Type
    {
        get
        {
            return type;
        }
        set
        {
            if (value.Length >= 3 && value.Length <= 30) type = value;
            else throw new ArgumentException("Type should be between 3 and 30 characters!");
        }
    }

    private List<CareItem> careItems;

    private double humidityLevel;

    public double HumidityLevel
    {
        get
        {
            return humidityLevel;
        }
        set
        {
            if (value >= 0 && value <= 1) humidityLevel = value;
            else throw new ArgumentException("Humidity Level should be between 0 and 1!");
        }
    }


    private double fertilityLevel;

    public double FertilityLevel
    {
        get
        {
            return fertilityLevel;
        }
        set
        {
            if (value >= 0 && value <= 1) fertilityLevel = value;
            else throw new ArgumentException("Fertility Level should be between 0 and 1!");
        }
    }

    public Plant(int id, string name, string type, double humidityLevel, double fertilityLevel)
    {
        Id = id;
        Name = name;
        Type = type;
        HumidityLevel = humidityLevel;
        FertilityLevel = fertilityLevel;
        careItems = new List<CareItem>();
    }

    public void AddCareItem(CareItem careItem)
    {
        careItems.Add(careItem);
    }

    public int TotalCaresDone()
    {
        int total = 0;
        foreach(var care in careItems)
        {
            if (care.Status) total++;
        }
        return total;
    }

    public bool Water(double percent)
    {
        try
        {
            HumidityLevel += percent;
            return true;
        }
        catch(ArgumentException e)
        {
            return false;
        }
    }

    public bool Fertilize(double percent)
    {
        try
        {
            FertilityLevel += percent;
            return true;
        }
        catch (ArgumentException e)
        {
            return false;
        }
    }

    public override string ToString()
    {
        return $"Id: {Id}\n" +
            $"Name: {Name}\n" +
            $"Type: {Type}\n" +
            $"Humidity Level: {HumidityLevel:0.00} %\n" +
            $"Fertility Level: {FertilityLevel:0.00} %\n";
    }
}
