using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_5._4
{
    internal class Trainer
    {
		private IAnimal entity;
        private cat cat;

        public  IAnimal Entity
		{
			get { return entity; }
			set { entity = value; }
		}
		public Trainer(IAnimal entity)
		{
			Entity = entity;
		}
		public void Make()
		{
            Console.WriteLine(this.Entity.Perform());
        }




    }
}
