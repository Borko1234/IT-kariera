using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace spisuci
{
    public class cars
    {
        private string Color;
        private string Model;
        private int age;

        public int year
        {
            get { return age; }
            set { age = value; }
        }

        public string model
        {
            get { return Model; }
            set { Model = value; }
        }


        public string color
        {
            get { return Color; }
            set { Color = value; }
        }
        public cars(string model_out, string color_out, int year_out)
        {
            this.model = model_out;
            this.color = color_out;
            this.age = year_out;
        }
        public void recolor()
        {
            color = "black";
        }
        public string driving()
        {
            return $"The car {model} driving...";
        }
    }
    

    internal class Program
    {
        static void Main(string[] args)
        {
            cars BMW1 = new cars("Seriq2","Zelen",2010);
            //cars BMW2 = new cars();
            cars BMW3 = new cars("Seriq3","sinio",2021) ;
            //BMW1.model = "Seriq1";
            //BMW1.color = "Zelen";
            //BMW1.year = 2010;
            //BMW2.model = "Seriq2";
            //BMW2.color = "Siv";
            //BMW2.year = 2005;
            BMW1.recolor();
            Console.WriteLine(BMW1.model+"->"+BMW1.color+ "->" + BMW1.year);
            //Console.WriteLine(BMW2.model + "->" + BMW2.color + "->" + BMW2.year);
            Console.WriteLine(BMW3.model + "->" + BMW3.color + "->" + BMW3.year);
            
            
        }
    }
}
