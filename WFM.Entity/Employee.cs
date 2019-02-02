namespace WFM.Entity
{
    public class Employee : BaseEntity
    {      
        public int EmployeeId { get; set; }
        public int RoleId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool ActiveStatus { get; set; }
        public int IsDeleted { get; set; }
    }

}
