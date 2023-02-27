
using app.Models;
using Microsoft.EntityFrameworkCore;

namespace app.Data
{
  public class EmployeesContext : DbContext
  {
    public EmployeesContext(DbContextOptions<EmployeesContext> options) : base(options) { }

    public DbSet<EmployeesModel> Employess { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var employess = modelBuilder.Entity<EmployeesModel>();
        employess.ToTable("tb_employess");
    }
  }
}
