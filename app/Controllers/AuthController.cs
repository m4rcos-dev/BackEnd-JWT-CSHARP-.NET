using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using static app.Models.AuthModel;

namespace app.Controllers
{
  [ApiController]
  [Route("/auth")]

  public class AuthController : ControllerBase
  {
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly UserManager<IdentityUser> _userManager;

    public AuthController(SignInManager<IdentityUser> signInManager,
                            UserManager<IdentityUser> userManager)
    {
      _signInManager = signInManager;
      _userManager = userManager;
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

        return Ok();
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
            return Ok("Login sucess");
        }
        catch(Exception error)
        {
            return BadRequest(error.Message);
        }
    }
  }
}
