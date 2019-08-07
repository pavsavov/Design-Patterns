using System;
using System.Collections.Generic;
using System.Text;

namespace Notification.Test.Contracts
{
	public interface ISubject
	{
		bool RegisterBidder(IObserver observer);

		bool RemoveBidder(IObserver observer);
	}
}
