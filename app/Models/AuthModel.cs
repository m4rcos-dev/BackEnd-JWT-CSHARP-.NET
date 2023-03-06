using System.ComponentModel.DataAnnotations;

namespace app.Models
{
  public class AuthModel
  {
    public class RegisterUser
    {
      [Required(ErrorMessage = "The field {0} is required")]
      [EmailAddress(ErrorMessage = "The fiel {0} format is invalid")]
      public string Email { get; set; }

      [Required(ErrorMessage = "The field {0} is required")]
      [StringLength(100, ErrorMessage = "The field {0} must be between {2} and {1}", MinimumLength = 4)]
      public string Password { get; set; }
    }

    public class LoginUser
    {
      [Required(ErrorMessage = "The field {0} is required")]
      [EmailAddress(ErrorMessage = "The fiel {0} format is invalid")]
      public string Email { get; set; }

      [Required(ErrorMessage = "The field {0} is required")]
      [StringLength(100, ErrorMessage = "The field {0} must be between {2} and {1}", MinimumLength = 4)]
      public string Password { get; set; }
    }
  }
}
