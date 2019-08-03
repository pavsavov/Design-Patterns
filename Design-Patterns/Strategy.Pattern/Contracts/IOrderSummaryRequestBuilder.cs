using Strategy.Pattern.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Strategy.Pattern.Contracts
{
    public interface IOrderSummaryRequestBuilder
    {
        HttpContent Build(OrderSummary orderSummary);
    }
}
