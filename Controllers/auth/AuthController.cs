using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using itsppisapi.Data;
using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace itsppisapi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AuthController : ControllerBase
  {
    private readonly IAuthRepository _repository;
    private readonly IConfiguration _config;

    public AuthController(IAuthRepository repository, IConfiguration config)
    {
      _repository = repository;
      _config = config;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
    {
      userForRegisterDto.USER_NAME = userForRegisterDto.USER_NAME.ToLower();

      if (await _repository.UserExists(userForRegisterDto.USER_NAME))
        return BadRequest("UserName already Exists.");

      var userToCreate = new PPM_GL_MST_USERS
      {
        USER_NAME = userForRegisterDto.USER_NAME,
        USER_DESC = userForRegisterDto.USER_DESC,
        USER_LEVEL = 0,
        USER_DEPT = userForRegisterDto.USER_DEPT,
        STATUS = "A",
        EPR_NO = userForRegisterDto.EPR_NO,
        USER_EMAIL = userForRegisterDto.USER_EMAIL
      };

      var createdUser = await _repository.Register(userToCreate, userForRegisterDto.PASSWORD);

      return StatusCode(201);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(UserForLoginDto userForLoginDto)
    {
      var userFromRepository = await _repository.Login(userForLoginDto.USER_NAME.ToLower(), userForLoginDto.PASSWORD);

      if (userFromRepository == null)
          return Unauthorized();
      
      var claims = new[]
      {
         new Claim(ClaimTypes.NameIdentifier, userFromRepository.USER_ID.ToString()),
         new Claim(ClaimTypes.Name, userFromRepository.USER_NAME)
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
