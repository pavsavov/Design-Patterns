using Notification.Test.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Notification.Test.Implementations
{
	public class Bidder : IObserver
	{
		private readonly string name;
		private double bidPrice;

		public Bidder(string name)
		{
			this.name = name;
		}

		public void Update()
		{
			Console.WriteLine(name + " propse: " + bidPrice + "\n");

			if (bidPrice > 10000)
			{
				Console.WriteLine("Sold to " + name);
			}
		}

		public void GiveNewPrice(double price)
		{
			this.bidPrice = price;
		}
	}
}
