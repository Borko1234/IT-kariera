using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha5._3
{
    public class MachineOperator
    {
		private Imachine entity;

		public  Imachine Entity
		{
			get { return entity; }
			set {
				entity = value;
                Console.WriteLine("Machine operator is operating:"+value.Type);
				}
		}
		public MachineOperator(Imachine entity)
		{
			Entity= entity;
		}
		public string Start()
		{
			return entity.Start();
		}
		public string Stop()
		{
			return entity.Stop();
		}
	}
}
