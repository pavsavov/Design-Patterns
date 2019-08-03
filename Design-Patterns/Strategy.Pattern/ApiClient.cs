using Strategy.Pattern.Contracts;
using Strategy.Pattern.Model;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Pattern
{
    public class ApiClient
    {
        private static HttpClient client;
        readonly IOrderSummaryRequestBuilder orderSummaryRequestBuilder;

        public ApiClient()
        {
            client = new HttpClient();
        }

        public ApiClient(IOrderSummaryRequestBuilder orderSummaryRequestBuilder)
        {
            this.orderSummaryRequestBuilder = orderSummaryRequestBuilder;
        }

        public async Task<HttpStatusCode> SendOrderSummary(string uri, OrderSummary orderSummary)
        {
            var httpContent = orderSummaryRequestBuilder.Build(orderSummary);
            var response = await client.PostAsync(uri, httpContent);
            return response.StatusCode;
        }
    }
}
