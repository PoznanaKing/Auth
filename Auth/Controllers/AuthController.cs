using Auth.Models.Dtos;
using Auth.Services.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Auth.Controllers
{
    [Route("Auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuth auth;

        public AuthController(IAuth iauth)
        {
            this.auth = iauth;
        }
        [HttpPost("Login")]
        public async Task<ActionResult> LoginPost(LoginRequestDto loginRequestDto)
        {
            
            return Ok();
        }
        [HttpPost("Register")]
        public async Task<ActionResult> RegisterPost(RegisterRequestDto registerRequestDto)
        {
            var result = await auth.Register(registerRequestDto);
            if (result !=null)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
