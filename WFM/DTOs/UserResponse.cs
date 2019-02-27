using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace WFM.WebAPI.DTOs
{
    [DataContract]
    public class UserResponse
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember(Name ="empId")]
        public int EmployeeId { get; set; }
        [DataMember]
        public int RoleId { get; set; }
        [DataMember(Name = "user")]
        public string UserName { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public bool ActiveStatus { get; set; }
        [DataMember]
        public bool IsDeleted { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
