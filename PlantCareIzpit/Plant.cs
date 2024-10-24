using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

 public abstract class Plant
    {
        private int id;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id=value;
            }
        }

        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length < 3 || value.Length > 30)
                    throw new ArgumentException("Name should be between 3 and 30 characters!");
                name =value;
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
                if (value.Length < 3 || value.Length > 30) throw new ArgumentException("Type should be between 3 and 30 characters!");
                type = value;
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
                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("Humidity Level should be between 0 and 1!");
                }
                humidityLevel = value;
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
              if(value < 0 || value > 1) throw new ArgumentException("Fertility Level should be between 0 and 1!");
              fertilityLevel = value;
            }
        }

        public Plant(int id, string name, string type, double humidityLevel, double fertilityLevel)
        {
            careItems=new List<CareItem>();
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.HumidityLevel = humidityLevel;
            this.FertilityLevel = fertilityLevel;
        }

        public void AddCareItem(CareItem careItem)
        {
            careItems.Add(careItem);
            
        }

        public int TotalCaresDone()
        {
            return careItems.Where(x=>x.Status==true).Count();
        }

        public bool Water(double percent)
        {
            try
            {
                HumidityLevel += percent;
                return true;
            }
            catch (ArgumentException e)
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
            return $"Id: {Id}\nName: {Name}\nType: {Type}\nHumidity Level: {HumidityLevel:f2} %\nFertility Level: " +
                $"{FertilityLevel:f2} %";
        }

    }

