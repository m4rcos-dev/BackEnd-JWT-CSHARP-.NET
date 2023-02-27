using app.Data;
using app.Models;
using Microsoft.EntityFrameworkCore;

namespace app.Repository
{
  public class EmployeesRepository : IEmployeesRepository
  {
    private readonly EmployeesContext _context;

    public EmployeesRepository(EmployeesContext context)
    {
      _context = context;
    }

    public Task<List<EmployeesModel>> GetAllEmployees()
    {
      return Task.FromResult(_context.Employess.ToList());
    }

    public Task<EmployeesModel> GetById(int id)
    {
      return _context.Employess.FirstAsync(x => x.Id == id);
    }

    public void CreateEmployee(EmployeesModel employee)
    {
      _context.Add(employee);
    }

    public void UpdateEmployee(EmployeesModel employee)
    {
      _context.Update(employee);
    }

    public void DeleteEmployee(EmployeesModel employee)
    {
      throw new NotImplementedException();
    }

    public async Task<bool> SaveChangeAsync()
    {
      return await _context.SaveChangesAsync() > 0;
    }
  }
}
