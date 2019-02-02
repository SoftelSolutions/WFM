namespace WFM.Entity
{
    public class Process : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public bool IsDeleted { get; set; }
    }
}
