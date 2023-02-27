
using app.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace app.Data
{
  public class EmployeesContext : IdentityDbContext
  {
    public EmployeesContext(DbContextOptions<EmployeesContext> options) : base(options) { }

    public DbSet<EmployeesModel> Employess { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
      
      var employess = modelBuilder.Entity<EmployeesModel>();
      employess.ToTable("tb_employess");
      employess.HasKey(x => x.Id);
      employess.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
      employess.Property(x => x.Name).HasColumnName("name").IsRequired();
      employess.Property(x => x.Sector).HasColumnName("sector").IsRequired();
      employess.Property(x => x.Role).HasColumnName("role").IsRequired();

      employess.HasData(new List<EmployeesModel>{
            new EmployeesModel(1, "Levi Mário Levi Monteiro", "Administrativo", "CEO"),
            new EmployeesModel(2, "Raquel Andreia Emilly Fogaça", "Administrativo", "CTO"),
            new EmployeesModel(3, "Sônia Carolina Marcela da Silva", "Financeiro", "Contabilidade"),
            new EmployeesModel(4, "Luiz Hugo Renan Dias", "Recursos Humanos", "Gestor de pessoas"),
            new EmployeesModel(5, "Antônia Bianca Lara Almeida", "Operacional", "DevOps"),
            new EmployeesModel(6, "Hugo Cauê Carlos Eduardo Martins", "Operacional", "Dev FrontEnd"),
            new EmployeesModel(7, "Cauê Matheus Nicolas Santos", "Operacional", "Dev BacktEnd"),
            new EmployeesModel(8, "Elias Luís Moreira", "Comercial", "PO"),
            new EmployeesModel(9, "Eliane Melissa Barros", "Comercial", "Marketing"),
            new EmployeesModel(10, "José Hugo Araújo", "Comercial", "Atendimento"),
        });
    }
  }
}
