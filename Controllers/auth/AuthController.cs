using itsppisapi.Data;
using itsppisapi.Dtos;
using itsppisapi.Helpers;
using itsppisapi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace itsppisapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repository;
        private readonly IConfiguration _config;
        private EmailHelper _emailHelper;

        public AuthController(IAuthRepository repository, IConfiguration config, EmailHelper emailHelper)
        {
            _repository = repository;
            _config = config;
            _emailHelper = emailHelper;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
            if (await _repository.UserExists(userForRegisterDto.USER_NAME))
                return BadRequest("UserName already Exists.");

            if (await _repository.UserEPRNOExists(userForRegisterDto.USER_EPR_NO))
                return BadRequest("EprNo already Exists.");

            var userToCreate = new PPM_GL_MST_USERS
            {
                USER_NAME = userForRegisterDto.USER_NAME,
                USER_DESC = userForRegisterDto.USER_DESC,
                USER_LEVEL = 0,
                USER_DEPT = userForRegisterDto.USER_DEPT,
                ACTIVE_FLAG = "A",
                USER_EPR_NO = userForRegisterDto.USER_EPR_NO,
                USER_PHONE_NO = userForRegisterDto.USER_PHONE_NO,
                USER_EMAIL = userForRegisterDto.USER_EMAIL,
                ENTERED_BY = 0,
                MODIFIED_BY = 0
            };

            var createdUser = await _repository.Register(userToCreate, userForRegisterDto.PASSWORD);
            if (createdUser != null)
            {
                var message = "Hello, " + userForRegisterDto.USER_DESC + "<br>" +
                    "<br><p>Welcome to <b>Plant Performance Information System (PPIS)</b> of Chambal Fertilisers and Chemicals Limited. We're glad to have you.</p><br>" +
                    "Here are your PPIS system account details: <br>" +
                    "<ul>" +
                    "<li>UserName :" + userForRegisterDto.USER_NAME + "</li>" +
                    "<li>Password : " + userForRegisterDto.PASSWORD + "</li>" +
                    "</ul>" +
                    "<br>" +
                    "click <a href='http://192.168.201.27:8091'>here</a> for login PPIS system";

                var emailModel = new EmailHelperModel(userForRegisterDto.USER_EMAIL, // To  
                    "PPIS Account", // from display name
                    "Welcome to PPIS Application", // Subject  
                    message, // Message  
                    true // IsBodyHTML  
                    );
                _emailHelper.SendEmail(emailModel);
            }
            return StatusCode(201);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserForLoginDto userForLoginDto)
        {
            var ResetStatus = await _repository.UserResetStatus(userForLoginDto.USER_NAME);

            if(ResetStatus == true)
                return BadRequest("Reset Pending.");

            var userFromRepository = await _repository.Login(userForLoginDto.USER_NAME, userForLoginDto.PASSWORD);

            if (userFromRepository == null)
                return Unauthorized();

            var ValidityStatus = await _repository.UserValidityStatus(userForLoginDto.USER_NAME);

            if (ValidityStatus == true)
                return BadRequest("Validity Pass.");

            var claims = new[] {
                new Claim (ClaimTypes.NameIdentifier, userFromRepository.USER_ID.ToString ()),
                new Claim (ClaimTypes.Name, userFromRepository.USER_NAME)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8
                .GetBytes(_config.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddHours(8),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return Ok(new
            {
                token = tokenHandler.WriteToken(token)
            });
        }

        //[HttpPut("profile")]
        //public async Task<IActionResult> Profile(StringParameterDto data)
        //{
        //  var user = await _repository.Profile(data.StringParameter.ToLower());

        //  return Ok(user);
        //}
    }
}