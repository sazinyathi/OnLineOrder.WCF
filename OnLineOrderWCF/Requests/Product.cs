using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace OnLineOrderWCF.Requests
{
    [DataContract]
    public class OnLineOrderProductRequest
    {
        [DataMember]
        public string SessionId { get; set; }
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public string ProductDescription { get; set; }
        [DataMember]
        public float Price { get; set; }
    }
}