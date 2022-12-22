using OA_Service.DTOs.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_Service.DTOs.Task
{
    public class TaskDto
    {
        public int Id { get; set; }
        public string AssignedToUserId { get; set; }
        public AppUserDto AssignedToUser { get; set; }
        public string Description { get; set; }
        public DateTime DeliverDate { get; set; }
        public DateTime CreationTime { get; set; }
        public bool MarkAsDone { get; set; }
    }
}
