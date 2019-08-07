using Microsoft.Extensions.DependencyInjection;
using Notification.Test.Contracts;
using Notification.Test.Implementations;
using System;
using System.Collections.Generic;

namespace Notification.Test
{
	class Program
	{
		static void Main(string[] args)
		{
			var auctioneer = new Auctioneer();
			var bidders = new List<IObserver>()
			{
				new Bidder("Sasho"),
				new Bidder("Pesho"),
				new Bidder("Gosho"),
				new Bidder("Bobi")
			};

			bool registration;
			int bidderCount = 0;
			foreach (var bidder in bidders)
			{
				bidderCount++;
				registration = auctioneer.RegisterBidder(bidder);
				if (registration == false)
				{
					Console.WriteLine($"Bidder with number {bidderCount} failed to register!");
				}
			}

			var firstRound = new double[] { 123.3, 222.1, 115 };
			//Bidding(bidders,)
		}


		//private void Bidding(IObserver bidder, double[] priceBid)
		//{
		//	foreach (var bidder in bidders)
		//	{
		//		bidder.GiveNewPrice(priceBid);
		//	}
		//}

		//TODO: Add Dependency Inj method -> ServiceCollection.
	}
}
