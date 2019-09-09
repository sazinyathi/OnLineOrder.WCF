using OnLineOrderWCF.Models;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OnLineOrderWCF
{
    [DataContract]
    public class OnLineOrderCreateProductResponse
    {
        public OnLineOrderCreateProductResponse()
        {
            Errors = new List<OnLineOrderError>();
        }
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