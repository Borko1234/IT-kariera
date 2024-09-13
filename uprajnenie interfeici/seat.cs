using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uprajnenie_interfeici
{
    public class seat : icar
    {
        
        public string Model 
        { get; set; }
        public string Color 
        { get; set; }
        public seat(string model, string color)
        {
            Model = model;
            Color = color;
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
            return $"{Color}, {this.GetType().Name}, {Model} \n{Start()}\n{Stop()}";
        }
    }
}
