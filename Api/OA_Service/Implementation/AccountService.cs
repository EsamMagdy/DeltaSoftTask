using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OA_Data;
using OA_Service.DTOs.Identity;
using OA_Service.Exceptions;
using OA_Service.Interface;
using OA_Service.StaticProperty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_Service.Implementation
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;
        private readonly RoleManager<AppRole> _roleManager;
        public AccountService(UserManager<AppUser> userManager,
                               RoleManager<AppRole> roleManager,
                               SignInManager<AppUser> signInManager,
                               ITokenService tokenService,
                               IMapper mapper

           )
        {
            _roleManager = roleManager;
            _tokenService = tokenService;
            _signInManager = signInManager;
            _userManager = userManager;
            _mapper = mapper;

        }

        public async System.Threading.Tasks.Task AddRole(string roleName)
        {
            await _roleManager.CreateAsync(new AppRole
            {
                Name = roleName
            });
        }

        public async System.Threading.Tasks.Task AddRoleToUser(string userId, string roleName)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
                throw new NotFoundException("User not exist");

            await _userManager.AddToRoleAsync(user, roleName);
        }

        public async Task<List<AppUserDto>> GetTeamMemberUsersByName(string name)
        {
            //var adminUserIds = (await _userManager.GetUsersInRoleAsync(RoleName.Admin))
            //                    .Select(s => s.Id)
            //                    .ToList();


            //var users = await _userManager.Users
            //                        .Where(s => !adminUserIds.Contains(s.Id) 
            //                                    && s.UserName.Contains(name))
            //                        .ProjectTo<AppUserDto>(_mapper.ConfigurationProvider)
            //                        .ToListAsync();

            var users = await _userManager.Users
                                  .Where(user => user.UserRoles.Any(a => a.Role.Name == RoleName.TeamMember)
                                              && user.UserName.Contains(name))
                                  .ProjectTo<AppUserDto>(_mapper.ConfigurationProvider)
                                  .ToListAsync();


            return users;
        }

        public async Task<UserDto> Login(LoginDto loginDto)
        {
            var user = await _userManager.Users
                                    .FirstOrDefaultAsync(x => x.Email == loginDto.Email);

            if (user == null)
                throw new NotFoundException("Please Check Email");

            var result = await _signInManager
                          .CheckPasswordSignInAsync(user, loginDto.Password, false);

            if (!result.Succeeded)
                throw new Exceptions.UnauthorizedAccessException("Please Check Password");

            return new UserDto
            {
                Username = user.UserName,
                Token = await _tokenService.CreateToken(user),
                Email = user.Email
            };
        }

        public async Task<UserDto> Register(RegisterDto registerDto)
        {
            var userInDB = await _userManager.Users
                                    .FirstOrDefaultAsync(x => x.Email == registerDto.Email);

            if (userInDB != null)
                throw new AmbiguousException("User Exist!");

            var user = _mapper.Map<RegisterDto, AppUser>(registerDto);

            var result = await _userManager.CreateAsync(user, registerDto.Password);

            if (!result.Succeeded)
                throw new InternalServerErrorException(result.Errors.ToString());

            return new UserDto
            {
                Username = user.UserName,
                Email = user.Email,
                Token = await _tokenService.CreateToken(user),
            };
        }
    }
}
