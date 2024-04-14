using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HatExam
{
    public class HatShop
    {
        private string name;
        private List<Hat> hats;

        public HatShop(string name)
        {
            this.hats = new List<Hat>();
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            set { 
                if(value.Length<6)
                {
                    throw new ArgumentException("Invalid hat shop name!");
                }
                this.name = value; 
            }
        }

        public void AddHat(Hat hat)
        {
            hats.Add(hat);
        }

        public bool SellHat(Hat hat)
        {
            bool contains = false;
            foreach (var item in hats)
            {
                contains = (hat.Type == item.Type
                    && hat.Color == item.Color
                    && hat.Price == item.Price);
                //if(hats.Contains(hat))
                if (contains)
                {
                    hats.Remove(item);
                    return true;
                }
            }
            return false;
            
        }

        public double CalculateTotalPrice()
        {
            return hats.Sum(x => x.Price);
        }

        public Hat GetHatWithHighestPrice()
        {
            return hats.OrderByDescending(x => x.Price).ToList()[0];
        }

        public Hat GetHatWithLowestPrice()
        {
            return hats.OrderBy(x => x.Price).ToList()[0];
        }

        public void RenameHatShop(string newName)
        {
            this.Name = newName;
        }

        public void SellAllHats()
        {
            hats.Clear();
        }

        public override string ToString()
        {
            int hatCount = hats.Count;
            if(hatCount > 0)
            {
                return $"Hat Shop {this.name} has {hatCount} hat/s:\n" + String.Join("\n",
                    hats.Select(x => x.ToString()));
            }
            else
            {
                return $"Hat Shop {this.name} has no available hats.";
            }
        }
    }
}
