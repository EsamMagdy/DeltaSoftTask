using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using OA_Data;
using OA_Repo;
using OA_Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoMapper.QueryableExtensions;
using OA_Service.DTOs.Task;
using Microsoft.AspNetCore.Identity;
using OA_Service.Exceptions;
using OA_Service.DTOs.Response;

namespace OA_Service.Implementation
{
    class TaskService : ITaskService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;
        public TaskService(IUnitOfWork unitOfWork,
            IMapper mapper,
            UserManager<AppUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;
        }
        public async Task<PagingSortingFiltering<TaskDto>> GetAllTasks(PagingParams pagingParams)
        {
            var Tasks = _unitOfWork.Tasks
                        .GetAllQueryable()
                        .AsNoTracking()
                        .ProjectTo<TaskDto>(_mapper.ConfigurationProvider);


            return await PagingSortingFilteringList<TaskDto>
                             .CreateAsync(Tasks, pagingParams);
        }
        public async Task<PagingSortingFiltering<TaskDto>> GetAllTasksForUser(PagingParams pagingParams, string userId)
        {
            var userInDb = await _userManager.Users
                                   .FirstOrDefaultAsync(s => s.Id == userId);

            if (userInDb == null)
                throw new NotFoundException("لا يوجد مستخدم");

            var Tasks = _unitOfWork.Tasks
                                   .GetAllQueryable()
                                   .Where(s => s.AssignedToUserId == userId
                                            && s.DeliverDate.Date <= DateTime.Now.Date)
                                   .AsNoTracking()
                                   .ProjectTo<TaskDto>(_mapper.ConfigurationProvider);

            return await PagingSortingFilteringList<TaskDto>
                             .CreateAsync(Tasks, pagingParams);
        }
        public async Task<TaskDto> GetTaskById(int Id)
        {
            var taskInDb = await _unitOfWork.Tasks.GetById(Id);

            if (taskInDb == null)
                throw new NotFoundException("لا يوجد مهمة بهذا الرقم");

            return _mapper.Map<OA_Data.Task, TaskDto>(taskInDb);
        }
        public async System.Threading.Tasks.Task<TaskDto> AddTask(AddTaskDto taskDto)
        {
            var userInDb = await _userManager.Users
                                    .FirstOrDefaultAsync(s => s.Id == taskDto.AssignedToUserId);

            if (userInDb == null)
                throw new NotFoundException("لا يوجد مستخدم");

            var task = _mapper.Map<AddTaskDto, OA_Data.Task>(taskDto);

            await _unitOfWork.Tasks.Insert(task);
            await _unitOfWork.Complete();

            return _mapper.Map<OA_Data.Task, TaskDto>(task);
        }
        public async System.Threading.Tasks.Task UpdateTask(int id, UpdateTaskDto taskDto)
        {
            var taskInDb = await _unitOfWork.Tasks.GetById(id);

            if (taskInDb == null)
                throw new NotFoundException("لا يوجد مهمة بهذا الرقم");

            var userInDb = await _userManager.Users
                                    .FirstOrDefaultAsync(s => s.Id == taskDto.AssignedToUserId);

            if (userInDb == null)
                throw new NotFoundException("لا يوجد مستخدم");

            _mapper.Map(taskDto, taskInDb);

            taskInDb.ModificationTime = DateTime.Now;
            await _unitOfWork.Complete();
        }
        public async Task<bool> DeleteTask(int id)
        {
            var taskInDb = await _unitOfWork.Tasks.GetById(id);

            if (taskInDb == null)
                throw new NotFoundException("لا يوجد مهمة بهذا الرقم");

            taskInDb.IsDeleted = true;
            return await _unitOfWork.Complete();
        }

        public async Task<bool> MarkTaskAsDone(int id)
        {
            var taskInDb = await _unitOfWork.Tasks.GetById(id);

            if (taskInDb == null)
                throw new NotFoundException("لا يوجد مهمة بهذا الرقم");

            taskInDb.MarkAsDone = true;
            return await _unitOfWork.Complete();
        }


    }
}
