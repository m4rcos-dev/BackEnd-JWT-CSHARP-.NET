using System.IdentityModel.Tokens.Jwt;
using System.Text;
using app.Utils;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using static app.Models.AuthModel;

namespace app.Controllers
{
  [ApiController]
  [Route("/auth")]

  public class AuthController : ControllerBase
  {
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly AppSettings _appSettings;
    private readonly JwtGenerate _jwtGenerate;

    public AuthController(SignInManager<IdentityUser> signInManager,
                            UserManager<IdentityUser> userManager,
                            IOptions<AppSettings> appSettings)
    {
      _signInManager = signInManager;
      _userManager = userManager;
      _appSettings = appSettings.Value;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterUser registerUser)
    {
      try
      {
        var user = new IdentityUser
        {
          UserName = registerUser.Email,
          Email = registerUser.Email,
          EmailConfirmed = true
        };

        await _userManager.CreateAsync(user, registerUser.Password);

        return Ok(await CreateJwt(registerUser.Email));
      }
      catch (Exception error)
      {
        return BadRequest(error.Message);
      }
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginUser loginUser)
    {
        try
        {
            await _signInManager.PasswordSignInAsync(loginUser.Email, loginUser.Password, false, true);
            return Ok(await CreateJwt(loginUser.Email));
        }
        catch(Exception error)
        {
            return BadRequest(error.Message);
        }
    }

    private async Task<string> CreateJwt(string email)
    {
        var user = await _userManager.FindByEmailAsync(email);

        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(_appSettings.Secret);

        var tokenDescriptor = new SecurityTokenDescriptor
      {
        Issuer = _appSettings.Emissor,
        Audience = _appSettings.Valid,
        Expires = DateTime.UtcNow.AddHours(_appSettings.ExpirationHours),
        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
      };

      return tokenHandler.WriteToken(tokenHandler.CreateToken(tokenDescriptor));
    }
  }
}
