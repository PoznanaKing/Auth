namespace Auth.Models.Dtos
{
    public record LoginRequestDto(string UserName, string Password);
    public record RegisterRequestDto(string UserName, string Password, string Email,string FullName);
}
