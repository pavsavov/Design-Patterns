using Strategy.Pattern.Contracts;
using Strategy.Pattern.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Xml.Serialization;
using Strategy.Pattern.Common;

namespace Strategy.Pattern.Implementations
{
    public class OrderSummaryXmlRequestBuilder : IOrderSummaryRequestBuilder
    {
        private static XmlSerializer serialzier;

        public OrderSummaryXmlRequestBuilder()
        {
            var xRoot = new XmlRootAttribute();
            xRoot.ElementName = Constants.XML_ELEMENT_NAMING;
            serialzier = new XmlSerializer(typeof(OrderSummary), xRoot);
        }

        public HttpContent Build(OrderSummary orderSummary)
        {
            string orderSummartString;
            using (StringWriter writer = new StringWriter())
            {
                serialzier.Serialize(writer, orderSummary);
                orderSummartString = writer.ToString();
            }

            return new StringContent(orderSummartString, Encoding.UTF8, Constants.MEDIA_TYPE);
        }
    }
}
