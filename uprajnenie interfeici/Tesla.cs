using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace uprajnenie_interfeici
{
    public class Tesla:Elcar
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Baterry { get; set; }

        public Tesla(string model, string color, int baterry)
        {
            Model= model;
            Color= color;
            Baterry= baterry;
        }
        public string Start()
        {
            return $"Engine start";
        }

        public string Stop()
        {
            return "Break!";
        }
        public override string ToString()
        {
            return $"{Color}, {this.GetType().Name}, {Model} with {Baterry} batteries.  \n{Start()}\n{Stop()}";
        }

        
    }
}
