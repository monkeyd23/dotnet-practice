using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produce
{
	class ProduceItem
	{
		public string Name { get; set; }
		public double Weight { get; set; }
		public double Price { get; set; }

		public ProduceItem() { }

		public ProduceItem(string name, double weight, double price)
		{
			Name = name;
			Weight = weight;
			Price = price;
		}

		public override string ToString()
		{
			return " " + Name + " -> " + "(" + Weight + "Oz, $" + Price + ")";
		}
	}
}
