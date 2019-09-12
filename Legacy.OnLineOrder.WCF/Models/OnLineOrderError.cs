﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace OnLineOrderWCF.Models
{
    [DataContract]
    public class OnLineOrderError
    {
        [DataMember]
        public string ErrorCode { get; set; }
        [DataMember]
        public string ErrorDescription { get; set; }
    }
}