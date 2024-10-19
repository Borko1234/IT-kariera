using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


public class Controller
{
    private readonly Dictionary<int, Plant> plants;

    public Controller()
    {
        plants = new Dictionary<int, Plant>();
    }

    public string AddCareItem(List<string> args)
    {
        try
        {
            CareItem careItem = new CareItem(args[1], bool.Parse(args[2]));
            if (plants.ContainsKey(int.Parse(args[0])))
                plants[int.Parse(args[0])].AddCareItem(careItem);
            else
                throw new ArgumentException("Plant not found!");
            return $"Created Care {careItem.Name} for {int.Parse(args[0])}!";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    public string AddPlant(List<string> args)
    {
        int id = int.Parse(args[0]);
        string name = args[1];
        double humidityLevel = double.Parse(args[2]);
        double fertilityLevel = double.Parse(args[3]);
        string type = args[4];

        try
        {
            if(type=="flower")
            {
                FloweringPlant plant = new FloweringPlant(id, name, type, humidityLevel, fertilityLevel , args[5]);
                plants.Add(id, plant);
            }
            if(type=="tree")
            {
                TreePlant plant = new TreePlant(id, name, type, humidityLevel, fertilityLevel, int.Parse(args[5]));
                plants.Add(id, plant);
            }
            return $"Created Plant {name} with ID {id}!";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    public string GetTotalCaresByPlantId(List<string> args)
    {
        int id = int.Parse(args[0]);
        try
        {
            if(plants.ContainsKey(id))
                return $"Total cares for plant {id}: {plants[id].TotalCaresDone()}";
            else
                throw new ArgumentException("Plant not found!");
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    public string WaterPlantById(List<string> args)
    {
        int id = int.Parse(args[0]);
        double percent = double.Parse(args[1]);

        try
        {
            if(plants.ContainsKey(id))
            {
                if (plants[id].Water(percent))
                    return $"Plant {id} was watered successfully!";
                else
                    return $"Plant {id} could not be watered!";
            }
            else
                throw new ArgumentException("Plant not found!");
        }
        catch (Exception ex)
        {
            return ex.Message;
        }

    }

    public string FertilizePlantById(List<string> args)
    {
        int id = int.Parse(args[0]);
        double percent = double.Parse(args[1]);

        try
        {
            if(plants.ContainsKey(id))
            {
                if (plants[id].Water(percent))
                    return $"Plant {id} was fertilized successfully!";
                else
                    return $"Plant {id} could not be fertilized!";
            }
            else
                throw new ArgumentException("Plant not found!");
        }
        catch (Exception ex)
        {
            return ex.Message;
        }

    }

    public string GetTallestTree(List<string> args)
    {
        List<TreePlant> treePlants = new List<TreePlant>();
        if(plants.Values.Where(p => p.Type == "tree").Count()==0)
        {
            return "No trees found!";
        }
        else
        {
            
            foreach (var item in plants.Values)
            {
                if(item.Type == "tree")
                {
                    TreePlant tp = (TreePlant)item;
                    treePlants.Add(tp);
                }
            }
            return treePlants.OrderByDescending(p => p.Height).ToList()[0].ToString();
        }
    }

}