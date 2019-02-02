using System;
using System.ComponentModel.DataAnnotations;

namespace WFM.Entity
{
    public class TaskAsigned 
    {
        [Key]
        public int Id { get; set; }
        public int WorkFlowId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Remaks { get; set; }
        public int CreatedUserId { get; set; }
        public int CreatedDate { get; set; }
    }
}
