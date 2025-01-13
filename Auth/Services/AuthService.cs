using Auth.Models;
using Auth.Models.Dtos;
using Auth.Services.IService;

namespace Auth.Services
{
    public class AuthService : IAuth
    {
        private readonly AuthDbContext _authDbContext;

        public AuthService(AuthDbContext authDbContext)
        {
            _authDbContext = authDbContext;
        }

        public Task<object> Login(LoginRequestDto loginRequestDto)
        {
            throw new NotImplementedException();
        }

        public Task<object> Register(RegisterRequestDto registerRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}
