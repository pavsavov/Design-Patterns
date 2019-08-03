using System;

namespace Strategy.Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IoCRegister.RegisterIoC();
            var api = new ApiClient();

            //Add uri and model to method
            //api.SendOrderSummary(string uri, OrderSummary orderSummary)

            Console.WriteLine("Api Client started!");
        }
    }
}
