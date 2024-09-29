using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cat cat = new cat();
            Trainer mo= new Trainer(cat);
            mo.Make();

        }
    }
}
