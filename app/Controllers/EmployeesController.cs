using app.Repository;
using Microsoft.AspNetCore.Mvc;

namespace app.Controllers
{
  [ApiController]
  [Route("/employess")]
  public class EmployeesController

  {
    private readonly IEmployeesRepository _repository;

    public EmployeesController(IEmployeesRepository repository)
    {
      _repository = repository;
    }
    
    [HttpGet]

    public string Get()
    {
      return "Ok";
    }
  }
}
