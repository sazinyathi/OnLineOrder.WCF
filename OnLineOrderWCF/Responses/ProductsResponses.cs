using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace OnLineOrderWCF.Responses
{
    [DataContract]
    public class ProductsResponses
    {
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public string ProductDescription { get; set; }
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public int ProductId { get; set; }
    }
}