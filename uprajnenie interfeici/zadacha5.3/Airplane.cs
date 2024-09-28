using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha5._3
{
    internal class Airplane:Imachine
    {
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public Airplane(string type)
        {
            type = this.type;

        }
        public string Start()
        {
            return "Airplane starting...";
        }

        public string Stop()
        {
            return "Airplane stopping...";
        }
    }
}
