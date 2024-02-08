using Microsoft.AspNetCore.Mvc;
using TechMed.Application.InputModels;
using TechMed.Application.ViewModels;

namespace TechMed.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login([FromBody] LoginInputModel user){
            throw new NotImplementedException();
        }
    }
}
