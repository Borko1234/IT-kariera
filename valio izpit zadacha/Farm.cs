using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsRegularExam
{
	public class Farm
	{

        private string name;
        private List<Animal> animals;

        public Farm(string name)
        {
            Name = name;
            Animals = new List<Animal>();
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public List<Animal> Animals
        {
            get
            {
                return animals;
            }
            set
            {
                animals = value;
            }
        }

        public void AddAnimal(string type, int weight)
        {
            animals.Add(new Animal(type, weight));
        }

        public double AverageWeight()
        {
            double sum = animals.Sum(a => a.Weight);
            return sum / animals.Count;
        }

        public List<string> FilterAnimalsByWeight(int weight)
        {
            List<string> filterAnimals = new List<string>();
            foreach(Animal a in animals)
            {
                if(a.Weight < weight)
                {
                    filterAnimals.Add(a.Type);
                }
            }
            return filterAnimals;
        }


        public List<Animal> SortAscendingByType()
        {
            List<Animal> a = animals.OrderBy(a => a.Type).ToList();
            Animals = a;
            return Animals;
        }

        public List<Animal> SortDescendingByWeight()
        {
            var sortWeight = Animals.OrderByDescending(x => x.Weight).ToList();
            Animals = sortWeight;
            return Animals;
        }

        public bool CheckAnimalIsInFarm(string type)
        {
            foreach(Animal a in animals)
            {
                if(type == a.Type)
                {
                    return true;
                }
            }
            return false;
        }

        public string[] ProvideInformationAboutAllAnimals()
        {
            string[] s = new string[animals.Count];

            for(int i = 0; i < animals.Count; i++)
            {
                s[i] = animals[i].ToString();
            }

            return s;
        }
    }
}

