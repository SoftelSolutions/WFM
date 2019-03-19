using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace WFM.WebAPI.DTOs.UserDTOs
{
    
    public class UpdateUserRequest
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool ActiveStatus { get; set; }
        public bool IsDeleted { get; set; }

        public int? UpdateUserId  { get; set; }

        public DateTime? UpdateDate
        {
            get
            {
                return DateTime.Now;
            }
            set { }
        }
    }

    public class CreateUserRequest
    {
        public int EmployeeId { get; set; }
        public int RoleId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool ActiveStatus { get; set; }
        public bool IsDeleted { get; set; }

        public int CreatedUserId { get; set; }
        public DateTime CreatedDate
        {
            get
            {
                return DateTime.Now;
            }
            set { }
        }

            
    }
}
