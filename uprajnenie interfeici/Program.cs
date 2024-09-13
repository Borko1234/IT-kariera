using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uprajnenie_interfeici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            icar seat = new seat("Leon", "Gray");
            Console.WriteLine(seat.ToString());
            Elcar Tesla = new Tesla("Model 3","Red",2);
            Console.WriteLine(Tesla.ToString());
        }
    }
}
