using app.Interfaces;
using app.Models;
using Microsoft.AspNetCore.Mvc;

namespace app.Controllers
{
  [ApiController]
  [Route("/employees")]
  public class EmployeesController : ControllerBase
  {
    private readonly IEmployeesService _service;

    public EmployeesController(IEmployeesService service)
    {
      _service = service;
    }

    [HttpGet("getall")]
    public async Task<IActionResult> GetAll()
    {
      var employees = await _service.GetAllEmployees();
      return Ok(employees);
    }

    [HttpGet("get/{id}")]
    public async Task<IActionResult> GetById(int id)
    {
      var employee = await _service.GetById(id);
      return Ok(employee);
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreateEmployee(EmployeesModel employee)
    {
      await _service.CreateEmployee(employee);
      return Ok("Registered employee");
    }

    [HttpPut("update/{id}")]
    public async Task<IActionResult> UpdateEmployee(EmployeesModel employee, int id)
    {
      await _service.UpdateEmployee(employee, id);
      return Ok("Updated emplyoee");
    }

    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> DeleteEmployee(int id)
    {
      await _service.DeleteEmployee(id);
      return Ok("Deleted employee");
    }
  }
}
