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
         int id = int.Parse(args[0]);
         string name = args[1];
         bool status = bool.Parse(args[2]);
         if (!plants.ContainsKey(id))
         {
             return $"Plant not found!";
         }
         Plant plant = plants[id];
         plant.AddCareItem(new CareItem(name, status));
         return $"Created Care {name} for {id}!";
     }

     public string AddPlant(List<string> args)
     {
         int id = int.Parse(args[0]);
         string name = args[1];
         double humiditylevel = double.Parse(args[2]);
         double fertilitylevel = double.Parse(args[3]);
         string type = args[4];
         if (plants.ContainsKey(id))
         {
             return $"Plant with ID {id} already exists!";
         }
         if (type == "flower") 
         plants.Add(id, new FloweringPlant(id, name, type, humiditylevel, fertilitylevel, args[5]));
         else
             plants.Add(id, new TreePlant(id, name, type, humiditylevel, fertilitylevel,int.Parse(args[5])));
         return $"Created Plant {name} with ID {id}!";
     }

     public string GetTotalCaresByPlantId(List<string> args)
     {
         int id = int.Parse(args[0]);
         if (!plants.ContainsKey(id))
             return $"Plant not found!";
         int count = 0;
         Plant plant = plants[id];
         count = plant.TotalCaresDone();

         return $"Total cares for plant {id}: {count}";
     }

     public string WaterPlantById(List<string> args)
     {
         int id = int.Parse(args[0]);
         if (!plants.ContainsKey(id))
             return $"Plant not found!";
         double percent= double.Parse(args[1]);
         if(plants.ContainsKey(id))
         {
             Plant plant = plants[id];
             if (plant.Water(percent))
                 return $"Plant {id} was watered successfully!";
             else
                 return $"Plant {id} could not be watered!";
         }
         return $"Plant not found!";

         //Plant {id} was watered successfully!
         //Plant {Id} could not be watered!
     }

     public string FertilizePlantById(List<string> args)
     {
         int id = int.Parse(args[0]);
         if (!plants.ContainsKey(id))
             return $"Plant not found!";
         double percent = double.Parse(args[1]);
         Plant plant = plants[id];
         if (plant.Fertilize(percent))
             return $"Plant {id} was fertilized successfully!";
         else
             return $"Plant {id} could not be fertilized!";
     }

     public string GetTallestTree(List<string> args)
     {
         List<TreePlant> treePlant = plants.Select(x =>x.Value)
             .Where(x => x.Type == "tree")
             .Select(x => (TreePlant)x)
             .OrderByDescending(x => x.Height)
             .ToList();
         if (treePlant.Count==0)
             return "No trees found!";
         return treePlant[0].ToString() ;
     }

 }
