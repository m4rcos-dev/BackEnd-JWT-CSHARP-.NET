using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace app.Utils
{
  public class JwtGenerate
  {
    private readonly AppSettings _appSettings;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly UserManager<IdentityUser> _userManager;

    public JwtGenerate(IOptions<AppSettings> appSettings,
                        SignInManager<IdentityUser> signInManager,
                        UserManager<IdentityUser> userManager)
    {
      _appSettings = appSettings.Value;
      _signInManager = signInManager;
      _userManager = userManager;
    }

    public async Task<string> CreateJwt(string email)
    {
        var user = await _userManager.FindByEmailAsync(email);

        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(_appSettings.Secret);

        var tokenDescriptor = new SecurityTokenDescriptor
      {
        // Subject = identityClaims,


        //Subject = new ClaimsIdentity(new[]
        //{
        //    new Claim(ClaimTypes.Name, user.Id)
        //}),
        Issuer = _appSettings.Emissor,
        Audience = _appSettings.Valid,
        Expires = DateTime.UtcNow.AddHours(_appSettings.ExpirationHours),
        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
      };

      return tokenHandler.WriteToken(tokenHandler.CreateToken(tokenDescriptor));
    }

  }
}
