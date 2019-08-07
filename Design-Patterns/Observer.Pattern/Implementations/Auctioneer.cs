using Notification.Test.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Notification.Test.Implementations
{
	public class Auctioneer : ISubject
	{
		private readonly HashSet<IObserver> registeredBidders;

		public Auctioneer()
		{
			this.registeredBidders = new HashSet<IObserver>();
		}

		public bool RegisterBidder(IObserver bidder)
		{
			if(bidder != null)
			{
				registeredBidders.Add(bidder);
				return true;
			}

			return false;
		}

		public bool RemoveBidder(IObserver bidder)
		{
			if(bidder != null && this.registeredBidders.Contains(bidder))
			{
				this.registeredBidders.Remove(bidder);
				return true;
			}

			return false;
		}

		public void NotifyObservers()
		{
			foreach(var observer in this.registeredBidders)
			{
				observer.Update();
			}
		}
	}
}
