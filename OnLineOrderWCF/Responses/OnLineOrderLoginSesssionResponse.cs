using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace OnLineOrderWCF.Models
{
    [DataContract]
    public class OnLineOrderLoginSesssionResponse
    {
        public OnLineOrderLoginSesssionResponse()
        {
            Errors = new List<OnLineOrderError>();
            OnLineOrderLoginSesssionKey = string.Empty;
        }

        [DataMember]
        public string OnLineOrderLoginSesssionKey { get; set; }

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