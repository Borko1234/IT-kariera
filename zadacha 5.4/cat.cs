using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_5._4
{
    internal class cat : IAnimal
    {
        public string MakeNoise()
        {
            return "Meow";
        }

        public string MakeTrick()
        {
            return "No trick for you! I'm too lazy!";
        }

        public string Perform()
        {
            return $"{this.MakeNoise()}\n{this.MakeTrick()}";
        }
    }
}
