using AutoMapper;
using OA_Data;
using OA_Service.DTOs;
using OA_Service.DTOs.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_Service.Mapping
{
    public class Task_TaskDtoProfile : Profile
    {
        public Task_TaskDtoProfile()
        {
            CreateMap<OA_Data.Task, TaskDto>();

            CreateMap<AddTaskDto, OA_Data.Task>();

        }
    }
}
