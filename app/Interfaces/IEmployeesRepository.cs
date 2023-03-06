using app.Models;

namespace app.Interfaces
{
  public interface IEmployeesRepository
  {
    Task<List<EmployeesModel>> GetAllEmployees();
    Task<EmployeesModel> GetById(int id);
    Task<EmployeesModel> CreateEmployee(EmployeesModel employee);
    Task<EmployeesModel> UpdateEmployee(EmployeesModel employee);
    Task<bool> DeleteEmployee(int id);
  }
}
