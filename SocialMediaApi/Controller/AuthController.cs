using Microsoft.AspNetCore.Mvc;
using SocialMediaBusiness.Interface;

namespace SocialMediaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUserManager _userManager;

        public AuthController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        // Temporary GET method for testing
        [HttpGet("TestRegister")]
        public string TestRegister(string email, string password)
        {
            // Call async method correctly
           var result =  _userManager.RegisterUserAsync(email, password);

            // if (result!= null)
          

            return result;
        }
    }
}
