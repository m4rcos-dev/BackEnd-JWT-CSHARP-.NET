using app.Models;
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

    [HttpPost]
    public async Task<IActionResult> CreateEmployee(EmployeesModel employee)
    {
      try
      {
        if(employee.Name == null || employee.Name == "") throw new Exception("name field required");
        if(employee.Sector == null || employee.Sector == "") throw new Exception("sector field required");
        if(employee.Role == null || employee.Role == "") throw new Exception("role field required");

        _repository.CreateEmployee(employee);
        await _repository.SaveChangeAsync();
        return Ok("Registered employee");
      }
      catch(Exception error)
      {
        return BadRequest(error.Message);
      }
    }
  }
}
