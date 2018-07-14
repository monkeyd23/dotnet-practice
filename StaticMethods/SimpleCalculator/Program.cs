using Produce;
using System;
using System.Collections.Generic;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
			// Create new list
			var produce = new List<ProduceItem>();

			// Add items
			Fruit fig = new Fruit();

			fig.Name = "Fig";
			fig.Weight = 10;
			fig.Price = 0.3;

			produce.Add(new Fruit("Apple ", 200, 3.5));
			produce.Add(new Fruit("Orange", 250, 2.5));
			produce.Add(new Fruit("Grapes", 100, 1.5));

			produce.Add(new Vegetable("Onion", 120, 4.5));
			produce.Add(new Vegetable("Brinjal", 130, 6.5));
			produce.Add(new Vegetable("LadyFinger", 140, 7.5));

			produce.Add(fig);

			foreach (ProduceItem item in  produce)
			{
				Console.WriteLine(item);
			}

			Console.ReadKey();

		}
    }
}
