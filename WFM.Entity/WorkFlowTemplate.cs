namespace WFM.Entity
{
    public class WorkFlowTemplate : BaseEntity
    {     
        public int TemplateId { get; set; }
        public int ProcessId { get; set; }
        public int ProcessLevelId { get; set; }
        public int DepartmentId { get; set; }
        public int StageId { get; set; }
        public int StageLevelId { get; set; }
        public int UserId { get; set; }     
        public bool IsDeleted { get; set; }
    }
}
