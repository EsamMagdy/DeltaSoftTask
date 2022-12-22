using OA_Service.DTOs.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_Service.Interface
{
    public interface IAccountService
    {
        Task<UserDto> Register(RegisterDto registerDto);
        Task<List<AppUserDto>> GetTeamMemberUsersByName(string name);
        Task<UserDto> Login(LoginDto loginDto);
        Task AddRole(string roleName);
        Task AddRoleToUser(string userId, string roleName);
    }
}
