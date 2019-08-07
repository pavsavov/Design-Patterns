using System;
using System.Collections.Generic;
using System.Text;

namespace Notification.Test.Contracts
{
	public interface IObserver
	{
		void Update();

		void GiveNewPrice(double price);
	}
}
