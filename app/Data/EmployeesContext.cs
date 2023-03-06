using app.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace app.Data
{
  public class EmployeesContext : IdentityDbContext
  {
    public EmployeesContext(DbContextOptions<EmployeesContext> options) : base(options) { }

    public DbSet<EmployeesModel> Employees { get; set; }

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

      modelBuilder.Entity<IdentityRole>().HasData(
        new IdentityRole { Id = "1", Name = "Administrativo", NormalizedName = "ADMINISTRATIVO" },
        new IdentityRole { Id = "2", Name = "Financeiro", NormalizedName = "FINANCEIRO" },
        new IdentityRole { Id = "3", Name = "Recursos Humanos", NormalizedName = "RECURSOS HUMANOS" },
        new IdentityRole { Id = "4", Name = "Operacional", NormalizedName = "OPERACIONAL" },
        new IdentityRole { Id = "5", Name = "Comercial", NormalizedName = "COMERCIAL" }
      );

      var hasher = new PasswordHasher<IdentityUser>();

      modelBuilder.Entity<IdentityUser>().HasData(
        new IdentityUser { Id = "1", UserName = "monteirolevi@admin.com", NormalizedUserName = "MONTEIROLEVI@ADMIN.COM", Email = "monteirolevi@admin.com", NormalizedEmail = "MONTEIROLEVI@ADMIN.COM", EmailConfirmed = true, PasswordHash = hasher.HashPassword(null, "@Admin123"), SecurityStamp = string.Empty },
        new IdentityUser { Id = "2", UserName = "emillyraquel@admin.com", NormalizedUserName = "EMELLYRAQUEL@ADMIN.COM", Email = "emillyraquel@admin.com", NormalizedEmail = "EMELLYRAQUEL@ADMIN.COM", EmailConfirmed = true, PasswordHash = hasher.HashPassword(null, "@Admin123"), SecurityStamp = string.Empty },
        new IdentityUser { Id = "3", UserName = "marcelasonia@finan.com", NormalizedUserName = "MARCELASONIA@FINAN.COM", Email = "marcelasonia@finan.com", NormalizedEmail = "MARCELASONIA@FINAN.COM", EmailConfirmed = true, PasswordHash = hasher.HashPassword(null, "@Finan123"), SecurityStamp = string.Empty },
        new IdentityUser { Id = "4", UserName = "renanluiz@rh.com", NormalizedUserName = "RENANLUIZ@RH.COM", Email = "renanluiz@rh.com", NormalizedEmail = "RENANLUIZ@RH.COM", EmailConfirmed = true, PasswordHash = hasher.HashPassword(null, "@Rh123"), SecurityStamp = string.Empty },
        new IdentityUser { Id = "5", UserName = "biancalara@opera.com", NormalizedUserName = "BIANCALARA@OPERA.COM", Email = "biancalara@opera.com", NormalizedEmail = "BIANCALARA@OPERA.COM", EmailConfirmed = true, PasswordHash = hasher.HashPassword(null, "@Opera123"), SecurityStamp = string.Empty },
        new IdentityUser { Id = "6", UserName = "cauecarlos@opera.com", NormalizedUserName = "CAUECARLOS@OPERA.COM", Email = "cauecarlos@opera.com", NormalizedEmail = "CAUECARLOS@OPERA.COM", EmailConfirmed = true, PasswordHash = hasher.HashPassword(null, "@Opera123"), SecurityStamp = string.Empty },
        new IdentityUser { Id = "7", UserName = "cauematheus@opera.com", NormalizedUserName = "CAUEMATHEUS@OPERA.COM", Email = "cauematheus@opera.com", NormalizedEmail = "CAUEMATHEUS@OPERA.COM", EmailConfirmed = true, PasswordHash = hasher.HashPassword(null, "@Opera123"), SecurityStamp = string.Empty },
        new IdentityUser { Id = "8", UserName = "luiselias@comercial.com", NormalizedUserName = "LUISELIAS@COMERCIAL.COM", Email = "luiselias@comercial.com", NormalizedEmail = "LUISELIAS@COMERCIAL.COM", EmailConfirmed = true, PasswordHash = hasher.HashPassword(null, "@Comercial123"), SecurityStamp = string.Empty },
        new IdentityUser { Id = "9", UserName = "barroseliane@comercial.com", NormalizedUserName = "BARROSELIANE@COMERCIAL.COM", Email = "barroseliane@comercial.com", NormalizedEmail = "BARROSELIANE@COMERCIAL.COM", EmailConfirmed = true, PasswordHash = hasher.HashPassword(null, "@Comercial123"), SecurityStamp = string.Empty },
        new IdentityUser { Id = "10", UserName = "araujojose@comercial.com", NormalizedUserName = "ARAUJOJOSE@COMERCIAL.COM", Email = "araujojose@comercial.com", NormalizedEmail = "ARAUJOJOSE@COMERCIAL.COM", EmailConfirmed = true, PasswordHash = hasher.HashPassword(null, "@Comercial123"), SecurityStamp = string.Empty }
      );

      modelBuilder.Entity<IdentityUserRole<string>>().HasData(
        new IdentityUserRole<string> { UserId = "1", RoleId = "1" },
        new IdentityUserRole<string> { UserId = "2", RoleId = "1" },
        new IdentityUserRole<string> { UserId = "3", RoleId = "2" },
        new IdentityUserRole<string> { UserId = "4", RoleId = "3" },
        new IdentityUserRole<string> { UserId = "5", RoleId = "4" },
        new IdentityUserRole<string> { UserId = "6", RoleId = "4" },
        new IdentityUserRole<string> { UserId = "7", RoleId = "4" },
        new IdentityUserRole<string> { UserId = "8", RoleId = "5" },
        new IdentityUserRole<string> { UserId = "9", RoleId = "5" },
        new IdentityUserRole<string> { UserId = "10", RoleId = "5" }
      );

      modelBuilder.Entity<IdentityUserClaim<string>>().HasData(
        new IdentityUserClaim<string> { Id = Guid.NewGuid().GetHashCode(), UserId = "1", ClaimType = "Administrativo", ClaimValue = "Create,Read,Update,Delete" },
        new IdentityUserClaim<string> { Id = Guid.NewGuid().GetHashCode(), UserId = "2", ClaimType = "Administrativo", ClaimValue = "Create,Read,Update,Delete" },
        new IdentityUserClaim<string> { Id = Guid.NewGuid().GetHashCode(), UserId = "3", ClaimType = "Financeiro", ClaimValue = "Read" },
        new IdentityUserClaim<string> { Id = Guid.NewGuid().GetHashCode(), UserId = "4", ClaimType = "Recursos Humanos", ClaimValue = "Create,Read,Update,Delete" },
        new IdentityUserClaim<string> { Id = Guid.NewGuid().GetHashCode(), UserId = "5", ClaimType = "Operacional", ClaimValue = "Read" },
        new IdentityUserClaim<string> { Id = Guid.NewGuid().GetHashCode(), UserId = "6", ClaimType = "Operacional", ClaimValue = "Read" },
        new IdentityUserClaim<string> { Id = Guid.NewGuid().GetHashCode(), UserId = "7", ClaimType = "Operacional", ClaimValue = "Read" },
        new IdentityUserClaim<string> { Id = Guid.NewGuid().GetHashCode(), UserId = "8", ClaimType = "Comercial", ClaimValue = "Read" },
        new IdentityUserClaim<string> { Id = Guid.NewGuid().GetHashCode(), UserId = "9", ClaimType = "Comercial", ClaimValue = "Read" },
        new IdentityUserClaim<string> { Id = Guid.NewGuid().GetHashCode(), UserId = "10", ClaimType = "Comercial", ClaimValue = "Read" }
      );
    }
  }
}
