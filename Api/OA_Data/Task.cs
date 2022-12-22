using System;
using System.ComponentModel.DataAnnotations;

namespace OA_Data
{
    public class Task : BaseEntity
    {
        public string AssignedToUserId { get; set; }
        public AppUser AssignedToUser { get; set; }
        [MaxLength(100), MinLength(10)]
        public string Description { get; set; }
        public DateTime DeliverDate { get; set; }
        public bool MarkAsDone { get; set; }

    }
}
