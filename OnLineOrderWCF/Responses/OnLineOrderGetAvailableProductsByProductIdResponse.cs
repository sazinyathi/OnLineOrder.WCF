using OnLineOrderWCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace OnLineOrderWCF.Responses
{
    [DataContract]
    public class OnLineOrderGetAvailableProductsByProductIdResponse
    {
        public OnLineOrderGetAvailableProductsByProductIdResponse()
        {
            Errors = new List<OnLineOrderError>();
        }

        [DataMember]
        public ProductsResponses GetProduct { get; set; }
        [DataMember]
        public bool IsSucessful
        {
            get { return Errors.Count > 0 ? false : true; }
            private set { }
        }

        [DataMember]
        public List<OnLineOrderError> Errors { get; set; }
    }
}