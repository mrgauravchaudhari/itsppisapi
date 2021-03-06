using itsppisapi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace itsppisapi.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private UserManager<PPM_GL_MST_USERS> _userManager;
        public UserProfileController(UserManager<PPM_GL_MST_USERS> userManager)
        {
            _userManager = userManager;
        }

        //GET : /api/UserProfile
        [HttpGet]
        public async Task<Object> Get()
        {
            string USER_ID = User.Claims.First(c => c.Type == "USER_ID").Value;
            var user = await _userManager.FindByIdAsync(USER_ID);
            return new
            {
                user.USER_DESC,
                user.USER_EMAIL,
                user.USER_NAME,
                user.USER_ID
            };
        }
    }
}
