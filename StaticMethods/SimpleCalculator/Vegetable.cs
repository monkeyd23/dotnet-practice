using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produce
{
	class Vegetable : ProduceItem
	{
		public Vegetable(string name, double weight, double price) : base(name, weight, price)
		{
		}

		public override string ToString()
		{
			return "(Vegetable)" + base.ToString();
		}
	}
}