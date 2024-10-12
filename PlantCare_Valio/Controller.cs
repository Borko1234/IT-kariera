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
            plants[int.Parse(args[0])].AddCareItem(careItem);
            return $"Created Care {careItem.Name} for {int.Parse(args[0])}";
        }
        catch (Exception ex)
        {
            return "Plant not found!";
        }
    }

    public string AddPlant(List<string> args)
    {
        //
        try
        {
            Plant plant = new Plant(int.Parse(args[0]), args[1], args[2]);
            plants[int.Parse(args[0])].AddCareItem(careItem);
            return $"Created Care {careItem.Name} for {int.Parse(args[0])}";
        }
        catch (Exception ex)
        {
            return "Plant not found!";
        }
    }

    public string GetTotalCaresByPlantId(List<string> args)
    {
        //TODO: Implement me...
        throw new NotImplementedException();
    }

    public string WaterPlantById(List<string> args)
    {
        //TODO: Implement me...
        throw new NotImplementedException();
    }

    public string FertilizePlantById(List<string> args)
    {
        //TODO: Implement me...
        throw new NotImplementedException();
    }

    public string GetTallestTree(List<string> args)
    {
        //TODO: Implement me...
        throw new NotImplementedException();
    }

}