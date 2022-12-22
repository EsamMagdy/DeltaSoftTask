using OA_Service.DTOs.Response;
using OA_Service.DTOs.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_Service.Interface
{
    public interface ITaskService
    {
        Task<PagingSortingFiltering<TaskDto>> GetAllTasks(PagingParams pagingParams);
        Task<PagingSortingFiltering<TaskDto>> GetAllTasksForUser(PagingParams pagingParams, string userId);
        Task<TaskDto> GetTaskById(int Id);
        Task<TaskDto> AddTask(AddTaskDto TaskDto);
        Task UpdateTask(int id, UpdateTaskDto TaskDto);
        Task<bool> DeleteTask(int id);
        Task<bool> MarkTaskAsDone(int id);
    }
}
