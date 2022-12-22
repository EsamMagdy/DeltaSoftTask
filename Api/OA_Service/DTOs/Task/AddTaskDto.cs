using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_Service.DTOs.Task
{
    public class AddTaskDto
    {
        public string AssignedToUserId { get; set; }
        public string Description { get; set; }
        public DateTime DeliverDate { get; set; }
    }
}
