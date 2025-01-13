using Auth.Models;
using Auth.Models.Dtos;
using Auth.Services.IService;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Auth.Services
{
    public class AuthService : IAuth
    {
        private readonly AuthDbContext _authDbContext;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AuthService(AuthDbContext authDbContext, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _authDbContext = authDbContext;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public Task<object> Login(LoginRequestDto loginRequestDto)
        {
            throw new NotImplementedException();
        }

        public async Task<object> Register(RegisterRequestDto registerRequestDto)
 {
     ApplicationUser user = new()
     {
         UserName = registerRequestDto.UserName,
         NormalizedUserName = registerRequestDto.UserName.ToUpper(),
         FullName = registerRequestDto.FullName,
         Email = registerRequestDto.Email

     };

     var result = await _userManager.CreateAsync(user, registerRequestDto.Password);

     if (result.Succeeded)
     {
         var userToReturn = await _authDbContext.applicationUsers.FirstOrDefaultAsync(user => user.UserName == registerRequestDto.UserName);


         var UserResponse = new
         {
             id = userToReturn.Id,
             email = userToReturn.Email,
             userName = userToReturn.UserName,
             fullName = userToReturn.FullName,


         };

         return new { result = UserResponse, message = "Sikeres Regisztráció." };
     }

     return result.Errors.FirstOrDefault().Description;
 }
    }
}
