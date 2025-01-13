using Auth.Models.Dtos;

namespace Auth.Services.IService
{
    public interface IAuth
    {
        Task<object> Login(LoginRequestDto loginRequestDto);
        Task<object> Register(RegisterRequestDto registerRequestDto);
        

    }
}
