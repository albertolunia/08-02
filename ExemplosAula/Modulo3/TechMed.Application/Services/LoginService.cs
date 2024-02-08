using TechMed.Application.InputModels;
using TechMed.Application.ViewModels;
using TechMed.Application.Services.Interfaces;
using TechMed.Infrastructure.Auth;

namespace TechMed.Application.Services;

public class LoginService : ILoginService
{
    private readonly IAuthService _authService;
    public LoginService(IAuthService authService)
    {
        _authService = authService;
    }
    public LoginViewModel? Authenticate(LoginInputModel login)
    {
        var passHashed = _authService.ComputeSha256Hash(login.Password);
        //if (login.Username == "admin" && login.Password == "admin"){}
        throw new NotImplementedException();
    }
}
