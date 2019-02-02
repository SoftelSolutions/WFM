namespace WFM.Entity
{
    public class Department : BaseEntity
    {      
        public string Name { get; set; }
        public string Code { get; set; }
        public bool IsDeleted { get; set; }
    }
}
