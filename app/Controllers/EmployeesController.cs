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
    public async Task<IActionResult> GetAll()
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

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
      try
      {
        var employee = await _repository.GetById(id);
        return Ok(employee);
      }
      catch(Exception error)
      {
        var typeError = error.Data == null || error.Data.Count == 0;
        return typeError ? NotFound("Eemployee not found") : BadRequest(error.Message);
      }
    }
  }
}
