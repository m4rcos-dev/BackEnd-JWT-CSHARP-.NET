using app.Models;

namespace app.Repository
{
  public interface IEmployeesRepository
    {
        Task<List<EmployeesModel>> GetAllEmployees();
        Task<EmployeesModel> GetById(int id);
        void CreateEmployee(EmployeesModel employee);
        void UpdateEmployee(EmployeesModel employee);
        void DeleteEmployee(EmployeesModel employee);
        Task<bool> SaveChangeAsync();
    }
}
