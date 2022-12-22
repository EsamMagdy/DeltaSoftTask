using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OA_Service.DTOs.Response;
using OA_Service.DTOs.Task;
using OA_Service.Interface;
using OA_Service.StaticProperty;
using System.Threading.Tasks;

namespace OA_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;
        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }
        [HttpGet("GetAllTasks")]
        public async Task<ActionResult> GetAllTasks([FromQuery] PagingParams pagingParams)
        {
            return Ok(new ResponseDto<PagingSortingFiltering<TaskDto>>
            {
                Data = await _taskService.GetAllTasks(pagingParams)
            });
        }
        [HttpGet("GetAllTasksForUser")]
        public async Task<ActionResult> GetAllTasksForUser([FromQuery] PagingParams pagingParams, string userId)
        {
            return Ok(new ResponseDto<PagingSortingFiltering<TaskDto>>
            {
                Data = await _taskService.GetAllTasksForUser(pagingParams, userId)
            });
        }
        [Authorize(Roles = RoleName.Admin)]
        [HttpPost("AddTask")]
        public async Task<ActionResult> AddTask(AddTaskDto taskDto)
        {
            return Ok(new ResponseDto<TaskDto>
            {
                Data = await _taskService.AddTask(taskDto)
            });
        }
        [Authorize]
        [HttpPost("MarkTaskAsDone")]
        public async Task<ActionResult> MarkTaskAsDone(int taskId)
        {
            return Ok(new ResponseDto<bool>
            {
                Data = await _taskService.MarkTaskAsDone(taskId)
            });
        }
    }
}
