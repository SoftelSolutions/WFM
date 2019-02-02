using System.ComponentModel.DataAnnotations.Schema;

namespace WFM.Entity
{

    [Table("Users")]
    public class User: BaseEntity
    {        
        public int EmployeeId { get; set; }
        public int RoleId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool ActiveStatus { get; set; }
        public bool IsDeleted { get; set; }
    }
}
