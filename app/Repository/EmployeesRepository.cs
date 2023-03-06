using app.Data;
using app.Models;
using app.Interfaces;
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

    public async Task<List<EmployeesModel>> GetAllEmployees()
    {
      return await _context.Employees.ToListAsync();
    }

    public async Task<EmployeesModel> GetById(int id)
    {
      return await _context.Employees.FirstAsync(x => x.Id == id);
    }

    public async Task<EmployeesModel> CreateEmployee(EmployeesModel employee)
    {
      _context.Employees.Add(employee);
      await _context.SaveChangesAsync();

      return employee;
    }

    public async Task<EmployeesModel> UpdateEmployee(EmployeesModel employee)
    {
      _context.Employees.Update(employee);
      await _context.SaveChangesAsync();

      return employee;
    }

    public async Task<bool> DeleteEmployee(int id)
    {
      var employeeDb = await GetById(id);

      _context.Employees.Remove(employeeDb);
      await _context.SaveChangesAsync();

      return true;
    }
  }
}

