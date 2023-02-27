using app.Repository;
using Microsoft.AspNetCore.Mvc;

namespace app.Controllers
{
  [ApiController]
  [Route("/employess")]
  public class EmployeesController : ControllerBase
  {
    private readonly IEmployeesRepository _repository;

    public EmployeesController(IEmployeesRepository repository)
    {
      _repository = repository;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
      try
      {
        var employees = await _repository.GetAllEmployees();
        return Ok(employees);
      }
      catch(Exception error)
      {
        return BadRequest(error.Message);
      }
    }
  }
}
