using app.Interfaces;
using app.Models;

namespace app.Services
{
  public class EmployeesService : IEmployeesService
  {
    private readonly IEmployeesRepository _repository;

    public EmployeesService(IEmployeesRepository repository)
    {
      _repository = repository;
    }

    public async Task<List<EmployeesModel>> GetAllEmployees()
    {
      return await _repository.GetAllEmployees();
    }

    public async Task<EmployeesModel> GetById(int id)
    {
      return await _repository.GetById(id);
    }

    public async Task<EmployeesModel> CreateEmployee(EmployeesModel employee)
    {
      return await _repository.CreateEmployee(employee);
    }

    public async Task<EmployeesModel> UpdateEmployee(EmployeesModel employee, int id)
    {
      var employeeDb = await _repository.GetById(id);

      employeeDb.Name = employee.Name ?? employeeDb.Name;
      employeeDb.Role = employee.Role ?? employeeDb.Role;
      employeeDb.Sector = employee.Sector ?? employeeDb.Sector;

      return await _repository.UpdateEmployee(employeeDb);
    }

    public async Task<bool> DeleteEmployee(int id)
    {
      var userDb = await _repository.GetById(id);
      if (userDb == null) throw new Exception("User not found");

      return await _repository.DeleteEmployee(id);
    }

  }
}
