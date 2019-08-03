using Microsoft.Extensions.DependencyInjection;
using Strategy.Pattern.Contracts;
using Strategy.Pattern.Implementations;
using Strategy.Pattern.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Pattern
{
    public static class IoCRegister
    {
        public static void RegisterIoC()
        {
            var sevices = new ServiceCollection()
                .AddSingleton<IOrderSummaryRequestBuilder, OrderSummaryJsonRequestBuilder>()
                .AddSingleton<IOrderSummaryRequestBuilder, OrderSummaryXmlRequestBuilder>()
        }
    }
}
