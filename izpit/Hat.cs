using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HatExam
{
    public class Hat
    {
        private string type;
        private string color;
        private double price;

        public Hat(string type, string color, double price)
        {
            this.Type = type;
            this.Color = color;
            this.Price = price;
        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public double Price
        {
            get { return this.price; }
            set {
                if(value > 100)
                {
                    throw new ArgumentException("Invalid hat price!");
                }
                this.price = value; }
        }

        public override string ToString()
        {
            return $"Hat {this.type} with color {this.color} costs {this.price:0.00}";
        }
    }
}
