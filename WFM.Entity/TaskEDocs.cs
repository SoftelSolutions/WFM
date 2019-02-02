using System.ComponentModel.DataAnnotations;

namespace WFM.Entity
{
    public class TaskEDocs
    {
        [Key]
        public int Id { get; set; }
        public int TaskId { get; set; }
        public string DocDetail { get; set; }
        public string DocFileName { get; set; }
        public string DocFilePath { get; set; }
        public int CreatedUserId { get; set; }
        public int CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
