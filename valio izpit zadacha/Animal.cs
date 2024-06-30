using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsRegularExam
{
	public class Animal
	{
		
        private string type;
        private int weight;

        public Animal(string type, int weight)
        {
            Type = type;
            Weight = weight;
        }

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                this.type = value;
            }
        }
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                this.weight = value;
            }
        }

        public override string ToString()
        {
            return $"Animal {this.type} weights {this.weight} kg.";
        }

    }
}

