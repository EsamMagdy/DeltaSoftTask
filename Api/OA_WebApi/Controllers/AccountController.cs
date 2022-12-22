using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OA_Data;
using OA_Repo;
using OA_Service.DTOs.Identity;
using OA_Service.DTOs.Response;
using OA_Service.Interface;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;


        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        [HttpPost("Register")]
        public async Task<ActionResult> Register(RegisterDto registerDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            return Ok(new ResponseDto<UserDto>
            {
                Data = await _accountService.Register(registerDto)
            });
        }

        [HttpPost("Login")]
        public async Task<ActionResult> Login(LoginDto loginDto)
        {
            return Ok(new ResponseDto<UserDto>
            {
                Data = await _accountService.Login(loginDto)
            });
        }
        [HttpPost("AddRole")]
        public async System.Threading.Tasks.Task AddRole(string roleName)
        {
            await _accountService.AddRole(roleName);

        }
        [HttpPost("AddRoleToUser")]
        public async System.Threading.Tasks.Task AddRoleToUser(string userId, string roleName)
        {
            await _accountService.AddRoleToUser(userId, roleName);

        }
        [HttpGet("GetTeamMemberUsersByName")]
        public async Task<ActionResult> GetTeamMemberUsersByName(string name)
        {
            return Ok(new ResponseDto<List<AppUserDto>>
            {
                Data = await _accountService.GetTeamMemberUsersByName(name)
            });
        }

    }
}