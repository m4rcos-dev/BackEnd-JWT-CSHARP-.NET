using app.Models;

namespace app.Interfaces
{
  public interface IEmployeesService
  {
    Task<List<EmployeesModel>> GetAllEmployees();
    Task<EmployeesModel> GetById(int id);
    Task<EmployeesModel> CreateEmployee(EmployeesModel employee);
    Task<EmployeesModel> UpdateEmployee(EmployeesModel employee, int id);
    Task<bool> DeleteEmployee(int id);
  }
}
