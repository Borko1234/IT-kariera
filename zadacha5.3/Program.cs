using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Car");
            Truck truck = new Truck("Truck");
            MachineOperator mo = new MachineOperator(car);
            Console.WriteLine(mo.Start());  //пускаме машината
            Console.WriteLine(mo.Stop()); //спираме машината
            mo = new MachineOperator(truck);
            Console.WriteLine(mo.Start()); 
            Console.WriteLine(mo.Stop());
        }
    }
}
