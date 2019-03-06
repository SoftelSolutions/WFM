using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace WFM.WebAPI.DTOs.LoginDTOs
{
    
    public class LoginRequest
    {
        [Required]
        public string userName { get; set; }
        [Required]
        public string password { get; set; }
        

    }
}
