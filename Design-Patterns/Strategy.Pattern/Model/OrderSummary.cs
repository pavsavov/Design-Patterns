using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Pattern.Model
{
    public class OrderSummary
    {
        public string UserId { get; set; }

        public string OrderId { get; set; }

        public DateTime PurchaseDate { get; set; }
    }
}
