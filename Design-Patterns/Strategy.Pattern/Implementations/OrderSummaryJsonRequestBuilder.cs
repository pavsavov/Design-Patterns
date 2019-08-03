using Newtonsoft.Json;
using Strategy.Pattern.Common;
using Strategy.Pattern.Contracts;
using Strategy.Pattern.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Strategy.Pattern.Implementations
{
    public class OrderSummaryJsonRequestBuilder : IOrderSummaryRequestBuilder
    {
        public HttpContent Build(OrderSummary orderSummary)
        {
            var orderSummaryString = JsonConvert.SerializeObject(orderSummary);
            return new StringContent(orderSummaryString,Encoding.UTF8,Constants.MEDIA_TYPE);
        }
    }
}
