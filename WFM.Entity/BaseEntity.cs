using System;
using System.ComponentModel.DataAnnotations;

namespace WFM.Entity
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public int CreatedUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }        
    }
}
