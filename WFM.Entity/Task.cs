using System;

namespace WFM.Entity
{
    public class Task : BaseEntity
    {       
        public DateTime EntryDate { get; set; }
        public string TaskNo { get; set; }
        public string Subject { get; set; }
        public string Detail { get; set; }
        public int TemplateId { get; set; }
        public int TaskPriorityId { get; set; }
        public int TaskTypeId { get; set; }
        public DateTime? ApproxCloseDate { get; set; }
        public int TaskStatusId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
