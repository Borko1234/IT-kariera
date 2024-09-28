using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha5._3
{
    internal class Truck:Imachine
    {
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public Truck(string type)
        {
            type = this.type;

        }
        public string Start()
        {
            return "truck is starting...";
        }

        public string Stop()
        {
            return "truck is stopping...";
        }
    }
}
