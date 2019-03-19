using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace WFM.WebAPI.DTOs.LoginDTOs
{
    [DataContract]
    public class LoginResponse
    {
        [DataMember]
        public string token { get; set; }
    }
}
