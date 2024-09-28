using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha5._3
{
    public class Car : Imachine
    {
		private string type;

		public string Type
		{
			get { return type; }
			set { type = value; }
		}
        public Car(string type)
        {
            type =this. type;
            
        }

        public string Start()
        {
            return "Car is starting...";
        }

        public string Stop()
        {
            return "Car is stopping...";
        }
    }
}
