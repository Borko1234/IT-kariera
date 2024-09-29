using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_5._4
{
    internal class dog : IAnimal
    {
        public string MakeNoise()
        {
            return "Woof";
        }

        public string MakeTrick()
        {
            return "Hold my paw, human!";
        }

        public string Perform()
        {
            return $"{this.MakeNoise()}\n{this.MakeTrick()}";
        }
    }
}
