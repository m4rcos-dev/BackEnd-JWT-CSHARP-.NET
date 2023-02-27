using Microsoft.AspNetCore.Mvc;

namespace app.Controllers
{
  [ApiController]
  [Route("/employess")]
  public class EmployeesController
  {
    [HttpGet]

    public string Get()
    {
        return "Ok";
    }
  }
}
