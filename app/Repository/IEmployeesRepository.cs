using app.Models;

namespace app.Repository
{
  public interface IEmployeesRepository
    {
        Task<IEnumerable<EmployeesModel>> GetAllEmployees();
        Task<EmployeesModel> GetById();
        void CreateEmployee(EmployeesModel employee);
        void UpdateEmployee(EmployeesModel employee);
        void DeleteEmployee(EmployeesModel employee);
    }
}
